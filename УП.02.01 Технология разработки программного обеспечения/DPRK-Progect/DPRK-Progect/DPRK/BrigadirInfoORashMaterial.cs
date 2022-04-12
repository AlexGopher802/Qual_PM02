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
    public partial class BrigadirInfoORashMaterial : Form
    {
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        int idWorking;
        string roles;
        int idBrig;
        public BrigadirInfoORashMaterial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов, занесение в выпадающий список материалов
        /// </summary>
        /// <param name="idwoek">Номер работы на объекте</param>
        /// <param name="role">Роль сотрудника котрый зашел</param>
        /// <param name="idBrigad"> Номер бригадира</param>
        public BrigadirInfoORashMaterial(int idwoek,string role,int idBrigad)
        {
            InitializeComponent();
            idWorking = idwoek;
            idBrig = idBrigad;
            roles = role;
            sqlManager.AddComboBox(material, "[dbo].[Material]", 1);
        }

        /// <summary>
        /// Нажатие на кнопку "Выйти" на форме BrigadirInfoORashMaterial котрый переходит на BrigadirAddRabochih
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            if (roles == "Администратор информационной системы")
            {
                idBrig = 0;
            }
            BrigadirAddRabochih brigadirAddRabochih = new BrigadirAddRabochih(roles, idBrig);
            brigadirAddRabochih.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Подтвердить" чтобы изменить статус работы на объекте и занчение расходуемых материалов в БД
        /// </summary>
        private void confirm_Click(object sender, EventArgs e)
        {
            if (informAtribute.Rows.Count > 1)
            {
                sqlManager.Update_Value("[dbo].[Raboti_Na_Obiecte]", "[dbo].[Raboti_Na_Obiecte].[Status]", "Работа выполнена", "[dbo].[Raboti_Na_Obiecte].[ID_Raboti_Na_Obiecte]", idWorking);
                string message = sqlManager.RequestSql($@"insert into [dbo].[Sdacha_Rabot] values ('{DateTime.Now.ToShortDateString()}',{idWorking})");
                if (message == "")
                {
                    int idSdachRabot = Convert.ToInt32(sqlManager.ReturnTable($@"select max([dbo].[Sdacha_Rabot].[ID_Sdachi_Rabot]) from [dbo].[Sdacha_Rabot]").Rows[0][0]);
                    for (int i = 0; i < informAtribute.Rows.Count - 1; i++)
                    {
                        DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Material] where [dbo].[Material].[Name] = '{informAtribute.Rows[i].Cells[0].Value}'");
                        int attributeNumber = Convert.ToInt32(dataTable.Rows[0][0]);
                        string valueDataGrid = informAtribute.Rows[i].Cells[1].Value.ToString();
                        sqlManager.RequestSql($@"insert into [dbo].[Rashod_Materialov] values ({valueDataGrid},{attributeNumber},{idSdachRabot})");
                    }
                    BrigadirAddRabochih brigadirAddRabochih = new BrigadirAddRabochih(roles, idBrig);
                    brigadirAddRabochih.Show();
                    this.Hide();
                }
                else
                {
                    BrigadirAddRabochih brigadirAddRabochih = new BrigadirAddRabochih(roles, idBrig);
                    brigadirAddRabochih.Show();
                    this.Hide();
                    MessageBox.Show("Такие работы уже завершены.");
                }
            }
            else
            {
                MessageBox.Show("Введите значения атрибутов.");
            }
        }

        /// <summary>
        /// Удаление записи из списка
        /// </summary>
        private void delete_Click(object sender, EventArgs e)
        { 
            informAtribute.Rows.RemoveAt(informAtribute.SelectedCells[0].RowIndex);
        }

        /// <summary>
        /// Добавление записи в список
        /// </summary>
        private void add_Click(object sender, EventArgs e)
        {
            if (material.Text != "")
            {
                if (value.Text.Replace(" ", string.Empty).Length < 1)
                {
                    MessageBox.Show("Вы не ввели значение для атрибута. ");
                }
                else
                {
                    if (Convert.ToInt32(value.Text) < 1)
                    {
                        MessageBox.Show("Значение должно быть больше нуля.");
                    }
                    else
                    {
                        if (value.Text.Length > 50)
                        {
                            MessageBox.Show("Значение не более 50 символов.");
                        }
                        else
                        {
                            int rowNumber = informAtribute.Rows.Add();
                            informAtribute.Rows[rowNumber].Cells[0].Value = material.Text;
                            informAtribute.Rows[rowNumber].Cells[1].Value = Convert.ToInt32(value.Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали материал.");
            }
        }

        /// <summary>
        /// Ограничения ввода символов в поле value
        /// </summary>
        private void value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToInt32(Keys.Back) )
            {
                e.Handled = true;
            }
        }
    }
}
