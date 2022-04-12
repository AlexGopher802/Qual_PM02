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
    public partial class GlavStroiUpr : Form
    {
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        string roles;

        public GlavStroiUpr()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов, добавление информации обучастках.
        /// А также информация об строительной технике
        /// </summary>
        /// <param name="role">Роль вошедшего</param>
        public GlavStroiUpr(string role)
        {
           InitializeComponent();
           roles = role;
           sqlManager.GetList(informationRegion, "[dbo].[Uchastok]", "select * from [dbo].[Information_About_Land_Plots]");
           sqlManager.GetList(informationConstructionEquipment, "[dbo].[Tekhnica_Na_Uchastke]", "select * from [dbo].[Equipment_On_The_Site]");
        }

        /// <summary>
        /// Нажатие на кнопку "Добавить" на форме GlavStroiUpr для перехода на форму GlavStroiUprAddUchastok
        /// </summary>
        private void addRegion_Click(object sender, EventArgs e)
        {
            GlavStroiUprAddUchastok glavStroiUprAddUchastok = new GlavStroiUprAddUchastok(roles);
            glavStroiUprAddUchastok.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Добавть технику" на фоме GlavStroiUpr для перехода на форму GlavStroiUprAddTechnic. 
        /// Здесь происходит обноружение к какому участку мы будем добавтьть технику
        /// </summary>
        private void addConstructionEquipment_Click(object sender, EventArgs e)
        {
            string rowValue = informationRegion.Rows[informationRegion.CurrentRow.Index].Cells[1].Value.ToString();
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Uchastok] where [dbo].[Uchastok].[Name] = '{rowValue}'");
            if (dataTable.Rows.Count > 0)
            {
                int idRegion = Convert.ToInt32(dataTable.Rows[0][0]);
                GlavStroiUprAddTechnic stroiUprAddTechnic = new GlavStroiUprAddTechnic(roles,idRegion);
                stroiUprAddTechnic.Show();
                this.Hide();
            }
            
        }

        /// <summary>
        /// Нажатие на кнопку "Выход" на форме GlavStroiUpr для перехода на форму авторизации или админестратора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            if (roles == "Глава строительного управления")
            {
                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                Admin admin = new Admin();
                admin.Show();
            }
            this.Hide();
        }
    }
}
