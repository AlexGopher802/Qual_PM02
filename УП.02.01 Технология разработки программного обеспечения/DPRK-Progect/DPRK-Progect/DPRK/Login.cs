using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRK
{
    public partial class Login : Form
    {

        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        public Login()
        {
            InitializeComponent();
           
        }

        /// <summary>
        /// Нажатие на кнопку "Выход" для полного выхода из программы
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Нажатие на кнопку "Войти" для авторизации пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enter_Click(object sender, EventArgs e)
        {
            if (loginTx.Text == "" || password.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены.");
            }
            else
            {
                if (loginTx.Text.Length < 6 || password.Text.Length < 6)
                {
                    MessageBox.Show("Логин и пароль должны быть не менее 6 символов.");
                }
                else
                {
                    DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Autarization]('{loginTx.Text}','{password.Text}')");
                    if (dataTable.Rows.Count > 0)
                    {
                        string role = dataTable.Rows[0][2].ToString();
                        switch (role)
                        {
                            case "Администратор информационной системы":
                                Admin admin = new Admin();
                                admin.Show();
                                this.Hide();
                                break;

                            case "Глава строительного управления":
                                GlavStroiUpr glavStroiUpr = new GlavStroiUpr(role);
                                glavStroiUpr.Show();
                                this.Hide();
                                break;

                            case "Начальник участка":
                                int idEmployer = Convert.ToInt32(dataTable.Rows[0][3]);
                                NachUchastka nachUchastka = new NachUchastka(role,idEmployer);
                                nachUchastka.Show();
                                this.Hide();
                                break;

                            case "Бригадир":
                                int idEmployee = Convert.ToInt32(dataTable.Rows[0][3]);
                                int idForeman = Convert.ToInt32(sqlManager.ReturnTable($@"select * from [dbo].[Brigadir] where [dbo].[Brigadir].[ID_Sotrudnica] = {idEmployee}").Rows[0][0]);
                                BrigadirAddRabochih brigadirAddRabochih = new BrigadirAddRabochih(role,idForeman);
                                brigadirAddRabochih.Show();
                                this.Hide();
                                break;

                            case "Менеджер по работе с клиентами":
                                ManagerRegObj managerRegObj = new ManagerRegObj(role);
                                managerRegObj.Show();
                                this.Hide();
                                break;

                            case "HR менеджер":
                                HRmanager HRmanager = new HRmanager(role);
                                HRmanager.Show();
                                this.Hide();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Авторизация не пройдена.");
                    }
                }
            }
        }
    }
}
