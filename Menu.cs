using Course_work;
using Course_work.Cars;
using Course_work.Orders;
using Course_work.Personal;
using Course_work.Users;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;
        private string id_selected_rows = "0";
        //DataAdapter представляет собой объект Command , получающий данные из источника данных.
        private readonly MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //Объявление BindingSource, основная его задача, это обеспечить унифицированный доступ к источнику данных.
        private BindingSource bSource = new BindingSource();
        //Представляет одну таблицу данных в памяти.
        private DataTable table = new DataTable();
        private void Menu_Load(object sender, EventArgs e)
        {
            string connStr = "server=chuc.caseum.ru; port=33333; username=st_4_20_10; password=88536946; database=is_4_20_st10_KURS;";
            conn = new MySqlConnection(connStr);
        }
        public void GetList()
        {
            if (CarsButton.Checked) GetListCars();
            else if (AreaOfWorkButton.Checked) GetListAreaOfWork();
            else if (ClientsButton.Checked) GetListClients();
            else if (InsuranceButton.Checked) GetListInsurance();
            else if (MastersButton.Checked) GetListMasters();
            else if (OrdersButton.Checked) GetListOrders();
            else if (UsersButton.Checked) GetListUsers();
        }
        public void reload_list()
        {
            //Чистим виртуальную таблицу
            table = new DataTable();
            bSource = new BindingSource();
            //Вызываем метод получения записей, который вновь заполнит таблицу
            GetList();
        }
        public void GetListOf(string request)
        {
            string commandStr = request;
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(commandStr, conn);
            _ = MyDA.Fill(table);
            bSource.DataSource = table;
            DataGridView.DataSource = bSource;
            conn.Close();
        }

        //Метод получения ID выделенной строки, для последующего вызова его в нужных методах
        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = DataGridView.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = DataGridView.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
        }

        public void UpdateCell(string request)
        {
            // устанавливаем соединение с БД
            conn.Open();
            // запрос обновления данных
            string query = request;
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(query, conn);
            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            conn.Close();
        }
        public void Del(string request)
        {
            DialogResult result = MessageBox.Show
                ("Вы уверены?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                //Формируем строку запроса на добавление строк
                string sql_delete = request;
                //Посылаем запрос на обновление данных
                MySqlCommand delete = new MySqlCommand(sql_delete, conn);
                conn.Open();
                _ = delete.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void GetListCars() => GetListOf("SELECT ID-Cars AS 'Код автомобиля', MachineBrand AS 'Марка автомобиля', Tech_Certificate AS 'Технический паспорт', " +
                " VIN AS 'VIN',Color AS 'Цвет автомобиля', Year AS 'Год автомобиля', Engine_Number AS 'Номер двигателя' FROM Cars ");

        private void GetValueInBase() // Метод поиска
        {
            int filter = -1;
            if (ComboBox.Text == "По коду авто")
            {
                filter = 0;
            }
            else if (ComboBox.Text == "По марке авто")
            {
                filter = 1;
            }
            else if (ComboBox.Text == "По VIN-номеру")
            {
                filter = 2;
            }
            else if (ComboBox.Text == "По тех.паспорту")
            {
                filter = 4;
            }
            string QuanityValue;
            if (ClearField.Text != "" && filter != -1)
            {
                reload_list();
                for (int i = 0; i < DataGridView.RowCount - 1; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (DataGridView.RowCount > 1)
                    {
                        QuanityValue = DataGridView.Rows[i].Cells[filter].Value.ToString();
                        if (QuanityValue != ClearField.Text)
                        {
                            DataGridView.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
        public void GetListAreaOfWork() => GetListOf("SELECT ID-Work AS 'Код работы', TypeOfWork AS 'Вид работы', Deadline AS 'Срок выполнения', " +
                "CostOfWork AS 'Стоимость работы', ApprovalDate AS 'Дата заявления об услугах автосервиса' FROM AreaofWork");

        private void GetValueInBase1() // Метод поиска
        {
            int filter = -1;
            if (ComboBox.Text == "По коду работы")
            {
                filter = 0;
            }
            else if (ComboBox.Text == "По виду работы")
            {
                filter = 1;
            }
            else if (ComboBox.Text == "По сроку выполнения")
            {
                filter = 3;
            }
            string QuanityValue;
            if (ClearField.Text != "" && filter != -1)
            {
                reload_list();
                for (int i = 0; i < DataGridView.RowCount - 1; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (DataGridView.RowCount > 1)
                    {

                        QuanityValue = DataGridView.Rows[i].Cells[filter].Value.ToString();
                        if (QuanityValue != ClearField.Text)
                        {
                            DataGridView.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        public void GetListClients() => GetListOf("SELECT ID-Clients AS 'Код клиента', FIO AS 'ФИО', DateOfBirth AS 'Дата рождения', NumberPhone AS 'Телефон', " +
                "Passport AS 'Паспорт', Driver'sLicense AS 'Водительское удостоверение', InsurancePolicy AS 'Номер страхового полиса', InsurancePayment AS 'Страховая выплата', " +
                "Phone_Number AS 'Номер телефона' FROM Clients");

        private void GetValueInBase2() // Метод поиска
        {
            int filter = -1;
            if (ComboBox.Text == "По коду клиента")
            {
                filter = 0;
            }
            else if (ComboBox.Text == "По ФИО")
            {
                filter = 1;
            }
            else if (ComboBox.Text == "По Дате рождения")
            {
                filter = 2;
            }
            else if (ComboBox.Text == "По Номеру телефона")
            {
                filter = 3;
            }
            else if (ComboBox.Text == "По паспорту")
            {
                filter = 4;
            }
            else if (ComboBox.Text == "По вод. удостоверению")
            {
                filter = 5;
            }
            string QuanityValue;
            if (ClearField.Text != "" && filter != -1)
            {
                reload_list();
                for (int i = 0; i < DataGridView.RowCount - 1; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (DataGridView.RowCount > 1)
                    {

                        QuanityValue = DataGridView.Rows[i].Cells[filter].Value.ToString();
                        if (QuanityValue != ClearField.Text)
                        {
                            DataGridView.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        public void GetListInsurance() => GetListOf("SELECT ID-Insurance AS 'Код страховки', FIO AS 'ФИО', InsurancePolicy AS 'Номер страхового полиса', DateOfInsurance AS 'Дата страхования ', " +
                "InsuranceCompany AS 'Страховая компания', InsuranceType AS 'Вид страхования', TermOfInsurance AS 'Срок страхования', Home_Address AS 'Домашний адрес' FROM Insurance");

        private void GetValueInBase3() // Метод поиска
        {
            int filter = -1;
            if (ComboBox.Text == "По коду страховки")
            {
                filter = 0;
            }
            else if (ComboBox.Text == "По ФИО клиента")
            {
                filter = 1;
            }
            else if (ComboBox.Text == "По номеру страхового полиса")
            {
                filter = 2;
            }
            else if (ComboBox.Text == "По дате страхования")
            {
                filter = 3;
            }
            string QuanityValue;
            if (ClearField.Text != "" && filter != -1)
            {
                reload_list();
                for (int i = 0; i < DataGridView.RowCount - 1; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (DataGridView.RowCount > 1)
                    {

                        QuanityValue = DataGridView.Rows[i].Cells[filter].Value.ToString();
                        if (QuanityValue != ClearField.Text)
                        {
                            DataGridView.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
        public void GetListMasters() => GetListOf("SELECT ID-Employee AS 'Код сотрудника', FIO AS 'ФИО', DateOfBirth AS 'Дата рождения', " +
                "Specialization AS 'Специализация', Passport AS 'Паспорт', NumberPhone AS 'Номер телефона', Salary AS 'Зарплата', " +
                "DateOfEmployment AS 'Дата устройства' FROM Masters");

        private void GetValueInBase4() // Метод поиска
        {
            int filter = -1;
            if (ComboBox.Text == "По коду сотрудника")
            {
                filter = 0;
            }
            else if (ComboBox.Text == "По ФИО сотрудника")
            {
                filter = 1;
            }
            else if (ComboBox.Text == "По дате рождения")
            {
                filter = 2;
            }
            else if (ComboBox.Text == "По специализации")
            {
                filter = 3;
            }
            else if (ComboBox.Text == "По паспорту")
            {
                filter = 4;
            }
            string QuanityValue;
            if (ClearField.Text != "" && filter != -1)
            {
                reload_list();
                for (int i = 0; i < DataGridView.RowCount - 1; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (DataGridView.RowCount > 1)
                    {

                        QuanityValue = DataGridView.Rows[i].Cells[filter].Value.ToString();
                        if (QuanityValue != ClearField.Text)
                        {
                            DataGridView.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
        public void GetListUsers() => GetListOf("SELECT ID AS 'Номер сотрудника', Login AS 'Логин', Password AS 'Пароль', " +
                "Email AS 'Email', Phone AS 'Номер телефона' FROM Users");

        private void GetValueInBase5() // Метод поиска
        {
            int filter = -1;
            if (ComboBox.Text == "По номеру сотрудника")
            {
                filter = 0;
            }
            else if (ComboBox.Text == "По логину")
            {
                filter = 1;
            }
            else if (ComboBox.Text == "По Email")
            {
                filter = 3;
            }
            else if (ComboBox.Text == "По номеру телефона")
            {
                filter = 4;
            }
            else if (ComboBox.Text == "По уровню доступа")
            {
                filter = 5;
            }
            string QuanityValue;
            if (ClearField.Text != "" && filter != -1)
            {
                reload_list();
                for (int i = 0; i < DataGridView.RowCount - 1; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (DataGridView.RowCount > 1)
                    {

                        QuanityValue = DataGridView.Rows[i].Cells[filter].Value.ToString();
                        if (QuanityValue != ClearField.Text)
                        {
                            DataGridView.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
        public void GetListOrders()
        {
            string commandStr = "SELECT OrderCode AS 'Код заказа', VehicleCode AS 'Код автомобиля', ClientCode AS 'Код клиента', " +
                "ReceiptDate AS 'Дата поступления', RepairCost AS 'Стоимость ремонта', Deadline AS 'Срок выполнения', InsurancePayment AS 'Стоймость ремонта' FROM Orders";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(commandStr, conn);
            _ = MyDA.Fill(table);
            bSource.DataSource = table;
            DataGridView.DataSource = bSource;
            conn.Close();
        }
        private void GetValueInBase6() // Метод поиска
        {
            int filter = -1;
            if (ComboBox.Text == "По коду заказа")
            {
                filter = 0;
            }
            else if (ComboBox.Text == "По коду автомобиля")
            {
                filter = 1;
            }
            else if (ComboBox.Text == "По коду клиента")
            {
                filter = 2;
            }
            else if (ComboBox.Text == "По дате поступления")
            {
                filter = 3;
            }
            string QuanityValue;
            if (ClearField.Text != "" && filter != -1)
            {
                reload_list();
                for (int i = 0; i < DataGridView.RowCount - 1; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (DataGridView.RowCount > 1)
                    {

                        QuanityValue = DataGridView.Rows[i].Cells[filter].Value.ToString();
                        if (QuanityValue != ClearField.Text)
                        {
                            DataGridView.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form form;
            if (CarsButton.Checked) form = new Cars();
            else if (AreaOfWorkButton.Checked) form = new AreaOfWork();
            else if (ClientsButton.Checked) form = new Clients();
            else if (InsuranceButton.Checked) form = new Insurance();
            else if (MastersButton.Checked) form = new Masters();
            else if (OrdersButton.Checked) form = new Orders();
            else form = new Course_work.Users.Accounts();
            form.ShowDialog();
            reload_list();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string[] cells = new string[9];
            cells[0] = DataGridView.Rows[Convert.ToInt32(DataGridView.SelectedCells[0].RowIndex.ToString())].Cells[0].Value.ToString();
            for (int i = 1; i < DataGridView.ColumnCount; i++) cells[i] = DataGridView[i, DataGridView.CurrentRow.Index].Value.ToString();
            if (CarsButton.Checked) UpdateCell($"UPDATE Cars SET MachineBrand = '{cells[1]}', VIN = '{cells[2]}', TechnicalCertificate = '{cells[3]}', CarColor = '{cells[4]}', VehicleYear = '{cells[5]}', EngineNumber = '{cells[6]}',' WHERE ID-Cars = '{cells[0]}'");
            else if (MastersButton.Checked) UpdateCell($"UPDATE Masters SET FIO='{cells[1]}', DateOfBirth='{cells[2]}', NumberPhone='{cells[3]}', Specialization='{cells[4]}', Salary='{cells[5]}', ChangeOfJob='{cells[6]}', DateOfEmployment='{cells[7]}',' WHERE ID-Employee='{cells[0]}'");
            else if (OrdersButton.Checked) UpdateCell($"UPDATE Orders SET VehicleCode='{cells[1]}', ClientCode='{cells[2]}', ReceiptDate='{cells[3]}', RepairCost='{cells[4]}', Deadline='{cells[5]}', InsurancePayment='{cells[6]}' WHERE OrderCode='{cells[0]}'");
            else if (ClientsButton.Checked) UpdateCell($"UPDATE Clients SET FIO='{cells[1]}', DateOfBirth='{cells[2]}', NumberPhone='{cells[3]}', Passport='{cells[4]}', InsurancePolicy='{cells[5]}', InsurancePayment='{cells[6]}', Driver'sLicense='{cells[7]}', WHERE ID-Clients='{cells[0]}'");
            else if (AreaOfWorkButton.Checked) UpdateCell($"UPDATE AreaOfWork SET TypeOfWork='{cells[1]}', CostOfWork='{cells[2]}', Deadline='{cells[3]}', ApprovalDate='{cells[4]}' WHERE ID-Work='{cells[0]}'");
            else if (InsuranceButton.Checked) UpdateCell($"UPDATE Insurance SET FIO='{cells[1]}', InsurancePolicy='{cells[2]}', InsuranceCompany='{cells[3]}', InsuranceType='{cells[4]}, DateOfInsurance='{cells[5]}', TermOfInsurance='{cells[6]} WHERE ID-Insurance='{cells[0]}'");
            else if (UsersButton.Checked) UpdateCell($"UPDATE Users SET Login='{cells[1]}', Password ='{cells[2]}', Email='{cells[3]}', Phone='{cells[4]}', AccessLevel='{cells[5]}' WHERE (ID='{cells[0]}')");
            reload_list();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            GetSelectedIDString();
            if (CarsButton.Checked) Del("DELETE FROM Cars WHERE ID-Cars='" + id_selected_rows + "'");
            else if (MastersButton.Checked) Del("DELETE FROM Masters WHERE ID-Employee='" + id_selected_rows + "'");
            else if (OrdersButton.Checked) Del("DELETE FROM Orders WHERE OrderCode='" + id_selected_rows + "'");
            else if (ClientsButton.Checked) Del("DELETE FROM Clients WHERE ID-Clients='" + id_selected_rows + "'");
            else if (AreaOfWorkButton.Checked) Del("DELETE FROM AreaOfWork WHERE ID-Work='" + id_selected_rows + "'");
            else if (InsuranceButton.Checked) Del("DELETE FROM Insurance WHERE ID-Insurance='" + id_selected_rows + "'");
            else if (UsersButton.Checked) Del("DELETE FROM Users WHERE ID='" + id_selected_rows + "'");
            reload_list();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (CarsButton.Checked) GetValueInBase();
            else if (MastersButton.Checked) GetValueInBase1();
            else if (OrdersButton.Checked) GetValueInBase2();
            else if (ClientsButton.Checked) GetValueInBase3();
            else if (AreaOfWorkButton.Checked) GetValueInBase4();
            else if (InsuranceButton.Checked) GetValueInBase5();
            else if (UsersButton.Checked) GetValueInBase6();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new Auth())).Start();
        }

        private void ClearButton_Click(object sender, EventArgs e) => reload_list();
       
        private void Menu_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                DataGridView.CurrentCell = DataGridView[e.ColumnIndex, e.RowIndex];
                //dataGridView1.CurrentRow.Selected = true;
                DataGridView.CurrentCell.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString();
            }
        }
    }
}
