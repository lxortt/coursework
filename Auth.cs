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
using MySql.Data.MySqlClient;

namespace coursework
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            conn = ConnToDB.ConnDB(connStr);
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                //if (e.KeyValue == (char)Keys.Enter) CreateLinkLabel_LinkClicked(buttonAuth, null);
            };
        }
        public static class ConnToDB
        {
            public static MySqlConnection ConnDB(string connStr)
            {
                var conn = new MySqlConnection(connStr);
                return conn;
            }
        }
        
        private void AuthPicture_Click(object sender, EventArgs e)
        {
            AuthPicture.BackgroundImageLayout = ImageLayout.Center;
        }
        private void CreateLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new SignUp())).Start();
        }

        readonly MySqlConnection conn;
        readonly string connStr = "server=chuc.caseum.ru; port=33333; username=st_4_20_10; password=88536946; database=is_4_20_st10_KURS;";

        private void AuthButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM Users WHERE Login = @un and Password = @up";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@un", LoginField.Text);
            command.Parameters.AddWithValue("@up", (PasswordField.Text));
            adapter.SelectCommand = command;
            adapter.Fill(table);
            conn.Close();
            if (table.Rows.Count > 0)
            {
                Auth1.auth = true;
                GetUserInfo(LoginField.Text);
                conn.Open();
                string sql1 = $"SELECT ID FROM Users WHERE Login='{LoginField.Text}'";
                MySqlCommand command1 = new MySqlCommand(sql1, conn);
                string ID = command1.ExecuteScalar().ToString();
                conn.Close();
                this.Close();
                new Thread(() => Application.Run(new Menu())).Start();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации.\r\nВход в программу не был произведён. Возможно, вы ввели неверное имя пользователя или пароль.");
                PasswordField.Clear();
            }
        }
         private static string sha256(string randomString)
            {
                //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
                var crypt = new System.Security.Cryptography.SHA256Managed();
                var hash = new System.Text.StringBuilder();
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
                foreach (byte theByte in crypto)
                {
                    hash.Append(theByte.ToString("x2"));
                }
                return hash.ToString();
            }
         public void GetUserInfo(string Login)
            {
                //Объявлем переменную для запроса в БД
                _ = LoginField.Text;
                // устанавливаем соединение с БД
                conn.Open();
                // запрос
                var sql = $"SELECT * FROM Users WHERE Login='{Login}'";
                // объект для выполнения SQL-запроса
                var command = new MySqlCommand(sql, conn);
                // объект для чтения ответа сервера
                var reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                Auth1.ID = reader[0].ToString();
                Auth1.Login = reader[1].ToString();
                }
                reader.Close(); // закрываем reader
                conn.Close();// закрываем соединение с БД

            }
         public static class Auth1
           {
                public static bool auth = false;
                public static string ID = null;
                public static string Login = null;
        }
    }
}
