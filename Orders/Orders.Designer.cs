namespace Course_work.Orders
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClientCodeComboBox = new System.Windows.Forms.ComboBox();
            this.VehicleCodeComboBox = new System.Windows.Forms.ComboBox();
            this.OrderCodeComboBox = new System.Windows.Forms.ComboBox();
            this.PersonalLabel = new System.Windows.Forms.Label();
            this.OrdersPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ClientCodeLabel = new System.Windows.Forms.Label();
            this.VehicleCodeLabel = new System.Windows.Forms.Label();
            this.OrderCodeLabel = new System.Windows.Forms.Label();
            this.ReceiptDateField = new Guna.UI2.WinForms.Guna2TextBox();
            this.RepairCostField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeadlineField = new Guna.UI2.WinForms.Guna2TextBox();
            this.InsurancePaymentField = new Guna.UI2.WinForms.Guna2TextBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.InsurancePaymentField);
            this.BodyPanel.Controls.Add(this.DeadlineField);
            this.BodyPanel.Controls.Add(this.RepairCostField);
            this.BodyPanel.Controls.Add(this.ReceiptDateField);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.ClientCodeComboBox);
            this.BodyPanel.Controls.Add(this.VehicleCodeComboBox);
            this.BodyPanel.Controls.Add(this.OrderCodeComboBox);
            this.BodyPanel.Controls.Add(this.PersonalLabel);
            this.BodyPanel.Controls.Add(this.OrdersPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.ClientCodeLabel);
            this.BodyPanel.Controls.Add(this.VehicleCodeLabel);
            this.BodyPanel.Controls.Add(this.OrderCodeLabel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(834, 461);
            this.BodyPanel.TabIndex = 7;
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
            this.CancelButton.Location = new System.Drawing.Point(514, 399);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 50);
            this.CancelButton.TabIndex = 30;
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
            this.AddButton.Location = new System.Drawing.Point(328, 399);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClientCodeComboBox
            // 
            this.ClientCodeComboBox.FormattingEnabled = true;
            this.ClientCodeComboBox.Location = new System.Drawing.Point(261, 163);
            this.ClientCodeComboBox.Name = "ClientCodeComboBox";
            this.ClientCodeComboBox.Size = new System.Drawing.Size(187, 21);
            this.ClientCodeComboBox.TabIndex = 28;
            // 
            // VehicleCodeComboBox
            // 
            this.VehicleCodeComboBox.FormattingEnabled = true;
            this.VehicleCodeComboBox.Location = new System.Drawing.Point(261, 108);
            this.VehicleCodeComboBox.Name = "VehicleCodeComboBox";
            this.VehicleCodeComboBox.Size = new System.Drawing.Size(187, 21);
            this.VehicleCodeComboBox.TabIndex = 27;
            // 
            // OrderCodeComboBox
            // 
            this.OrderCodeComboBox.FormattingEnabled = true;
            this.OrderCodeComboBox.Location = new System.Drawing.Point(261, 59);
            this.OrderCodeComboBox.Name = "OrderCodeComboBox";
            this.OrderCodeComboBox.Size = new System.Drawing.Size(187, 21);
            this.OrderCodeComboBox.TabIndex = 26;
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
            // OrdersPicture
            // 
            this.OrdersPicture.BackColor = System.Drawing.Color.Transparent;
            this.OrdersPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OrdersPicture.ErrorImage = null;
            this.OrdersPicture.Image = global::Course_work.Properties.Resources.Work;
            this.OrdersPicture.InitialImage = null;
            this.OrdersPicture.Location = new System.Drawing.Point(505, 55);
            this.OrdersPicture.Name = "OrdersPicture";
            this.OrdersPicture.Size = new System.Drawing.Size(256, 256);
            this.OrdersPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrdersPicture.TabIndex = 3;
            this.OrdersPicture.TabStop = false;
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
            // ClientCodeLabel
            // 
            this.ClientCodeLabel.AutoSize = true;
            this.ClientCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientCodeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientCodeLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.ClientCodeLabel.Location = new System.Drawing.Point(152, 168);
            this.ClientCodeLabel.Name = "ClientCodeLabel";
            this.ClientCodeLabel.Size = new System.Drawing.Size(92, 16);
            this.ClientCodeLabel.TabIndex = 18;
            this.ClientCodeLabel.Text = "Код клиента";
            // 
            // VehicleCodeLabel
            // 
            this.VehicleCodeLabel.AutoSize = true;
            this.VehicleCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.VehicleCodeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VehicleCodeLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.VehicleCodeLabel.Location = new System.Drawing.Point(126, 109);
            this.VehicleCodeLabel.Name = "VehicleCodeLabel";
            this.VehicleCodeLabel.Size = new System.Drawing.Size(118, 16);
            this.VehicleCodeLabel.TabIndex = 10;
            this.VehicleCodeLabel.Text = "Код автомобиля";
            // 
            // OrderCodeLabel
            // 
            this.OrderCodeLabel.AutoSize = true;
            this.OrderCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderCodeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCodeLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.OrderCodeLabel.Location = new System.Drawing.Point(161, 60);
            this.OrderCodeLabel.Name = "OrderCodeLabel";
            this.OrderCodeLabel.Size = new System.Drawing.Size(83, 16);
            this.OrderCodeLabel.TabIndex = 8;
            this.OrderCodeLabel.Text = "Код заказа";
            // 
            // ReceiptDateField
            // 
            this.ReceiptDateField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReceiptDateField.DefaultText = "";
            this.ReceiptDateField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReceiptDateField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReceiptDateField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReceiptDateField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReceiptDateField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReceiptDateField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReceiptDateField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReceiptDateField.Location = new System.Drawing.Point(261, 210);
            this.ReceiptDateField.Name = "ReceiptDateField";
            this.ReceiptDateField.PasswordChar = '\0';
            this.ReceiptDateField.PlaceholderText = "Дата поступления";
            this.ReceiptDateField.SelectedText = "";
            this.ReceiptDateField.Size = new System.Drawing.Size(187, 21);
            this.ReceiptDateField.TabIndex = 31;
            // 
            // RepairCostField
            // 
            this.RepairCostField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RepairCostField.DefaultText = "";
            this.RepairCostField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RepairCostField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RepairCostField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RepairCostField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RepairCostField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepairCostField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RepairCostField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepairCostField.Location = new System.Drawing.Point(261, 255);
            this.RepairCostField.Name = "RepairCostField";
            this.RepairCostField.PasswordChar = '\0';
            this.RepairCostField.PlaceholderText = "Стоимость ремонта";
            this.RepairCostField.SelectedText = "";
            this.RepairCostField.Size = new System.Drawing.Size(187, 21);
            this.RepairCostField.TabIndex = 32;
            // 
            // DeadlineField
            // 
            this.DeadlineField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeadlineField.DefaultText = "";
            this.DeadlineField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeadlineField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeadlineField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeadlineField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeadlineField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeadlineField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeadlineField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeadlineField.Location = new System.Drawing.Point(261, 312);
            this.DeadlineField.Name = "DeadlineField";
            this.DeadlineField.PasswordChar = '\0';
            this.DeadlineField.PlaceholderText = "Срок выполнения ";
            this.DeadlineField.SelectedText = "";
            this.DeadlineField.Size = new System.Drawing.Size(187, 21);
            this.DeadlineField.TabIndex = 33;
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
            this.InsurancePaymentField.Location = new System.Drawing.Point(258, 365);
            this.InsurancePaymentField.Name = "InsurancePaymentField";
            this.InsurancePaymentField.PasswordChar = '\0';
            this.InsurancePaymentField.PlaceholderText = "Страховая выплата";
            this.InsurancePaymentField.SelectedText = "";
            this.InsurancePaymentField.Size = new System.Drawing.Size(190, 21);
            this.InsurancePaymentField.TabIndex = 34;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label PersonalLabel;
        private System.Windows.Forms.PictureBox OrdersPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label ClientCodeLabel;
        private System.Windows.Forms.Label VehicleCodeLabel;
        private System.Windows.Forms.Label OrderCodeLabel;
        private System.Windows.Forms.ComboBox ClientCodeComboBox;
        private System.Windows.Forms.ComboBox VehicleCodeComboBox;
        private System.Windows.Forms.ComboBox OrderCodeComboBox;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2TextBox InsurancePaymentField;
        private Guna.UI2.WinForms.Guna2TextBox DeadlineField;
        private Guna.UI2.WinForms.Guna2TextBox RepairCostField;
        private Guna.UI2.WinForms.Guna2TextBox ReceiptDateField;
    }
}