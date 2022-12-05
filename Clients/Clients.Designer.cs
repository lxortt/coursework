namespace Course_work
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.UserRegPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.FIOField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateOfBirthField = new Guna.UI2.WinForms.Guna2TextBox();
            this.PassportField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DriversLicenseField = new Guna.UI2.WinForms.Guna2TextBox();
            this.InsurancePolicyField = new Guna.UI2.WinForms.Guna2TextBox();
            this.InsurancePaymentField = new Guna.UI2.WinForms.Guna2TextBox();
            this.NumberPhoneField = new Guna.UI2.WinForms.Guna2TextBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserRegPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.NumberPhoneField);
            this.BodyPanel.Controls.Add(this.InsurancePaymentField);
            this.BodyPanel.Controls.Add(this.InsurancePolicyField);
            this.BodyPanel.Controls.Add(this.DriversLicenseField);
            this.BodyPanel.Controls.Add(this.PassportField);
            this.BodyPanel.Controls.Add(this.DateOfBirthField);
            this.BodyPanel.Controls.Add(this.FIOField);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.ClientsLabel);
            this.BodyPanel.Controls.Add(this.UserRegPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(834, 461);
            this.BodyPanel.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelButton.FillColor = System.Drawing.Color.Transparent;
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.ImageSize = new System.Drawing.Size(0, 0);
            this.CancelButton.Location = new System.Drawing.Point(600, 359);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 50);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.Transparent;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ImageSize = new System.Drawing.Size(0, 0);
            this.AddButton.Location = new System.Drawing.Point(474, 358);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClientsLabel
            // 
            this.ClientsLabel.AutoSize = true;
            this.ClientsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsLabel.ForeColor = System.Drawing.Color.White;
            this.ClientsLabel.Location = new System.Drawing.Point(106, 20);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(529, 19);
            this.ClientsLabel.TabIndex = 3;
            this.ClientsLabel.Text = "Для внесения данных в таблицу заполните следующие поля:";
            this.ClientsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserRegPicture
            // 
            this.UserRegPicture.BackColor = System.Drawing.Color.Transparent;
            this.UserRegPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserRegPicture.ErrorImage = null;
            this.UserRegPicture.Image = global::Course_work.Properties.Resources.UserReg;
            this.UserRegPicture.InitialImage = null;
            this.UserRegPicture.Location = new System.Drawing.Point(505, 55);
            this.UserRegPicture.Name = "UserRegPicture";
            this.UserRegPicture.Size = new System.Drawing.Size(256, 256);
            this.UserRegPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserRegPicture.TabIndex = 3;
            this.UserRegPicture.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.LeftPanel.BackgroundImage = global::Course_work.Properties.Resources.Panel_Background;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(95, 461);
            this.LeftPanel.TabIndex = 20;
            // 
            // FIOField
            // 
            this.FIOField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FIOField.DefaultText = "";
            this.FIOField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FIOField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FIOField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FIOField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FIOField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIOField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FIOField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIOField.Location = new System.Drawing.Point(455, 55);
            this.FIOField.Name = "FIOField";
            this.FIOField.PasswordChar = '\0';
            this.FIOField.PlaceholderText = "ФИО";
            this.FIOField.SelectedText = "";
            this.FIOField.Size = new System.Drawing.Size(187, 21);
            this.FIOField.TabIndex = 31;
            // 
            // DateOfBirthField
            // 
            this.DateOfBirthField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateOfBirthField.DefaultText = "";
            this.DateOfBirthField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DateOfBirthField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DateOfBirthField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateOfBirthField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateOfBirthField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateOfBirthField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateOfBirthField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateOfBirthField.Location = new System.Drawing.Point(464, 108);
            this.DateOfBirthField.Name = "DateOfBirthField";
            this.DateOfBirthField.PasswordChar = '\0';
            this.DateOfBirthField.PlaceholderText = "Дата рождения";
            this.DateOfBirthField.SelectedText = "";
            this.DateOfBirthField.Size = new System.Drawing.Size(187, 21);
            this.DateOfBirthField.TabIndex = 32;
            // 
            // PassportField
            // 
            this.PassportField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassportField.DefaultText = "";
            this.PassportField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassportField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassportField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassportField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassportField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassportField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PassportField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassportField.Location = new System.Drawing.Point(474, 210);
            this.PassportField.Name = "PassportField";
            this.PassportField.PasswordChar = '\0';
            this.PassportField.PlaceholderText = "Паспорт";
            this.PassportField.SelectedText = "";
            this.PassportField.Size = new System.Drawing.Size(187, 21);
            this.PassportField.TabIndex = 33;
            // 
            // DriversLicenseField
            // 
            this.DriversLicenseField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DriversLicenseField.DefaultText = "";
            this.DriversLicenseField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DriversLicenseField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DriversLicenseField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DriversLicenseField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DriversLicenseField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DriversLicenseField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DriversLicenseField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DriversLicenseField.Location = new System.Drawing.Point(474, 255);
            this.DriversLicenseField.Name = "DriversLicenseField";
            this.DriversLicenseField.PasswordChar = '\0';
            this.DriversLicenseField.PlaceholderText = "Вод. удостоверение";
            this.DriversLicenseField.SelectedText = "";
            this.DriversLicenseField.Size = new System.Drawing.Size(187, 21);
            this.DriversLicenseField.TabIndex = 34;
            // 
            // InsurancePolicyField
            // 
            this.InsurancePolicyField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InsurancePolicyField.DefaultText = "";
            this.InsurancePolicyField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InsurancePolicyField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InsurancePolicyField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsurancePolicyField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsurancePolicyField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsurancePolicyField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InsurancePolicyField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsurancePolicyField.Location = new System.Drawing.Point(483, 290);
            this.InsurancePolicyField.Name = "InsurancePolicyField";
            this.InsurancePolicyField.PasswordChar = '\0';
            this.InsurancePolicyField.PlaceholderText = "Номер полиса";
            this.InsurancePolicyField.SelectedText = "";
            this.InsurancePolicyField.Size = new System.Drawing.Size(187, 21);
            this.InsurancePolicyField.TabIndex = 35;
            // 
            // InsurancePaymentField
            // 
            this.InsurancePaymentField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InsurancePaymentField.DefaultText = "";
            this.InsurancePaymentField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InsurancePaymentField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InsurancePaymentField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsurancePaymentField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsurancePaymentField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsurancePaymentField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InsurancePaymentField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsurancePaymentField.Location = new System.Drawing.Point(483, 332);
            this.InsurancePaymentField.Name = "InsurancePaymentField";
            this.InsurancePaymentField.PasswordChar = '\0';
            this.InsurancePaymentField.PlaceholderText = "Страховая выплата";
            this.InsurancePaymentField.SelectedText = "";
            this.InsurancePaymentField.Size = new System.Drawing.Size(187, 21);
            this.InsurancePaymentField.TabIndex = 36;
            // 
            // NumberPhoneField
            // 
            this.NumberPhoneField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberPhoneField.DefaultText = "";
            this.NumberPhoneField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumberPhoneField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumberPhoneField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberPhoneField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberPhoneField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumberPhoneField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumberPhoneField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumberPhoneField.Location = new System.Drawing.Point(464, 159);
            this.NumberPhoneField.Name = "NumberPhoneField";
            this.NumberPhoneField.PasswordChar = '\0';
            this.NumberPhoneField.PlaceholderText = "Телефон";
            this.NumberPhoneField.SelectedText = "";
            this.NumberPhoneField.Size = new System.Drawing.Size(187, 21);
            this.NumberPhoneField.TabIndex = 37;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserRegPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox UserRegPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label ClientsLabel;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2TextBox NumberPhoneField;
        private Guna.UI2.WinForms.Guna2TextBox InsurancePaymentField;
        private Guna.UI2.WinForms.Guna2TextBox InsurancePolicyField;
        private Guna.UI2.WinForms.Guna2TextBox DriversLicenseField;
        private Guna.UI2.WinForms.Guna2TextBox PassportField;
        private Guna.UI2.WinForms.Guna2TextBox DateOfBirthField;
        private Guna.UI2.WinForms.Guna2TextBox FIOField;
    }
}