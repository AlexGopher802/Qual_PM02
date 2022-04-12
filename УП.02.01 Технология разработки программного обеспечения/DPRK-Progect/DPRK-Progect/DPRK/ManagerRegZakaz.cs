using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRK
{
    public partial class ManagerRegZakaz : Form
    {
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        string roleEnter;

        public ManagerRegZakaz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компоненотов
        /// </summary>
        /// <param name="roles">Переданная роль под котрой зашел сотрудник</param>
        public ManagerRegZakaz(string roles)
        {
            InitializeComponent();
            roleEnter = roles;
        }

        /// <summary>
        /// Нажатие на кнопку "Выход" на форме ManagerRegZakaz для перехода на форму менеджера по работе с клиентами или
        /// Главы строительного управления
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            switch (roleEnter)
            {
                case "Менеджер по работе с клиентами":
                    ManagerRegObj managerRegObj = new ManagerRegObj(roleEnter);
                    managerRegObj.Show();
                    break;

                case "Глава строительного управления":
                    GlavStroiUpr glavStroiUpr = new GlavStroiUpr(roleEnter);
                    glavStroiUpr.Show();
                    break;

                default:
                    ManagerRegObj managerRegObjct = new ManagerRegObj(roleEnter);
                    managerRegObjct.Show();
                    break;
            }
            this.Hide();


        }

        /// <summary>
        /// Нажатие на кнопку "Дальше" на форме ManagerRegZakaz для создания заказчика и переходом на форму ManagerRegObj
        /// </summary>
        private void farther_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 50 || name.Text.Length < 1 || name.Text.Replace(" ", string.Empty).Length < 1)
            {
                MessageBox.Show("Наименование не может быть пустым и больше 50 знаков.");
            }
            else
            {
                if (phoneNumber.Text.Length != 11 || StringInfo.GetNextTextElement(phoneNumber.Text, 0) != "7")
                {
                    MessageBox.Show("Ведите номер телефона он состоит из 11 чисел и первое число 7.");
                }
                else
                {
                    if (inn.Text.Length != 10 && inn.Text.Length != 12)
                    {
                        MessageBox.Show("В ИНН 10 или 12 цифр.");
                    }
                    else
                    {
                        if (sqlManager.Number_Records($@"[dbo].[Zakazchik] where [dbo].[Zakazchik].[INN_Number] = '{inn.Text}' ") == 0)
                        {
                            if (sqlManager.Number_Records($@"[dbo].[Zakazchik] where [dbo].[Zakazchik].[Name] = '{name.Text}'") == 0)
                            {
                                sqlManager.RequestSql($@"insert into [dbo].[Zakazchik] values ('{name.Text}','{inn.Text}','8 {phoneNumber.Text}')");
                                ManagerRegObj managerRegObj = new ManagerRegObj(roleEnter);
                                managerRegObj.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Такое название заказчика уже существует.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Такой ИНН уже существует.");
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Ограничения ввода ИННН
        /// </summary>
        private void inn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToInt32(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToInt32(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
