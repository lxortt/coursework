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

namespace Course_work.Users
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.caseum.ru; port=33333; username=st_4_20_10; password=88536946; database=is_4_20_st10_KURS;";
            conn = new MySqlConnection(connStr);
        }
        MySqlConnection conn;
        private void AddButton_Click(object sender, EventArgs e)
        {
            string Login = LoginField.Text;
            string Password = PasswordField.Text;
            string Email = EmailField.Text;
            string Phone = PhoneField.Text;
            string AccessLevel = AccessLevelField.Text;
            string sql_update_current_car = $"INSERT INTO Users ( Password, Email, Phone, AccessLevel, )" +
                                            $"VALUES ('{Login}', '{Password}', '{Email}', '{Phone}', '{AccessLevel}')";
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
