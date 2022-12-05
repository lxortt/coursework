namespace Course_work.Cars
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.EngineNumberField = new Guna.UI2.WinForms.Guna2TextBox();
            this.VehicleYearField = new Guna.UI2.WinForms.Guna2TextBox();
            this.CarColorField = new Guna.UI2.WinForms.Guna2TextBox();
            this.TechnicalCertificateField = new Guna.UI2.WinForms.Guna2TextBox();
            this.VINField = new Guna.UI2.WinForms.Guna2TextBox();
            this.MachineBrandField = new Guna.UI2.WinForms.Guna2TextBox();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.CarsLabel = new System.Windows.Forms.Label();
            this.CarsPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.EngineNumberField);
            this.BodyPanel.Controls.Add(this.VehicleYearField);
            this.BodyPanel.Controls.Add(this.CarColorField);
            this.BodyPanel.Controls.Add(this.TechnicalCertificateField);
            this.BodyPanel.Controls.Add(this.VINField);
            this.BodyPanel.Controls.Add(this.MachineBrandField);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.CarsLabel);
            this.BodyPanel.Controls.Add(this.CarsPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(834, 461);
            this.BodyPanel.TabIndex = 3;
            // 
            // EngineNumberField
            // 
            this.EngineNumberField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EngineNumberField.DefaultText = "";
            this.EngineNumberField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EngineNumberField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EngineNumberField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EngineNumberField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EngineNumberField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EngineNumberField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EngineNumberField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EngineNumberField.Location = new System.Drawing.Point(452, 317);
            this.EngineNumberField.Name = "EngineNumberField";
            this.EngineNumberField.PasswordChar = '\0';
            this.EngineNumberField.PlaceholderText = "Номер двигателя";
            this.EngineNumberField.SelectedText = "";
            this.EngineNumberField.Size = new System.Drawing.Size(187, 21);
            this.EngineNumberField.TabIndex = 35;
            // 
            // VehicleYearField
            // 
            this.VehicleYearField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VehicleYearField.DefaultText = "";
            this.VehicleYearField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VehicleYearField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VehicleYearField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VehicleYearField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VehicleYearField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VehicleYearField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VehicleYearField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VehicleYearField.Location = new System.Drawing.Point(452, 259);
            this.VehicleYearField.Name = "VehicleYearField";
            this.VehicleYearField.PasswordChar = '\0';
            this.VehicleYearField.PlaceholderText = "Год выпуска";
            this.VehicleYearField.SelectedText = "";
            this.VehicleYearField.Size = new System.Drawing.Size(187, 21);
            this.VehicleYearField.TabIndex = 34;
            // 
            // CarColorField
            // 
            this.CarColorField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CarColorField.DefaultText = "";
            this.CarColorField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CarColorField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CarColorField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CarColorField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CarColorField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CarColorField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CarColorField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CarColorField.Location = new System.Drawing.Point(452, 210);
            this.CarColorField.Name = "CarColorField";
            this.CarColorField.PasswordChar = '\0';
            this.CarColorField.PlaceholderText = "Цвет";
            this.CarColorField.SelectedText = "";
            this.CarColorField.Size = new System.Drawing.Size(187, 21);
            this.CarColorField.TabIndex = 33;
            // 
            // TechnicalCertificateField
            // 
            this.TechnicalCertificateField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicalCertificateField.DefaultText = "";
            this.TechnicalCertificateField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TechnicalCertificateField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TechnicalCertificateField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TechnicalCertificateField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TechnicalCertificateField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TechnicalCertificateField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TechnicalCertificateField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TechnicalCertificateField.Location = new System.Drawing.Point(460, 159);
            this.TechnicalCertificateField.Name = "TechnicalCertificateField";
            this.TechnicalCertificateField.PasswordChar = '\0';
            this.TechnicalCertificateField.PlaceholderText = "Тех.Паспорт";
            this.TechnicalCertificateField.SelectedText = "";
            this.TechnicalCertificateField.Size = new System.Drawing.Size(190, 21);
            this.TechnicalCertificateField.TabIndex = 32;
            // 
            // VINField
            // 
            this.VINField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VINField.DefaultText = "";
            this.VINField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VINField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VINField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VINField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VINField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VINField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VINField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VINField.Location = new System.Drawing.Point(460, 108);
            this.VINField.Name = "VINField";
            this.VINField.PasswordChar = '\0';
            this.VINField.PlaceholderText = "VIN";
            this.VINField.SelectedText = "";
            this.VINField.Size = new System.Drawing.Size(187, 21);
            this.VINField.TabIndex = 31;
            // 
            // MachineBrandField
            // 
            this.MachineBrandField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MachineBrandField.DefaultText = "";
            this.MachineBrandField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MachineBrandField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MachineBrandField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MachineBrandField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MachineBrandField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MachineBrandField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MachineBrandField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MachineBrandField.Location = new System.Drawing.Point(452, 55);
            this.MachineBrandField.Name = "MachineBrandField";
            this.MachineBrandField.PasswordChar = '\0';
            this.MachineBrandField.PlaceholderText = "Марка ТС";
            this.MachineBrandField.SelectedText = "";
            this.MachineBrandField.Size = new System.Drawing.Size(187, 21);
            this.MachineBrandField.TabIndex = 30;
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
            this.CancelButton.Location = new System.Drawing.Point(650, 377);
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
            this.AddButton.Location = new System.Drawing.Point(492, 377);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CarsLabel
            // 
            this.CarsLabel.AutoSize = true;
            this.CarsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CarsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsLabel.ForeColor = System.Drawing.Color.White;
            this.CarsLabel.Location = new System.Drawing.Point(118, 21);
            this.CarsLabel.Name = "CarsLabel";
            this.CarsLabel.Size = new System.Drawing.Size(529, 19);
            this.CarsLabel.TabIndex = 23;
            this.CarsLabel.Text = "Для внесения данных в таблицу заполните следующие поля:";
            this.CarsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CarsPicture
            // 
            this.CarsPicture.BackColor = System.Drawing.Color.Transparent;
            this.CarsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CarsPicture.ErrorImage = null;
            this.CarsPicture.Image = global::Course_work.Properties.Resources.Car;
            this.CarsPicture.InitialImage = null;
            this.CarsPicture.Location = new System.Drawing.Point(514, 55);
            this.CarsPicture.Name = "CarsPicture";
            this.CarsPicture.Size = new System.Drawing.Size(256, 256);
            this.CarsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarsPicture.TabIndex = 3;
            this.CarsPicture.TabStop = false;
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
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course_work.Properties.Resources._312;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox CarsPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label CarsLabel;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2TextBox EngineNumberField;
        private Guna.UI2.WinForms.Guna2TextBox VehicleYearField;
        private Guna.UI2.WinForms.Guna2TextBox CarColorField;
        private Guna.UI2.WinForms.Guna2TextBox TechnicalCertificateField;
        private Guna.UI2.WinForms.Guna2TextBox VINField;
        private Guna.UI2.WinForms.Guna2TextBox MachineBrandField;
    }
}