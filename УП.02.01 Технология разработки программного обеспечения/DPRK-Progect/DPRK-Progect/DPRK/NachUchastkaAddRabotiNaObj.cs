using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRK
{
    public partial class NachUchastkaAddRabotiNaObj : Form
    {
        string roles;
        int idObjects;
        int idEmployers;

        int idVidWorking;
        int idBrigade;
        int idRaboti;

        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();

        public NachUchastkaAddRabotiNaObj()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов. Добавления в выпадающий список вид работы и доступтные бригады.
        /// Задание минимальной даты в календаре.
        /// </summary>
        /// <param name="role">Роль вошедшего</param>
        /// <param name="idObject">Номер тип объекта </param>
        /// <param name="idEmployer">Номер сотрудника</param>
        public NachUchastkaAddRabotiNaObj(string role,int idObject,int idEmployer)
        {
            InitializeComponent();
            completionDate.MinDate = DateTime.Now;
            roles = role;
            idObjects = idObject;
            idEmployers = idEmployer;

            sqlManager.AddComboBox(brigade, "[dbo].[Employee_Brigad]", 1);
            sqlManager.AddComboBox(vidWork, "[dbo].[Vid_Rabot]", 1);
        }

        /// <summary>
        /// Нажатие на кнопку "Отменить" на форме NachUchastkaAddRabotiNaObj для перехода в NachUchastka
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            if (roles == "Администратор информационной системы")
            {
                idEmployers = 0;
            }
            NachUchastka nachUchastka = new NachUchastka(roles,idEmployers);
            nachUchastka.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Подтвердить на форме NachUchastkaAddRabotiNaObj для перехода в NachUchastka и занесением данных в БД что в последствии сформирует работу на объекте "
        /// </summary>
        private void confirm_Click(object sender, EventArgs e)
        {
            if (vidWork.Text != "" && brigade.Text != "")
            {
                string date = completionDate.Value.ToShortDateString();
                DataTable dataTable  = sqlManager.ReturnTable($@"select * from [dbo].[Rabota_Brigadi] where [dbo].[Rabota_Brigadi].[ID_Brigadira] = {idBrigade} and [dbo].[Rabota_Brigadi].[ID_Vida] = {idVidWorking}");
                if (dataTable.Rows.Count == 0)
                {
                    sqlManager.RequestSql($@"insert into [dbo].[Rabota_Brigadi] values ({idBrigade},{idVidWorking})");
                    idRaboti = Convert.ToInt32(sqlManager.ReturnTable("select max([dbo].[Rabota_Brigadi].[ID_Raboti]) from [dbo].[Rabota_Brigadi]").Rows[0][0]);
                }
                else
                {
                    idRaboti = Convert.ToInt32(dataTable.Rows[0][0]);
                }
                Random random = new Random();
                int ran = random.Next(0, 5);
                sqlManager.RequestSql($@"insert into [dbo].[Raboti_Na_Obiecte] values ({idObjects},{idRaboti},'Работа выполняется','{date}',{ran})");

                if (roles == "Администратор информационной системы")
                {
                    idEmployers = 0;
                }
                NachUchastka nachUchastka = new NachUchastka(roles, idEmployers);
                nachUchastka.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Поля вид работы, бригада, срок выполнения работы должны быть заполнены.");
            }
        }

        /// <summary>
        /// Получение номера вида работы
        /// </summary>
        private void vidWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Vid_Rabot] where [dbo].[Vid_Rabot].[Name] = '{vidWork.Text}'");
            if (dataTable.Rows.Count > 0)
                idVidWorking = Convert.ToInt32(dataTable.Rows[0][0]);
        }

        /// <summary>
        /// Получение номера бригады
        /// </summary>
        private void brigade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Seartch_Brigadir_Search] ('{brigade.Text}')");
            if (dataTable.Rows.Count > 0)
                idBrigade = Convert.ToInt32(dataTable.Rows[0][0]);
        }
    }
}
