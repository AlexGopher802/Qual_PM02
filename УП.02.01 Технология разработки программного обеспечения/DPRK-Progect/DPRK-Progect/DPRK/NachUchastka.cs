using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRK
{ 
    public partial class NachUchastka : Form
    {
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        string roles;
        int idEmployee;
        public NachUchastka()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов.
        /// Занесение в комбобокс первичных данных в зависемости от роли.
        /// </summary>
        /// <param name="role">Роль вошедшего</param>
        /// <param name="idEmplyeer">Номер сотрудника</param>
        public NachUchastka(string role, int idEmplyeer)
        {
            InitializeComponent();
            roles = role;
            idEmployee = idEmplyeer;

            if (role != "Администратор информационной системы")
            {
                sqlManager.AddComboBox(tipObject, $@"[dbo].[Information_Object_Uchastci_ComboBox] ({idEmployee}) ", 0);
                sqlManager.GetList(informationRegion, "[dbo].[Raboti_Na_Obiecte]", $@"select * from [dbo].[Information_Uchastoc_Worcing] ({idEmployee})");
            }
            else
            {
                label1.Text = "Выберете начальника участка";
                sqlManager.AddComboBox(tipObject, "[dbo].[Chief_Uchastca]", 0);
                add.Text = "Выбрать";
                generateReport.Enabled = false;
            }
            if (tipObject.Items.Count > 0)
            {
                tipObject.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Выйти" на форме NachUchastka для перехода на форму админестратора или авторизации
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            if (roles == "Начальник участка")
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
        /// Нажатие на кнопку "Сгенерировать отчет".
        /// Забираем данные котрые сошлись в результате выполнения запроса.
        /// Формируем массивы название, номера сдачи работы.Берется название участка, и формируется название из типа и сроке выполнения работы.
        /// </summary>
        private void generateReport_Click(object sender, EventArgs e)
        {
            if (tipObject.Text != "")
            {
                string tipObjecta = tipObject.Text;
                string [] tipObj = tipObjecta.Split(new char[] {','});
                string[] dateTime = tipObj[1].Split(new char[] { ' ' });

                string sqlRequst = $@"[dbo].[Information_Submission_Working_Date]  ({idEmployee},'{tipObjecta}')";
                DataTable dataTable = sqlManager.ReturnTable($@"select * from {sqlRequst}");

                int numberMatches = dataTable.Rows.Count;

                if (numberMatches > 0)
                {
                    int[] idSubmissionWorking = new int[numberMatches];
                    string[] title = new string[numberMatches];
                    string region = "";
                    for (int i = 0; i < numberMatches; i++)
                    {
                        idSubmissionWorking[i] = Convert.ToInt32(dataTable.Rows[i][0]);

                        string date = DateTime.Parse(dataTable.Rows[i][3].ToString(), CultureInfo.GetCultureInfo("ru-ru")).Date.ToShortDateString();

                        title[i] = $@"{dataTable.Rows[i][1]}-{dataTable.Rows[i][2]}- Срок выполнения: ( {date} )";
                        region = dataTable.Rows[0][4].ToString();
                    }

                    region = dataTable.Rows[0][4].ToString();

                    Class.WordManager.WordDocGeneration wordDoc = new Class.WordManager.WordDocGeneration();
                    string patch = wordDoc.addFile(tipObj[0]+" "+dateTime[0], idSubmissionWorking, title,region);

                    if (patch != "Закройте файл.")
                    {
                        System.Diagnostics.Process.Start(patch);
                    }
                    else
                    {
                        MessageBox.Show(patch);
                    }
                }
                else
                {
                    MessageBox.Show("С данным объектом еще не происходили действия бригадами.");
                }
            }
            else
            {
                MessageBox.Show("Выберите тип объекта.");
            }
        }

        /// <summary>
        /// Кнопка для перехода на форму NachUchastkaAddRabotiNaObj в котрый мы будеим задавать вид работы, бригаду и срок выполнения.
        /// А если мы зашли из под админестратор то сначала мы выбирем нажатием этой кнопки ачальника участка и далее все теже самые действия описааные выше.
        /// </summary>
        private void add_Click(object sender, EventArgs e)
        {
            if (idEmployee != 0)
            {
                if (tipObject.Text != "")
                {
                    DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Information_Object_Uchastci_Search] ({idEmployee},'{tipObject.Text}')");
                    if (dataTable.Rows.Count > 0)
                    {
                        int idObjectComboBox = Convert.ToInt32(dataTable.Rows[0][1]);
                        NachUchastkaAddRabotiNaObj nachUchastkaAddRabotiNaObj = new NachUchastkaAddRabotiNaObj(roles, idObjectComboBox, idEmployee);
                        nachUchastkaAddRabotiNaObj.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Выбирете тип объекта.");
                }
            }
            else
            {
                if (tipObject.Text != "")
                {
                    idEmployee = Convert.ToInt32(sqlManager.ReturnTable($@"select * from [dbo].[Sotrudnic_Search_Employee] ('{tipObject.Text}')").Rows[0][0]);
                    add.Text = "Добавить";
                    tipObject.Items.Clear();
                    sqlManager.AddComboBox(tipObject, $@"[dbo].[Information_Object_Uchastci_ComboBox] ({idEmployee}) ", 0);
                    sqlManager.GetList(informationRegion, "[dbo].[Raboti_Na_Obiecte]", $@"select * from [dbo].[Information_Uchastoc_Worcing] ({idEmployee})");
                    generateReport.Enabled = true;
                    label1.Text = "Тип объекта";
                }
                else
                {
                    MessageBox.Show("Выберете из под какого начальника участка будите заходить.");
                }
            }
        }
    }
}
