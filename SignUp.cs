using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.caseum.ru; port=33333; username=st_4_20_10; password=88536946; database=is_4_20_st10_KURS;";
            conn = new MySqlConnection(connStr);
        }
        MySqlConnection conn;
        private void CreateButton_Click(object sender, EventArgs e)
        {
            string Login = LoginField.Text;
            string Password = sha256 (PasswordField.Text);
            string Email = EmailField.Text;
            string Phone = PhoneField.Text;
            string sql_update_current_account = $"INSERT INTO Users (Login, Password, Email, Phone) " +
                                            $"VALUES ('{Login}', '{Password}', '{Email}','{Phone}')";
            // устанавливаем соединение с БД
            conn.Open();
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql_update_current_account, conn);
            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            conn.Close();
            MessageBox.Show("Аккаунт зарегистрирован.\r\nТеперь вы можете авторизироваться!");
            //Закрываем форму
            this.Close();
            new Thread(() => Application.Run(new Auth())).Start();
        }
        private static string sha256(string randomString)
        {
            //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                _ = hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        private void AuthLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new Auth())).Start();
        }
    }
}
