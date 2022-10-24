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

namespace Course_work.Cars
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.caseum.ru; port=33333; username=st_4_20_10; password=88536946; database=is_4_20_st10_KURS;";
            conn = new MySqlConnection(connStr);
        }
        MySqlConnection conn;

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Mark = MachineBrandField.Text;
            string VIN = VINField.Text;
            string TechnicalCertificate = TechnicalCertificateField.Text;
            string CarColor = CarColorField.Text;
            string VehicleYear = VehicleYearField.Text;
            string EngineNumber = EngineNumberField.Text;
            string sql_update_current_car = $"INSERT INTO Cars ( Mark, VIN, TechnicalCertificate, CarColor, VehicleYear, EngineNumber )" +
                                            $"VALUES ('{Mark}', '{VIN}', '{TechnicalCertificate}', '{CarColor}', '{VehicleYear}', '{EngineNumber}')";
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
