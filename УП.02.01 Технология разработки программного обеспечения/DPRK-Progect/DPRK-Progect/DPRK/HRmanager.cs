using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRK
{
    public partial class HRmanager : Form
    {
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        int idRole;
        int idPost;
        string rolEnterEmployee;
        public HRmanager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов, занесение в выпадающие списки должномть, роль
        /// </summary>
        /// <param name="roleEnter">Роль вошедшего</param>
        public HRmanager(string roleEnter)
        {
            InitializeComponent();
            sqlManager.AddComboBox(post,"[dbo].[Dolznost]", 1);
            sqlManager.AddComboBox(role,"[dbo].[Role]", 1);

            post.SelectedIndex = 0;
            role.SelectedIndex = 0;
            rolEnterEmployee = roleEnter;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (rolEnterEmployee == "HR менеджер")
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

        /// <summary>
        /// Нажатие на кнопку "Добавить" для создания сотрудника в БД, и занесения сотруника в бригадиры если он имеет такую роль
        /// </summary>
        private void add_Click(object sender, EventArgs e)
        {
            string nameStr = name.Text;
            string surnameStr = surName.Text;
            string patronymicStr = patronymic.Text;

            if (patronymicStr != "")
            {
                patronymicStr = patronymic.Text.Substring(0, 1).ToUpper() + patronymic.Text.Substring(1).ToLower();
            }

            if (nameStr != "")
            {
                nameStr = name.Text.Substring(0, 1).ToUpper() + name.Text.Substring(1).ToLower();
            }

            if (surnameStr != "")
            {
                surnameStr = surName.Text.Substring(0, 1).ToUpper() + surName.Text.Substring(1).ToLower();
            }

            string loginStr = login.Text;
            string passwordStr = password.Text;
            string phone;
            if (phoneNumber.Text.Length == 15)
            {
                phone = $@"8 {phoneNumber.Text}";
            }
            else
            {
                phone = "";
            }

            if (nameStr == "" || surnameStr == "" || loginStr == "" || passwordStr == "")
            {
                MessageBox.Show("Поля: Фамилия, Имя, Логин, Пароль обязательны для заполнения.");
            }
            else
            {
                if (loginStr.Length < 6 || passwordStr.Length < 6)
                {
                    MessageBox.Show("Логин и пароль должны содержать не менее 6 символов.");
                }
                else
                {
                    if (loginStr.Length <= 25 || passwordStr.Length <= 25)
                    {
                        if ((nameStr.Length > 25 || surnameStr.Length > 25) && patronymicStr == "")
                        {
                            MessageBox.Show("Фамилия и имя не более 25 символов.");
                        }
                        else
                        {

                            if (nameStr.Length > 25 || surnameStr.Length > 25 || patronymicStr.Length > 25)
                            {
                                MessageBox.Show("Фамилия, имя и отчество не более 25 символов.");
                            }
                            else
                            {
                                if ((!CorrectFullName(nameStr) || !CorrectFullName(surnameStr)) && patronymicStr == "")
                                {
                                    MessageBox.Show("Фамилия, имя должны содержать только буквы.");
                                }
                                else
                                {
                                    if (!CorrectFullName(nameStr) || !CorrectFullName(surnameStr) || !CorrectFullName(patronymicStr))
                                    {
                                        MessageBox.Show("Фамилия, имя, отчество должны содержать только буквы.");
                                    }
                                    else
                                    {

                                        if (sqlManager.Number_Records($@"[dbo].[Sotrudnic] where [dbo].[Sotrudnic].[Login] = '{loginStr}'") == 0)
                                        {
                                            sqlManager.RequestSql($@"insert into [dbo].[Sotrudnic] values ('{surnameStr}',{idPost},'{nameStr}','{patronymicStr}','{phone}','{loginStr}','{passwordStr}',{idRole})");
                                            if (post.Text == "Бригадир")
                                            {
                                                int idSotrudnic = Convert.ToInt32(sqlManager.ReturnTable($@"select max ([dbo].[Sotrudnic].[ID_Sotrudnica]) from [dbo].[Sotrudnic]").Rows[0][0]);
                                                sqlManager.RequestSql($@"insert into [dbo].[Brigadir] values ({idSotrudnic})");
                                            }
                                            Delet_Value_Fields();
                                            MessageBox.Show("Сотрудник зарегистрирован");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Сотрудник с таким логином уже зарегестрирован придумайте другой логин.");
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Логин и пароль не более 25 символов.");
                    }
                }
            }
        }

        /// <summary>
        /// Удаление значений из полей после успешной регестрации
        /// </summary>
        void Delet_Value_Fields()
        {
            surName.Text = "";
            name.Text = "";
            patronymic.Text = "";
            login.Text = "";
            password.Text = "";
            phoneNumber.Text = "";
        }

        /// <summary>
        /// Проверка строки на числа, спец символы
        /// </summary>
        /// <param name="value">Строка для проверки</param>
        /// <returns>Логическое выражение говорящее есть ли в строку спец символы и(или) числа</returns>
        bool CorrectFullName(string value)
        {
            for (int i = 0; i <= value.Length-1; i++)
            {
                if (Char.IsDigit(value[i]))
                {
                    return false;
                }

                if (Char.IsSymbol(value[i]))
                {
                    return false;
                }
            }

            if (Regex.Match(value, "[\\!\\@\\#\\№\\%\\$\\^\\:\\?\\&\\*\\(\\)\\{\\}\\[\\]\\/\\.\\,\\-\\ _\\=\\+\\;\\`\\~\\<\\>]").Success)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Получение номера должности
        /// </summary>
        private void post_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Dolznost] where [dbo].[Dolznost].[Name] = '{post.Text}'");
            if (dataTable.Rows.Count > 0)
                idPost = Convert.ToInt32(dataTable.Rows[0][0]);
        }

        /// <summary>
        /// Получение номера роли
        /// </summary>
        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Role] where [dbo].[Role].[Name] = '{role.Text}'");
            if (dataTable.Rows.Count > 0)
                idRole = Convert.ToInt32(dataTable.Rows[0][0]);
        }

        /// <summary>
        /// Ограничения ввода Фамилии
        /// </summary>
        private void surName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToInt32(Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Ограничения ввода Имя
        /// </summary>
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToInt32(Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Ограничения ввода Отчество
        /// </summary>
        private void patronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToInt32(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
