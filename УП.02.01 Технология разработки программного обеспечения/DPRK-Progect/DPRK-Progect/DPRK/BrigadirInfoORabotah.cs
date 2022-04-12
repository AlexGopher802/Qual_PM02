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
    public partial class BrigadirInfoORabotah : Form
    {
        int idBrigad;
        string role;
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();

        public BrigadirInfoORabotah()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компоненотов и вывод работ на объектах у котрых статус не "Работа выполнена"
        /// </summary>
        /// <param name="idBrigada">Номер бригадира</param>
        /// <param name="roles">Роль сотрудника котрый зашел</param>
        public BrigadirInfoORabotah(int idBrigada, string roles)
        {
            InitializeComponent();
            idBrigad = idBrigada;
            role = roles;
            sqlManager.GetList(information, "[dbo].[Raboti_Na_Obiecte]", $@"select * from [dbo].[List_Worke] ({idBrigad})");
            information.Columns[0].Visible = false;
        }

        /// <summary>
        /// Нажатие на кнопку "Выйти" на форме BrigadirInfoORabotah, 
        /// переход на форму BrigadirAddRabochih
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            if (role == "Администратор информационной системы")
            {
                idBrigad = 0;
            }
            BrigadirAddRabochih brigadirAddRabochih = new BrigadirAddRabochih(role,idBrigad);
            brigadirAddRabochih.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Завершить работу", переход на форму BrigadirInfoORashMaterial
        /// </summary>
        private void finishWork_Click(object sender, EventArgs e)
        {
            if (information.Rows.Count > 1)
            {
                int idrow = information.CurrentRow.Index;
                int idWorkeObject = Convert.ToInt32(information.Rows[idrow].Cells[0].Value);
                BrigadirInfoORashMaterial brigadirInfoORashMaterial = new BrigadirInfoORashMaterial(idWorkeObject, role,idBrigad);
                brigadirInfoORashMaterial.Show();
                this.Hide();
            }
        }
    }
}
