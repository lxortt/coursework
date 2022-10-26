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
            this.CancelButton = new System.Windows.Forms.Button();
            this.CarsPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.EngineNumberLabel = new System.Windows.Forms.Label();
            this.TechnicalCertificateLabel = new System.Windows.Forms.Label();
            this.VehicleYearLabel = new System.Windows.Forms.Label();
            this.CarColorLabel = new System.Windows.Forms.Label();
            this.EngineNumberField = new System.Windows.Forms.TextBox();
            this.VehicleYearField = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.VINLabel = new System.Windows.Forms.Label();
            this.MachineBrandLabel = new System.Windows.Forms.Label();
            this.CarColorField = new System.Windows.Forms.TextBox();
            this.TechnicalCertificateField = new System.Windows.Forms.TextBox();
            this.VINField = new System.Windows.Forms.TextBox();
            this.MachineBrandField = new System.Windows.Forms.TextBox();
            this.CarsLabel = new System.Windows.Forms.Label();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyPanel.BackgroundImage")));
            this.BodyPanel.Controls.Add(this.CarsLabel);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.CarsPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.EngineNumberLabel);
            this.BodyPanel.Controls.Add(this.TechnicalCertificateLabel);
            this.BodyPanel.Controls.Add(this.VehicleYearLabel);
            this.BodyPanel.Controls.Add(this.CarColorLabel);
            this.BodyPanel.Controls.Add(this.EngineNumberField);
            this.BodyPanel.Controls.Add(this.VehicleYearField);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.VINLabel);
            this.BodyPanel.Controls.Add(this.MachineBrandLabel);
            this.BodyPanel.Controls.Add(this.CarColorField);
            this.BodyPanel.Controls.Add(this.TechnicalCertificateField);
            this.BodyPanel.Controls.Add(this.VINField);
            this.BodyPanel.Controls.Add(this.MachineBrandField);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 450);
            this.BodyPanel.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.CancelButton.Location = new System.Drawing.Point(259, 412);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
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
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(95, 450);
            this.LeftPanel.TabIndex = 20;
            // 
            // EngineNumberLabel
            // 
            this.EngineNumberLabel.AutoSize = true;
            this.EngineNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.EngineNumberLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngineNumberLabel.ForeColor = System.Drawing.Color.Violet;
            this.EngineNumberLabel.Location = new System.Drawing.Point(119, 311);
            this.EngineNumberLabel.Name = "EngineNumberLabel";
            this.EngineNumberLabel.Size = new System.Drawing.Size(124, 16);
            this.EngineNumberLabel.TabIndex = 19;
            this.EngineNumberLabel.Text = "Номер двигателя";
            // 
            // TechnicalCertificateLabel
            // 
            this.TechnicalCertificateLabel.AutoSize = true;
            this.TechnicalCertificateLabel.BackColor = System.Drawing.Color.Transparent;
            this.TechnicalCertificateLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicalCertificateLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.TechnicalCertificateLabel.Location = new System.Drawing.Point(154, 164);
            this.TechnicalCertificateLabel.Name = "TechnicalCertificateLabel";
            this.TechnicalCertificateLabel.Size = new System.Drawing.Size(89, 16);
            this.TechnicalCertificateLabel.TabIndex = 18;
            this.TechnicalCertificateLabel.Text = "Тех.Паспорт";
            // 
            // VehicleYearLabel
            // 
            this.VehicleYearLabel.AutoSize = true;
            this.VehicleYearLabel.BackColor = System.Drawing.Color.Transparent;
            this.VehicleYearLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VehicleYearLabel.ForeColor = System.Drawing.Color.Violet;
            this.VehicleYearLabel.Location = new System.Drawing.Point(150, 260);
            this.VehicleYearLabel.Name = "VehicleYearLabel";
            this.VehicleYearLabel.Size = new System.Drawing.Size(93, 16);
            this.VehicleYearLabel.TabIndex = 16;
            this.VehicleYearLabel.Text = "Год выпуска";
            // 
            // CarColorLabel
            // 
            this.CarColorLabel.AutoSize = true;
            this.CarColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.CarColorLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarColorLabel.ForeColor = System.Drawing.Color.Violet;
            this.CarColorLabel.Location = new System.Drawing.Point(203, 210);
            this.CarColorLabel.Name = "CarColorLabel";
            this.CarColorLabel.Size = new System.Drawing.Size(40, 16);
            this.CarColorLabel.TabIndex = 15;
            this.CarColorLabel.Text = "Цвет";
            // 
            // EngineNumberField
            // 
            this.EngineNumberField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.EngineNumberField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EngineNumberField.Location = new System.Drawing.Point(259, 311);
            this.EngineNumberField.Name = "EngineNumberField";
            this.EngineNumberField.Size = new System.Drawing.Size(187, 21);
            this.EngineNumberField.TabIndex = 14;
            // 
            // VehicleYearField
            // 
            this.VehicleYearField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.VehicleYearField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VehicleYearField.Location = new System.Drawing.Point(259, 259);
            this.VehicleYearField.Name = "VehicleYearField";
            this.VehicleYearField.Size = new System.Drawing.Size(187, 21);
            this.VehicleYearField.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddButton.Location = new System.Drawing.Point(259, 367);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(187, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.BackColor = System.Drawing.Color.Transparent;
            this.VINLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VINLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.VINLabel.Location = new System.Drawing.Point(214, 113);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(29, 16);
            this.VINLabel.TabIndex = 10;
            this.VINLabel.Text = "VIN";
            // 
            // MachineBrandLabel
            // 
            this.MachineBrandLabel.AutoSize = true;
            this.MachineBrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.MachineBrandLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MachineBrandLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.MachineBrandLabel.Location = new System.Drawing.Point(174, 60);
            this.MachineBrandLabel.Name = "MachineBrandLabel";
            this.MachineBrandLabel.Size = new System.Drawing.Size(69, 16);
            this.MachineBrandLabel.TabIndex = 8;
            this.MachineBrandLabel.Text = "Марка ТС";
            // 
            // CarColorField
            // 
            this.CarColorField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CarColorField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CarColorField.Location = new System.Drawing.Point(259, 209);
            this.CarColorField.Name = "CarColorField";
            this.CarColorField.Size = new System.Drawing.Size(187, 21);
            this.CarColorField.TabIndex = 7;
            // 
            // TechnicalCertificateField
            // 
            this.TechnicalCertificateField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TechnicalCertificateField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TechnicalCertificateField.Location = new System.Drawing.Point(259, 159);
            this.TechnicalCertificateField.Name = "TechnicalCertificateField";
            this.TechnicalCertificateField.Size = new System.Drawing.Size(187, 21);
            this.TechnicalCertificateField.TabIndex = 6;
            // 
            // VINField
            // 
            this.VINField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.VINField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VINField.Location = new System.Drawing.Point(259, 108);
            this.VINField.Name = "VINField";
            this.VINField.Size = new System.Drawing.Size(187, 21);
            this.VINField.TabIndex = 5;
            // 
            // MachineBrandField
            // 
            this.MachineBrandField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MachineBrandField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MachineBrandField.Location = new System.Drawing.Point(259, 55);
            this.MachineBrandField.Name = "MachineBrandField";
            this.MachineBrandField.Size = new System.Drawing.Size(187, 21);
            this.MachineBrandField.TabIndex = 4;
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
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course_work.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label VehicleYearLabel;
        private System.Windows.Forms.Label CarColorLabel;
        private System.Windows.Forms.TextBox EngineNumberField;
        private System.Windows.Forms.TextBox VehicleYearField;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label MachineBrandLabel;
        private System.Windows.Forms.TextBox CarColorField;
        private System.Windows.Forms.TextBox TechnicalCertificateField;
        private System.Windows.Forms.TextBox VINField;
        private System.Windows.Forms.TextBox MachineBrandField;
        private System.Windows.Forms.PictureBox CarsPicture;
        private System.Windows.Forms.Label EngineNumberLabel;
        private System.Windows.Forms.Label TechnicalCertificateLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CarsLabel;
    }
}