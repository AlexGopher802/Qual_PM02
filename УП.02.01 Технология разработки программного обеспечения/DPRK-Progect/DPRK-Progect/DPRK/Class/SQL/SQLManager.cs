using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRK.Class.SQL
{
    class SQLManager
    {
        public SqlConnection conection = new SqlConnection(@"Data Source=localhost;Initial Catalog=DP_Repair_Kit;Integrated Security=True");
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataSet dataSet;

        /// <summary>
        /// Возращает колличество строк в таблице
        /// </summary>
        /// <param name="tables">Таблица</param>
        /// <returns>Количество строк</returns>
        public int Number_Records(string tables) => Convert.ToInt32(ReturnTable($@"select count(*) as count from {tables} ").Rows[0][0]);

        /// <summary>
        /// Получение таблице по запросу
        /// </summary>
        /// <param name="sqlRequest">Запрос серверу</param>
        /// <returns>Таблица выданная после выполнения запоса</returns>
        public DataTable ReturnTable(string sqlRequest)
        {
            try
            {
                dataAdapter = new SqlDataAdapter($@"{sqlRequest}", conection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch { 
                return new DataTable(); 
            }
        }
        /// <summary>
        /// Выполняет запрос по впереданному запросу
        /// </summary>
        /// <param name="sqlRequest">Передаваемый запрос</param>
        /// <returns>Если чтото не так то передается текст ошибки если все хорошо возращается пустая строка</returns>
        public string RequestSql(string sqlRequest)
        {
            try
            {
                command = new SqlCommand();
                conection.Open();
                command.Connection = conection;
                command.CommandText = String.Format(sqlRequest);
                command.ExecuteNonQuery();
                conection.Close();
                return "";
            }
            catch (Exception e)
            {
                conection.Close();
                return e.Message.ToString();
            }
        }

        /// <summary>
        /// Добавление значений в ComboBox
        /// </summary>
        /// <param name="comboBox">В какой выпадающий список занаосить</param>
        /// <param name="table">Таблица</param>
        /// <param name="columnNumber">Колонка котрую надо заносить в выпаающий список</param>
        public void AddComboBox(ComboBox comboBox, string table, int columnNumber)
        {
            DataTable dataTable = ReturnTable($@"select count(*) as count from {table}");
            if (dataTable.Rows.Count > 0)
            {
                int numberOfRecords = Number_Records(table);
                dataAdapter = new SqlDataAdapter($@"select * from {table}", conection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < numberOfRecords; i++)
                {
                    comboBox.Items.Add(dataTable.Rows[i][columnNumber]);
                }
            }
        }

        /// <summary>
        /// Вывод полученных данных после запроса в DataGridView
        /// </summary>
        /// <param name="dataGridView">В какой DataGridView заносить</param>
        /// <param name="table">Таблица</param>
        /// <param name="performance">Текст запроса</param>
        public void GetList(DataGridView dataGridView, string table, string performance)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(performance, conection);
                dataSet = new DataSet();
                conection.Open();
                dataAdapter.Fill(dataSet, table);
                dataGridView.DataSource = dataSet.Tables[table];
                conection.Close();
            }
            catch {
                conection.Close();
            }
        }

        /// <summary>
        /// Обновление значений
        /// </summary>
        /// <param name="table">Таблица в котрой нужно изменять данные</param>
        /// <param name="field">Какое поле изменить</param>
        /// <param name="value">Новое значение для поля</param>
        /// <param name="nameID">Название уникального индификатора</param>
        /// <param name="valueID">Значение индификатора у котрого производиться обновление данных</param>
        public void Update_Value(string table, string field, string value, string nameID, int valueID)
        {
            command = new SqlCommand();
            conection.Open();
            command.Connection = conection;
            try
            {
                command.CommandText = String.Format($@"update {table} set {field}='{value}' where {nameID}='{valueID}'");
                command.ExecuteNonQuery();
                conection.Close();
            }
            catch
            {
                conection.Close();
            }
        }
    }
}
