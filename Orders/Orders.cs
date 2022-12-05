using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work.Orders
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.caseum.ru; port=33333; username=st_4_20_10; password=88536946; database=is_4_20_st10_KURS;";
            conn = new MySqlConnection(connStr);
        }
        MySqlConnection conn;
       
        public void GetOrder()
        {
            DataTable list_table = new DataTable();
            MySqlCommand list_command = new MySqlCommand();
            conn.Open();
            list_table.Columns.Add(new DataColumn("Position", System.Type.GetType("System.String")));
            OrderCodeComboBox.DataSource = list_table;
            OrderCodeComboBox.DisplayMember = "Position";
            string sql_list_number = "SELECT DISTINCT OrderCode FROM Orders";
            list_command.CommandText = sql_list_number;
            list_command.Connection = conn;
            MySqlDataReader list_reader;
            try
            {
                list_reader = list_command.ExecuteReader();
                while (list_reader.Read())
                {
                    DataRow rowToAdd = list_table.NewRow();
                    rowToAdd["Position"] = list_reader[0].ToString();
                    list_table.Rows.Add(rowToAdd);
                }
                list_reader.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Не читаются заказы" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                conn.Close();
            }
        }
        public void GetCarCode()
        {
            DataTable list_table = new DataTable();
            MySqlCommand list_command = new MySqlCommand();
            conn.Open();
            list_table.Columns.Add(new DataColumn("Position", System.Type.GetType("System.String")));
            VehicleCodeComboBox.DataSource = list_table;
            VehicleCodeComboBox.DisplayMember = "Position";
            string sql_list_car = "SELECT DISTINCT Car_ID FROM Cars";
            list_command.CommandText = sql_list_car;
            list_command.Connection = conn;
            MySqlDataReader list_reader;
            try
            {
                list_reader = list_command.ExecuteReader();
                while (list_reader.Read())
                {
                    DataRow rowToAdd = list_table.NewRow();
                    rowToAdd["Position"] = list_reader[0].ToString();
                    list_table.Rows.Add(rowToAdd);
                }
                list_reader.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Не читаются автомобили" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                conn.Close();
            }
        }
        public void GetOwner()
        {
            DataTable list_table = new DataTable();
            MySqlCommand list_command = new MySqlCommand();
            conn.Open();
            list_table.Columns.Add(new DataColumn("Position", System.Type.GetType("System.String")));
            ClientCodeComboBox.DataSource = list_table;
            ClientCodeComboBox.DisplayMember = "Position";
            string sql_list_owner = "SELECT DISTINCT Clients_ID FROM Clients";
            list_command.CommandText = sql_list_owner;
            list_command.Connection = conn;
            MySqlDataReader list_reader;
            try
            {
                list_reader = list_command.ExecuteReader();
                while (list_reader.Read())
                {
                    DataRow rowToAdd = list_table.NewRow();
                    rowToAdd["Position"] = list_reader[0].ToString();
                    list_table.Rows.Add(rowToAdd);
                }
                list_reader.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Не читается оборудование" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string OrderCode = OrderCodeComboBox.Text;
            string VehicleCode = VehicleCodeComboBox.Text;
            string ClientCode = ClientCodeComboBox.Text;
            string ReceiptDate = ReceiptDateField.Text;
            string RepairCost = RepairCostField.Text;
            string Deadline = DeadlineField.Text;
            string InsurancePayment = InsurancePaymentField.Text;
            string sql_update_current_car = $"INSERT INTO Orders ( OrderCode, VehicleCode, ClientCode, ReceiptDate, RepairCost, Deadline, InsurancePayment )" +
                                            $"VALUES ('{OrderCode}', '{VehicleCode}', '{ClientCode}', '{ReceiptDate}', '{RepairCost}', '{Deadline}', '{InsurancePayment}')";
            // устанавливаем соединение с БД
            conn.Open();
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql_update_current_car, conn);
            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            conn.Close();
            //Закрываем форму
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
