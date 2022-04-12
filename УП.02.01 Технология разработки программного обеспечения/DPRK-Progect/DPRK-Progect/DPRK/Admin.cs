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
    public partial class Admin : Form
    {
        static string role = "Администратор информационной системы";
        public Admin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку "Начальник участка"
        /// </summary>
        private void headStation_Click(object sender, EventArgs e)
        {
            NachUchastka nachUchastka = new NachUchastka(role, 0);
            nachUchastka.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Менеджер"
        /// </summary>
        private void manager_Click(object sender, EventArgs e)
        {
            ManagerRegObj managerRegObj = new ManagerRegObj("Администратор Менеджер информационной системы");
            managerRegObj.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Глава строительного управления"
        /// </summary>
        private void headConstructionDepartment_Click(object sender, EventArgs e)
        {
            GlavStroiUpr glavStroiUpr = new GlavStroiUpr(role);
            glavStroiUpr.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Бригадир"
        /// </summary>
        private void brigadir_Click(object sender, EventArgs e)
        {
            BrigadirAddRabochih brigadirAddRabochih = new BrigadirAddRabochih(role, 0);
            brigadirAddRabochih.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "HR менеджер"
        /// </summary>
        private void hrManager_Click(object sender, EventArgs e)
        {
            HRmanager HRmanager = new HRmanager(role);
            HRmanager.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Выйти" на форме Admin
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
