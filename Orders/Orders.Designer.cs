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
            this.InsurancePaymentLabel = new System.Windows.Forms.Label();
            this.InsurancePaymentField = new System.Windows.Forms.TextBox();
            this.PersonalLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OrdersPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.ClientCodeLabel = new System.Windows.Forms.Label();
            this.RepairCostLabel = new System.Windows.Forms.Label();
            this.ReceiptDateLabel = new System.Windows.Forms.Label();
            this.DeadlineField = new System.Windows.Forms.TextBox();
            this.RepairCostField = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.VehicleCodeLabel = new System.Windows.Forms.Label();
            this.OrderCodeLabel = new System.Windows.Forms.Label();
            this.ReceiptDateField = new System.Windows.Forms.TextBox();
            this.OrderCodeComboBox = new System.Windows.Forms.ComboBox();
            this.VehicleCodeComboBox = new System.Windows.Forms.ComboBox();
            this.ClientCodeComboBox = new System.Windows.Forms.ComboBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyPanel.BackgroundImage")));
            this.BodyPanel.Controls.Add(this.ClientCodeComboBox);
            this.BodyPanel.Controls.Add(this.VehicleCodeComboBox);
            this.BodyPanel.Controls.Add(this.OrderCodeComboBox);
            this.BodyPanel.Controls.Add(this.InsurancePaymentLabel);
            this.BodyPanel.Controls.Add(this.InsurancePaymentField);
            this.BodyPanel.Controls.Add(this.PersonalLabel);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.OrdersPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.DeadlineLabel);
            this.BodyPanel.Controls.Add(this.ClientCodeLabel);
            this.BodyPanel.Controls.Add(this.RepairCostLabel);
            this.BodyPanel.Controls.Add(this.ReceiptDateLabel);
            this.BodyPanel.Controls.Add(this.DeadlineField);
            this.BodyPanel.Controls.Add(this.RepairCostField);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.VehicleCodeLabel);
            this.BodyPanel.Controls.Add(this.OrderCodeLabel);
            this.BodyPanel.Controls.Add(this.ReceiptDateField);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 450);
            this.BodyPanel.TabIndex = 7;
            // 
            // InsurancePaymentLabel
            // 
            this.InsurancePaymentLabel.AutoSize = true;
            this.InsurancePaymentLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsurancePaymentLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsurancePaymentLabel.ForeColor = System.Drawing.Color.Violet;
            this.InsurancePaymentLabel.Location = new System.Drawing.Point(103, 365);
            this.InsurancePaymentLabel.Name = "InsurancePaymentLabel";
            this.InsurancePaymentLabel.Size = new System.Drawing.Size(140, 16);
            this.InsurancePaymentLabel.TabIndex = 25;
            this.InsurancePaymentLabel.Text = "Страховая выплата";
            // 
            // InsurancePaymentField
            // 
            this.InsurancePaymentField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.InsurancePaymentField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InsurancePaymentField.Location = new System.Drawing.Point(261, 364);
            this.InsurancePaymentField.Name = "InsurancePaymentField";
            this.InsurancePaymentField.Size = new System.Drawing.Size(187, 21);
            this.InsurancePaymentField.TabIndex = 24;
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
            this.CancelButton.Location = new System.Drawing.Point(574, 400);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(95, 450);
            this.LeftPanel.TabIndex = 20;
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeadlineLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeadlineLabel.ForeColor = System.Drawing.Color.Violet;
            this.DeadlineLabel.Location = new System.Drawing.Point(117, 312);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(126, 16);
            this.DeadlineLabel.TabIndex = 19;
            this.DeadlineLabel.Text = "Срок выполнения";
            // 
            // ClientCodeLabel
            // 
            this.ClientCodeLabel.AutoSize = true;
            this.ClientCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientCodeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientCodeLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.ClientCodeLabel.Location = new System.Drawing.Point(152, 168);
            this.ClientCodeLabel.Name = "ClientCodeLabel";
            this.ClientCodeLabel.Size = new System.Drawing.Size(91, 16);
            this.ClientCodeLabel.TabIndex = 18;
            this.ClientCodeLabel.Text = "Код клиента";
            // 
            // RepairCostLabel
            // 
            this.RepairCostLabel.AutoSize = true;
            this.RepairCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.RepairCostLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairCostLabel.ForeColor = System.Drawing.Color.Violet;
            this.RepairCostLabel.Location = new System.Drawing.Point(106, 260);
            this.RepairCostLabel.Name = "RepairCostLabel";
            this.RepairCostLabel.Size = new System.Drawing.Size(137, 16);
            this.RepairCostLabel.TabIndex = 16;
            this.RepairCostLabel.Text = "Стоимость ремонта";
            // 
            // ReceiptDateLabel
            // 
            this.ReceiptDateLabel.AutoSize = true;
            this.ReceiptDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReceiptDateLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceiptDateLabel.ForeColor = System.Drawing.Color.Violet;
            this.ReceiptDateLabel.Location = new System.Drawing.Point(113, 210);
            this.ReceiptDateLabel.Name = "ReceiptDateLabel";
            this.ReceiptDateLabel.Size = new System.Drawing.Size(130, 16);
            this.ReceiptDateLabel.TabIndex = 15;
            this.ReceiptDateLabel.Text = "Дата поступления";
            // 
            // DeadlineField
            // 
            this.DeadlineField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DeadlineField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeadlineField.Location = new System.Drawing.Point(261, 311);
            this.DeadlineField.Name = "DeadlineField";
            this.DeadlineField.Size = new System.Drawing.Size(187, 21);
            this.DeadlineField.TabIndex = 14;
            // 
            // RepairCostField
            // 
            this.RepairCostField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RepairCostField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RepairCostField.Location = new System.Drawing.Point(261, 259);
            this.RepairCostField.Name = "RepairCostField";
            this.RepairCostField.Size = new System.Drawing.Size(187, 21);
            this.RepairCostField.TabIndex = 13;
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
            this.AddButton.Location = new System.Drawing.Point(261, 400);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(187, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // VehicleCodeLabel
            // 
            this.VehicleCodeLabel.AutoSize = true;
            this.VehicleCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.VehicleCodeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VehicleCodeLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.VehicleCodeLabel.Location = new System.Drawing.Point(126, 109);
            this.VehicleCodeLabel.Name = "VehicleCodeLabel";
            this.VehicleCodeLabel.Size = new System.Drawing.Size(117, 16);
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
            this.OrderCodeLabel.Size = new System.Drawing.Size(82, 16);
            this.OrderCodeLabel.TabIndex = 8;
            this.OrderCodeLabel.Text = "Код заказа";
            // 
            // ReceiptDateField
            // 
            this.ReceiptDateField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReceiptDateField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ReceiptDateField.Location = new System.Drawing.Point(261, 209);
            this.ReceiptDateField.Name = "ReceiptDateField";
            this.ReceiptDateField.Size = new System.Drawing.Size(187, 21);
            this.ReceiptDateField.TabIndex = 7;
            // 
            // OrderCodeComboBox
            // 
            this.OrderCodeComboBox.FormattingEnabled = true;
            this.OrderCodeComboBox.Location = new System.Drawing.Point(261, 59);
            this.OrderCodeComboBox.Name = "OrderCodeComboBox";
            this.OrderCodeComboBox.Size = new System.Drawing.Size(187, 21);
            this.OrderCodeComboBox.TabIndex = 26;
            // 
            // VehicleCodeComboBox
            // 
            this.VehicleCodeComboBox.FormattingEnabled = true;
            this.VehicleCodeComboBox.Location = new System.Drawing.Point(261, 108);
            this.VehicleCodeComboBox.Name = "VehicleCodeComboBox";
            this.VehicleCodeComboBox.Size = new System.Drawing.Size(187, 21);
            this.VehicleCodeComboBox.TabIndex = 27;
            // 
            // ClientCodeComboBox
            // 
            this.ClientCodeComboBox.FormattingEnabled = true;
            this.ClientCodeComboBox.Location = new System.Drawing.Point(261, 163);
            this.ClientCodeComboBox.Name = "ClientCodeComboBox";
            this.ClientCodeComboBox.Size = new System.Drawing.Size(187, 21);
            this.ClientCodeComboBox.TabIndex = 28;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyPanel);
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
        private System.Windows.Forms.Label InsurancePaymentLabel;
        private System.Windows.Forms.TextBox InsurancePaymentField;
        private System.Windows.Forms.Label PersonalLabel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox OrdersPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.Label ClientCodeLabel;
        private System.Windows.Forms.Label RepairCostLabel;
        private System.Windows.Forms.Label ReceiptDateLabel;
        private System.Windows.Forms.TextBox DeadlineField;
        private System.Windows.Forms.TextBox RepairCostField;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label VehicleCodeLabel;
        private System.Windows.Forms.Label OrderCodeLabel;
        private System.Windows.Forms.TextBox ReceiptDateField;
        private System.Windows.Forms.ComboBox ClientCodeComboBox;
        private System.Windows.Forms.ComboBox VehicleCodeComboBox;
        private System.Windows.Forms.ComboBox OrderCodeComboBox;
    }
}