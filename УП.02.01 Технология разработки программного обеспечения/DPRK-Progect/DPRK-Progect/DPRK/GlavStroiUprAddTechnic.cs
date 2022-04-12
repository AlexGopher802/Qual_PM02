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
    public partial class GlavStroiUprAddTechnic : Form
    {
        int idTechnic;
        int idRegion;
        string roles;
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();

        public GlavStroiUprAddTechnic()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация компонентов, добавление наименовании техники в выпадающей список
        /// </summary>
        /// <param name="role">Роль вошедшего</param>
        /// <param name="idRegional">Номер участка</param>
        public GlavStroiUprAddTechnic(string role, int idRegional)
        {
            InitializeComponent();
            roles = role;
            idRegion = idRegional;
            sqlManager.AddComboBox(nameTechnic, "[dbo].[Stroitelnaya_Tekhnica]", 1);
        }

        /// <summary>
        /// Ограничения ввода в quantity (колличество)
        /// </summary>
        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToInt32(Keys.Back) )
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Отменить" на форме GlavStroiUprAddTechnic для перехода на форму GlavStroiUpr
        /// </summary>
        private void cancle_Click(object sender, EventArgs e)
        {
            GlavStroiUpr glavStroiUpr = new GlavStroiUpr(roles);
            glavStroiUpr.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Подтвердить" для заненсеня техники на участок в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirm_Click(object sender, EventArgs e)
        {
            if ( nameTechnic.Text == "")
            {
                MessageBox.Show("Надо выбрать наименование техники.");
            }
            else
            {
                if (quantity.Text == "" || Convert.ToInt32(quantity.Text) < 1)
                {
                    MessageBox.Show("Надо ввести колличество больше нуля.");
                }
                else
                {
                    sqlManager.RequestSql($@"insert into [dbo].[Tekhnica_Na_Uchastke] values ({Convert.ToInt32(quantity.Text)},{idRegion},{idTechnic})");
                    GlavStroiUpr glavStroiUpr = new GlavStroiUpr(roles);
                    glavStroiUpr.Show();
                    this.Hide();
                }
            }
        }

        /// <summary>
        /// Получение номера техники при выборе значения
        /// </summary>
        private void nameTechnic_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Stroitelnaya_Tekhnica] where [dbo].[Stroitelnaya_Tekhnica].[Name] = '{nameTechnic.Text}'");
            if (dataTable.Rows.Count > 0)
                idTechnic = Convert.ToInt32(dataTable.Rows[0][0]);
        }
    }
}
