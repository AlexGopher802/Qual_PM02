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
    public partial class BrigadirAddRabochih : Form
    {
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        string roles;
        int idForeman = 0;
        public BrigadirAddRabochih()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Инициализация компонентов, вывод рабочих под этим бригадиром
        /// </summary>
        /// <param name="roleReturn"> Переданная роль входящего</param>
        /// <param name="idForemanReturn"> Переданный номер бригадира</param>
        public BrigadirAddRabochih(string roleReturn,int idForemanReturn)
        {
            InitializeComponent();
            roles = roleReturn;
            idForeman = idForemanReturn;

            if (roles == "Администратор информационной системы")
            {
                sqlManager.AddComboBox(employee, "[dbo].[Chief_Brigades]", 0);
                lable.Text = "Выбор бригадира";
                add.Text = "Выбрать бригадира";
                if (employee.Items.Count > 0)
                {
                    employee.SelectedIndex = 0;
                }
            }
            else
            {
                sqlManager.AddComboBox(employee, "[dbo].[Employee_Raboch_Inform]", 0);
                sqlManager.GetList(listEmployee, "[dbo].[Sostav_Brigadi]", $@"select * from [dbo].[Output_Workers] ({idForeman})");
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Выход" на форме BrigadirAddRabochih для перехода на форму авторизации или админестратора
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            if (roles == "Администратор информационной системы.")
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                Login loginForm = new Login();
                loginForm.Show();
            }
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Список работ" на BrigadirAddRabochih переход на форму BrigadirInfoORabotah
        /// </summary>
        private void listWorks_Click(object sender, EventArgs e)
        {
            BrigadirInfoORabotah brigadirInfoORabotah = new BrigadirInfoORabotah(idForeman,roles);
            brigadirInfoORabotah.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку для добавления сотрудника в (БД) бригаду или выбора бригадира при заходе под админестратором. 
        /// Вывод рабочих из под выбранном бригадиром
        /// </summary>
        private void add_Click(object sender, EventArgs e)
        {
            if (employee.Text != "")
            {
                if (idForeman == 0)
                {
                    idForeman = Convert.ToInt32(sqlManager.ReturnTable($@"select * from [dbo].[Brigadir_Search] ('{employee.Text}')").Rows[0][0]);
                    lable.Text = "Выбор рабочего";
                    add.Text = "Добавить рабочего";
                    employee.Items.Clear();
                    sqlManager.AddComboBox(employee, "[dbo].[Employee_Raboch_Inform]", 0);
                    sqlManager.GetList(listEmployee, "[dbo].[Sostav_Brigadi]", $@"select * from [dbo].[Output_Workers] ({idForeman})");
                    if (employee.Items.Count > 0)
                    {
                        employee.SelectedIndex = 0;
                    }
                }
                else
                {
                    int idEmployee = Convert.ToInt32(sqlManager.ReturnTable($@"select * from [dbo].[Employee_Search] ('{employee.Text}')").Rows[0][0]);
                    sqlManager.RequestSql($@"insert into [dbo].[Sostav_Brigadi] values ({idForeman},{idEmployee})");
                    sqlManager.GetList(listEmployee, "[dbo].[Sostav_Brigadi]", $@"select * from [dbo].[Output_Workers] ({idForeman})");
                }
            }
            else
            {
                MessageBox.Show("Надо выбрать сотрудника из выпадающего списка.");
            }
        }
    }
}
