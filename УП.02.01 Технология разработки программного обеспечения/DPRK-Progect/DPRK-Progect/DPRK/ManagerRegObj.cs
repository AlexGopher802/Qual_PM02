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
    public partial class ManagerRegObj : Form
    {
        string roles;
        Class.SQL.SQLManager sqlManager = new Class.SQL.SQLManager();
        int idTipObject;
        int idRegionObject;
        int idCustomer;

        public ManagerRegObj()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация объектов. Заполнение выпадающих списков (тип объекта,участок объекта, заказчик)
        /// </summary>
        /// <param name="roleEnter">Роль вошедшего</param>
        public ManagerRegObj(string roleEnter)
        {
            InitializeComponent();
            roles = roleEnter;
            sqlManager.AddComboBox(tipObject, "[dbo].[Tip_Obyekta]", 1);
            sqlManager.AddComboBox(regionObject,"[dbo].[Uchastok]", 2);
            sqlManager.AddComboBox(customer,"[dbo].[Zakazchik]", 1);

            tipObject.SelectedIndex = 0;
            if (regionObject.Items.Count > 0)
                regionObject.SelectedIndex = 0;
            if (customer.Items.Count > 0)
                customer.SelectedIndex = 0;

        }

        /// <summary>
        /// Кнопка со знаком "+" около выпадающего списка с участками объекта для перехода на форму GlavStroiUprAddUchastok
        /// для регестрации нового участка
        /// </summary>
        private void addRegion_Click(object sender, EventArgs e)
        {
            GlavStroiUprAddUchastok glavStroiUprAddUchastok = new GlavStroiUprAddUchastok(roles);
            glavStroiUprAddUchastok.Show();
            this.Hide();
        }

        /// <summary>
        /// Кнопка со знаком "+" около выпадающего списка с заказчиками для перехода на форму ManagerRegZakaz
        /// для регестрации заказчика
        /// </summary>
        private void addCustomer_Click(object sender, EventArgs e)
        {
            ManagerRegZakaz managerRegZakaz = new ManagerRegZakaz(roles);
            managerRegZakaz.Show();
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку "Дальше" на форме ManagerRegObj для перехода на форму ManagerAtributsInfo и 
        /// передачей массива с данными из данной формы
        /// </summary>
        private void farther_Click(object sender, EventArgs e)
        {
            if (regionObject.Text != "" && customer.Text != "")
            {
                int[] informationObject = new int[] {idTipObject,idRegionObject,idCustomer};
                ManagerAtributsInfo managerAtributsInfo = new ManagerAtributsInfo(informationObject,roles);
                managerAtributsInfo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы не выбрали участок и(ли) заказчика.");
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Выход" на форме ManagerRegObj для перехода на окно авторизации или окно админестратора
        /// </summary>
        private void exit_Click(object sender, EventArgs e)
        {
            if (roles == "Менеджер по работе с клиентами")
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
        /// Получение номера выбранного типа объекта
        /// </summary>
        private void tipObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Tip_Obyekta] where [dbo].[Tip_Obyekta].[Name] = '{tipObject.Text}'");
            if (dataTable.Rows.Count > 0)
                idTipObject = Convert.ToInt32(dataTable.Rows[0][0]);
        }


        /// <summary>
        /// Получение номера выбранного участка объекта
        /// </summary>
        private void regionObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Uchastok] where [dbo].[Uchastok].[Name] = '{regionObject.Text}'");
            if (dataTable.Rows.Count > 0)
                idRegionObject = Convert.ToInt32(dataTable.Rows[0][0]);
        }


        /// <summary>
        /// Получение номера выбранного заказчика
        /// </summary>
        private void customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Zakazchik] where [dbo].[Zakazchik].[Name] = '{customer.Text}'");
            if (dataTable.Rows.Count > 0)
                idCustomer = Convert.ToInt32(dataTable.Rows[0][0]);
        }
    }
}
