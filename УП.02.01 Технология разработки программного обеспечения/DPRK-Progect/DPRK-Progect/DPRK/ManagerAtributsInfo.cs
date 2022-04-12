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
    public partial class ManagerAtributsInfo : Form
    {
        int [] informObject;
        string role;
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        public ManagerAtributsInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов. Заполнение выпадающего списка атрибутов.
        /// Создание колонок для таблице с атрибутами и значением
        /// </summary>
        /// <param name="informationObject">Массив с данными из формы ManagerRegObj</param>
        /// <param name="roles">Роль вошедшего</param>
        public ManagerAtributsInfo(int [] informationObject,string roles)
        {
            InitializeComponent();
            informObject = informationObject;
            role = roles;
            sqlManager.AddComboBox(atributic, "[dbo].[Unicalnie_Atributi]", 1);
            if (atributic.Items.Count > 0)
            {
                atributic.SelectedIndex = 0;
            }
            atributeValue.Columns.Add("attributDG","Атрибут");
            atributeValue.Columns.Add("valueDG","Значение");
        }

        /// <summary>
        /// Нажатие на кнопку "Добавить" для создания объекта, договора с заказчиком (в БД) и занесение специальных атрибутов в БД
        /// </summary>
        private void confirm_Click(object sender, EventArgs e)
        {
            if (atributeValue.Rows.Count > 1)
            {
                if (value.Text.Length > 50)
                {
                    MessageBox.Show("Значение не более 50 символов.");
                }
                else
                {
                    sqlManager.RequestSql($@"insert into [dbo].[Stroitelniy_Object] values ({informObject[0]},{informObject[1]},'Выполняется')");
                    int numberRows = sqlManager.Number_Records("[dbo].[Stroitelniy_Object]");
                    int objectNumber = Convert.ToInt32(sqlManager.ReturnTable("select * from [dbo].[Stroitelniy_Object]").Rows[numberRows - 1][0]);
                    sqlManager.RequestSql($@"insert into [dbo].[Dogovor] values ('{DateTime.Now}',{objectNumber},{informObject[2]})");
                    for (int i = 0; i < atributeValue.Rows.Count - 1; i++)
                    {
                        DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Unicalnie_Atributi] where [dbo].[Unicalnie_Atributi].[Name] = '{atributeValue.Rows[i].Cells[0].Value}'");
                        int attributeNumber = Convert.ToInt32(dataTable.Rows[0][0]);
                        string valueDataGrid = atributeValue.Rows[i].Cells[1].Value.ToString();
                        sqlManager.RequestSql($@"insert into [dbo].[Perechen_Atributuv] values ({objectNumber},{attributeNumber},'{valueDataGrid}')");
                    }
                    ManagerRegObj managerRegObj = new ManagerRegObj(role);
                    managerRegObj.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Добавьте атрибутов для этого объекта.");
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Выйти" на форме ManagerAtributsInfo для перехода на форму ManagerRegObj
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            ManagerRegObj managerRegObj = new ManagerRegObj(role);
            managerRegObj.Show();
            this.Hide();
        }

        /// <summary>
        /// Добавления названия атрибута и его значения в визуальную таблицу на форме.
        /// </summary>
        private void add_Click(object sender, EventArgs e)
        {
            if (atributic.Text != "")
            {
                if (value.Text.Replace(" ", string.Empty).Length < 1)
                {
                    MessageBox.Show("Вы не ввели значение для атрибута.");
                }
                else
                {
                    if (value.Text.Length > 50)
                    {
                        MessageBox.Show("Значение должно быть не более 50 символов.");
                    }
                    else
                    {
                        int rowNumber = atributeValue.Rows.Add();
                        atributeValue.Rows[rowNumber].Cells[0].Value = atributic.Text;
                        atributeValue.Rows[rowNumber].Cells[1].Value = value.Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали атрибут.");
            }
        }

        /// <summary>
        /// Удаление строки из визуальной таблице на форме ManagerAtributsInfo
        /// </summary>
        private void delete_Click(object sender, EventArgs e)
        {
            int ind = atributeValue.SelectedCells[0].RowIndex;
            atributeValue.Rows.RemoveAt(ind);
        }
    }
}
