namespace coursework
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.MastersButton = new System.Windows.Forms.Button();
            this.InsuranceButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.AreaOfWorkButton = new System.Windows.Forms.Button();
            this.CarsButton = new System.Windows.Forms.Button();
            this.AuthPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.LeftPanel.Controls.Add(this.UsersButton);
            this.LeftPanel.Controls.Add(this.OrdersButton);
            this.LeftPanel.Controls.Add(this.MastersButton);
            this.LeftPanel.Controls.Add(this.InsuranceButton);
            this.LeftPanel.Controls.Add(this.ClientsButton);
            this.LeftPanel.Controls.Add(this.AreaOfWorkButton);
            this.LeftPanel.Controls.Add(this.CarsButton);
            this.LeftPanel.Controls.Add(this.AuthPicture);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(104, 450);
            this.LeftPanel.TabIndex = 0;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Background;
            this.BodyPanel.Controls.Add(this.pictureBox1);
            this.BodyPanel.Controls.Add(this.SearchLabel);
            this.BodyPanel.Controls.Add(this.SearchComboBox);
            this.BodyPanel.Controls.Add(this.ResetButton);
            this.BodyPanel.Controls.Add(this.SearchButton);
            this.BodyPanel.Controls.Add(this.DelButton);
            this.BodyPanel.Controls.Add(this.EditButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.HeaderPanel);
            this.BodyPanel.Controls.Add(this.LogOutButton);
            this.BodyPanel.Controls.Add(this.button2);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(104, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(696, 450);
            this.BodyPanel.TabIndex = 0;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.ForeColor = System.Drawing.Color.White;
            this.SearchLabel.Location = new System.Drawing.Point(541, 77);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(47, 16);
            this.SearchLabel.TabIndex = 31;
            this.SearchLabel.Text = "Поиск";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(502, 103);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchComboBox.TabIndex = 30;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundImage = global::Course_work.Properties.Resources.Reset;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.ResetButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResetButton.Location = new System.Drawing.Point(629, 76);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(64, 48);
            this.ResetButton.TabIndex = 29;
            this.ResetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.BackgroundImage = global::Course_work.Properties.Resources.Search;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.SearchButton.Location = new System.Drawing.Point(216, 76);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(64, 48);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.Transparent;
            this.DelButton.BackgroundImage = global::Course_work.Properties.Resources.Delete;
            this.DelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.FlatAppearance.BorderSize = 0;
            this.DelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.DelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.DelButton.Location = new System.Drawing.Point(146, 76);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(64, 48);
            this.DelButton.TabIndex = 27;
            this.DelButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BackgroundImage = global::Course_work.Properties.Resources.Edit;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.EditButton.Location = new System.Drawing.Point(76, 76);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(64, 48);
            this.EditButton.TabIndex = 26;
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImage = global::Course_work.Properties.Resources.Add;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.AddButton.Location = new System.Drawing.Point(6, 76);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(64, 48);
            this.AddButton.TabIndex = 25;
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.HeaderPanel.Location = new System.Drawing.Point(0, 60);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(696, 10);
            this.HeaderPanel.TabIndex = 24;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.LogOutButton.Location = new System.Drawing.Point(596, 9);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(97, 23);
            this.LogOutButton.TabIndex = 23;
            this.LogOutButton.Text = "Выйти";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Course_work.Properties.Resources.Car;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(-95, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 61);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.Transparent;
            this.UsersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsersButton.BackgroundImage")));
            this.UsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.UsersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersButton.ForeColor = System.Drawing.Color.Crimson;
            this.UsersButton.Location = new System.Drawing.Point(0, 397);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(104, 53);
            this.UsersButton.TabIndex = 19;
            this.UsersButton.Text = "Аккаунты";
            this.UsersButton.UseVisualStyleBackColor = false;
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdersButton.BackgroundImage = global::Course_work.Properties.Resources.Orders;
            this.OrdersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.OrdersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersButton.ForeColor = System.Drawing.Color.HotPink;
            this.OrdersButton.Location = new System.Drawing.Point(0, 344);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(104, 50);
            this.OrdersButton.TabIndex = 18;
            this.OrdersButton.Text = "Заказы";
            this.OrdersButton.UseVisualStyleBackColor = false;
            // 
            // MastersButton
            // 
            this.MastersButton.BackColor = System.Drawing.Color.Transparent;
            this.MastersButton.BackgroundImage = global::Course_work.Properties.Resources.Personal;
            this.MastersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MastersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MastersButton.FlatAppearance.BorderSize = 0;
            this.MastersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.MastersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.MastersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MastersButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MastersButton.ForeColor = System.Drawing.Color.Violet;
            this.MastersButton.Location = new System.Drawing.Point(0, 284);
            this.MastersButton.Name = "MastersButton";
            this.MastersButton.Size = new System.Drawing.Size(104, 50);
            this.MastersButton.TabIndex = 17;
            this.MastersButton.Text = "Мастера";
            this.MastersButton.UseVisualStyleBackColor = false;
            // 
            // InsuranceButton
            // 
            this.InsuranceButton.BackColor = System.Drawing.Color.Transparent;
            this.InsuranceButton.BackgroundImage = global::Course_work.Properties.Resources.Insurance;
            this.InsuranceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InsuranceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsuranceButton.FlatAppearance.BorderSize = 0;
            this.InsuranceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.InsuranceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.InsuranceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsuranceButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsuranceButton.ForeColor = System.Drawing.Color.MediumOrchid;
            this.InsuranceButton.Location = new System.Drawing.Point(0, 228);
            this.InsuranceButton.Name = "InsuranceButton";
            this.InsuranceButton.Size = new System.Drawing.Size(104, 50);
            this.InsuranceButton.TabIndex = 16;
            this.InsuranceButton.Text = "Страхование";
            this.InsuranceButton.UseVisualStyleBackColor = false;
            // 
            // ClientsButton
            // 
            this.ClientsButton.BackColor = System.Drawing.Color.Transparent;
            this.ClientsButton.BackgroundImage = global::Course_work.Properties.Resources.UserReg;
            this.ClientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.ClientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.ClientsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientsButton.Location = new System.Drawing.Point(0, 172);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(104, 50);
            this.ClientsButton.TabIndex = 15;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.UseVisualStyleBackColor = false;
            // 
            // AreaOfWorkButton
            // 
            this.AreaOfWorkButton.BackColor = System.Drawing.Color.Transparent;
            this.AreaOfWorkButton.BackgroundImage = global::Course_work.Properties.Resources.Work;
            this.AreaOfWorkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AreaOfWorkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AreaOfWorkButton.FlatAppearance.BorderSize = 0;
            this.AreaOfWorkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.AreaOfWorkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AreaOfWorkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaOfWorkButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AreaOfWorkButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.AreaOfWorkButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AreaOfWorkButton.Location = new System.Drawing.Point(0, 116);
            this.AreaOfWorkButton.Name = "AreaOfWorkButton";
            this.AreaOfWorkButton.Size = new System.Drawing.Size(104, 50);
            this.AreaOfWorkButton.TabIndex = 14;
            this.AreaOfWorkButton.Text = "Виды работы";
            this.AreaOfWorkButton.UseVisualStyleBackColor = false;
            // 
            // CarsButton
            // 
            this.CarsButton.BackColor = System.Drawing.Color.Transparent;
            this.CarsButton.BackgroundImage = global::Course_work.Properties.Resources.Car;
            this.CarsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CarsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarsButton.FlatAppearance.BorderSize = 0;
            this.CarsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.CarsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.CarsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.CarsButton.Location = new System.Drawing.Point(0, 60);
            this.CarsButton.Name = "CarsButton";
            this.CarsButton.Size = new System.Drawing.Size(104, 50);
            this.CarsButton.TabIndex = 13;
            this.CarsButton.Text = "Автомобили";
            this.CarsButton.UseVisualStyleBackColor = false;
            // 
            // AuthPicture
            // 
            this.AuthPicture.BackColor = System.Drawing.Color.Transparent;
            this.AuthPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AuthPicture.ErrorImage = null;
            this.AuthPicture.Image = global::Course_work.Properties.Resources.IconService;
            this.AuthPicture.InitialImage = null;
            this.AuthPicture.Location = new System.Drawing.Point(23, 9);
            this.AuthPicture.Name = "AuthPicture";
            this.AuthPicture.Size = new System.Drawing.Size(64, 64);
            this.AuthPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthPicture.TabIndex = 7;
            this.AuthPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Course_work.Properties.Resources.Saturn;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(286, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.LeftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.LeftPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox AuthPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button MastersButton;
        private System.Windows.Forms.Button InsuranceButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button AreaOfWorkButton;
        private System.Windows.Forms.Button CarsButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

