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
    public partial class GlavStroiUprAddUchastok : Form
    {
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        string role;
        int idChief;
        public GlavStroiUprAddUchastok()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов и добавления в выпадающий список всех начадбников участка
        /// </summary>
        /// <param name="roles">Роль вошедшего</param>
        public GlavStroiUprAddUchastok(string roles)
        {
            InitializeComponent();
            role = roles;
            sqlManager.AddComboBox(chief, "[dbo].[Full_Name_Chief]", 1);
            if (chief.Items.Count > 0)
            {
                chief.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Подтвердить" для создания участка в БД
        /// </summary>
        private void confirm_Click(object sender, EventArgs e)
        {
            if (region.Text.Replace(" ", string.Empty).Length < 1 || region.Text == "")
            {
                MessageBox.Show("Вы не ввели название участка.");
            }
            else
            {
                if (chief.Text != "")
                {
                    if (region.Text.Length > 100)
                    {
                        MessageBox.Show("Название участка не более 100 символов.");
                    }
                    else
                    {
                        if (sqlManager.RequestSql($@"insert into [dbo].[Uchastok] values ({idChief},'{region.Text}')") == "")
                        {
                            exit_Employye();
                        }
                        else
                        {
                            MessageBox.Show("Участок с таким наименованием уже существует.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете начальника.");
                }
            }
        }

        /// <summary>
        /// Получение номера начальника участка
        /// </summary>
        private void chief_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Full_Name_Chief] where [dbo].[Full_Name_Chief].[ФИО] = '{chief.Text}'");
            if (dataTable.Rows.Count > 0)
                idChief = Convert.ToInt32(dataTable.Rows[0][0]);
        }

        /// <summary>
        /// Нажатие на кнопку "Отменить" на форме GlavStroiUprAddUchastok для перехода на менеджера 
        /// или главы строительного управления
        /// </summary>
        private void cancel_Click(object sender, EventArgs e)
        {
            exit_Employye();
        }

        /// <summary>
        /// Метод для перехода по формам в зависемости от роли
        /// </summary>
        void exit_Employye()
        {
            switch (role)
            {
                case "Менеджер по работе с клиентами":
                    ManagerRegObj managerRegObj = new ManagerRegObj(role);
                    managerRegObj.Show();
                    break;

                case "Глава строительного управления":
                    GlavStroiUpr glavStroiUpr = new GlavStroiUpr(role);
                    glavStroiUpr.Show();
                    break;

                case "Администратор Менеджер информационной системы":
                    ManagerRegObj managerRegObj2 = new ManagerRegObj(role);
                    managerRegObj2.Show();
                    break;

                default:
                    GlavStroiUpr glavStroiUpr2 = new GlavStroiUpr(role);
                    glavStroiUpr2.Show();
                    this.Hide();
                    break;
            }
            this.Hide();
        }
    }
}
