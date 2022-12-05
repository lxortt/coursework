namespace Course_work.Personal
{
    partial class Masters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masters));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.PersonalLabel = new System.Windows.Forms.Label();
            this.PersonalPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.FIOField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateOfBirthField = new Guna.UI2.WinForms.Guna2TextBox();
            this.NumberPhoneField = new Guna.UI2.WinForms.Guna2TextBox();
            this.SpecializationField = new Guna.UI2.WinForms.Guna2TextBox();
            this.PassportField = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalaryField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateOfEmploymentField = new Guna.UI2.WinForms.Guna2TextBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.DateOfEmploymentField);
            this.BodyPanel.Controls.Add(this.SalaryField);
            this.BodyPanel.Controls.Add(this.PassportField);
            this.BodyPanel.Controls.Add(this.SpecializationField);
            this.BodyPanel.Controls.Add(this.NumberPhoneField);
            this.BodyPanel.Controls.Add(this.DateOfBirthField);
            this.BodyPanel.Controls.Add(this.FIOField);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.PersonalLabel);
            this.BodyPanel.Controls.Add(this.PersonalPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(834, 461);
            this.BodyPanel.TabIndex = 6;
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
            this.CancelButton.Location = new System.Drawing.Point(580, 364);
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
            this.AddButton.Location = new System.Drawing.Point(454, 364);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PersonalLabel
            // 
            this.PersonalLabel.AutoSize = true;
            this.PersonalLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonalLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalLabel.ForeColor = System.Drawing.Color.White;
            this.PersonalLabel.Location = new System.Drawing.Point(105, 22);
            this.PersonalLabel.Name = "PersonalLabel";
            this.PersonalLabel.Size = new System.Drawing.Size(529, 19);
            this.PersonalLabel.TabIndex = 23;
            this.PersonalLabel.Text = "Для внесения данных в таблицу заполните следующие поля:";
            this.PersonalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PersonalPicture
            // 
            this.PersonalPicture.BackColor = System.Drawing.Color.Transparent;
            this.PersonalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PersonalPicture.ErrorImage = null;
            this.PersonalPicture.Image = global::Course_work.Properties.Resources.Personal;
            this.PersonalPicture.InitialImage = null;
            this.PersonalPicture.Location = new System.Drawing.Point(505, 55);
            this.PersonalPicture.Name = "PersonalPicture";
            this.PersonalPicture.Size = new System.Drawing.Size(256, 256);
            this.PersonalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonalPicture.TabIndex = 3;
            this.PersonalPicture.TabStop = false;
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
            this.FIOField.Location = new System.Drawing.Point(463, 55);
            this.FIOField.Name = "FIOField";
            this.FIOField.PasswordChar = '\0';
            this.FIOField.PlaceholderText = "ФИО";
            this.FIOField.SelectedText = "";
            this.FIOField.Size = new System.Drawing.Size(190, 21);
            this.FIOField.TabIndex = 33;
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
            this.DateOfBirthField.Location = new System.Drawing.Point(463, 108);
            this.DateOfBirthField.Name = "DateOfBirthField";
            this.DateOfBirthField.PasswordChar = '\0';
            this.DateOfBirthField.PlaceholderText = "Дата рождения";
            this.DateOfBirthField.SelectedText = "";
            this.DateOfBirthField.Size = new System.Drawing.Size(190, 21);
            this.DateOfBirthField.TabIndex = 34;
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
            this.NumberPhoneField.Location = new System.Drawing.Point(482, 159);
            this.NumberPhoneField.Name = "NumberPhoneField";
            this.NumberPhoneField.PasswordChar = '\0';
            this.NumberPhoneField.PlaceholderText = "Телефон";
            this.NumberPhoneField.SelectedText = "";
            this.NumberPhoneField.Size = new System.Drawing.Size(190, 21);
            this.NumberPhoneField.TabIndex = 35;
            // 
            // SpecializationField
            // 
            this.SpecializationField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SpecializationField.DefaultText = "";
            this.SpecializationField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SpecializationField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SpecializationField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SpecializationField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SpecializationField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecializationField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SpecializationField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecializationField.Location = new System.Drawing.Point(482, 220);
            this.SpecializationField.Name = "SpecializationField";
            this.SpecializationField.PasswordChar = '\0';
            this.SpecializationField.PlaceholderText = "Специализация";
            this.SpecializationField.SelectedText = "";
            this.SpecializationField.Size = new System.Drawing.Size(190, 21);
            this.SpecializationField.TabIndex = 36;
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
            this.PassportField.Location = new System.Drawing.Point(482, 258);
            this.PassportField.Name = "PassportField";
            this.PassportField.PasswordChar = '\0';
            this.PassportField.PlaceholderText = "Паспорт";
            this.PassportField.SelectedText = "";
            this.PassportField.Size = new System.Drawing.Size(190, 21);
            this.PassportField.TabIndex = 37;
            // 
            // SalaryField
            // 
            this.SalaryField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalaryField.DefaultText = "";
            this.SalaryField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalaryField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalaryField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SalaryField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryField.Location = new System.Drawing.Point(472, 313);
            this.SalaryField.Name = "SalaryField";
            this.SalaryField.PasswordChar = '\0';
            this.SalaryField.PlaceholderText = "Заработная плата";
            this.SalaryField.SelectedText = "";
            this.SalaryField.Size = new System.Drawing.Size(190, 21);
            this.SalaryField.TabIndex = 38;
            // 
            // DateOfEmploymentField
            // 
            this.DateOfEmploymentField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateOfEmploymentField.DefaultText = "";
            this.DateOfEmploymentField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DateOfEmploymentField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DateOfEmploymentField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateOfEmploymentField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateOfEmploymentField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateOfEmploymentField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateOfEmploymentField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateOfEmploymentField.Location = new System.Drawing.Point(472, 348);
            this.DateOfEmploymentField.Name = "DateOfEmploymentField";
            this.DateOfEmploymentField.PasswordChar = '\0';
            this.DateOfEmploymentField.PlaceholderText = "Дата устройства";
            this.DateOfEmploymentField.SelectedText = "";
            this.DateOfEmploymentField.Size = new System.Drawing.Size(190, 21);
            this.DateOfEmploymentField.TabIndex = 39;
            // 
            // Masters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Masters";
            this.Text = "Owners";
            this.Load += new System.EventHandler(this.Masters_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label PersonalLabel;
        private System.Windows.Forms.PictureBox PersonalPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2TextBox DateOfEmploymentField;
        private Guna.UI2.WinForms.Guna2TextBox SalaryField;
        private Guna.UI2.WinForms.Guna2TextBox PassportField;
        private Guna.UI2.WinForms.Guna2TextBox SpecializationField;
        private Guna.UI2.WinForms.Guna2TextBox NumberPhoneField;
        private Guna.UI2.WinForms.Guna2TextBox DateOfBirthField;
        private Guna.UI2.WinForms.Guna2TextBox FIOField;
    }
}