namespace Course_work
{
    partial class AreaofWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaofWork));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.WorkPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.InsurancePaymentLabel = new System.Windows.Forms.Label();
            this.ApprovalDateLabel = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.ApprovalDateField = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CostOfWorkLabel = new System.Windows.Forms.Label();
            this.TypeOfWorkLabel = new System.Windows.Forms.Label();
            this.DeadlineField = new System.Windows.Forms.TextBox();
            this.InsurancePaymentField = new System.Windows.Forms.TextBox();
            this.CostOfWorkField = new System.Windows.Forms.TextBox();
            this.TypeOfWorkField = new System.Windows.Forms.TextBox();
            this.AreaOfWorkLabel = new System.Windows.Forms.Label();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyPanel.BackgroundImage")));
            this.BodyPanel.Controls.Add(this.AreaOfWorkLabel);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.WorkPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.InsurancePaymentLabel);
            this.BodyPanel.Controls.Add(this.ApprovalDateLabel);
            this.BodyPanel.Controls.Add(this.DeadlineLabel);
            this.BodyPanel.Controls.Add(this.ApprovalDateField);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.CostOfWorkLabel);
            this.BodyPanel.Controls.Add(this.TypeOfWorkLabel);
            this.BodyPanel.Controls.Add(this.DeadlineField);
            this.BodyPanel.Controls.Add(this.InsurancePaymentField);
            this.BodyPanel.Controls.Add(this.CostOfWorkField);
            this.BodyPanel.Controls.Add(this.TypeOfWorkField);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(800, 450);
            this.BodyPanel.TabIndex = 4;
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
            this.CancelButton.Location = new System.Drawing.Point(260, 357);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // WorkPicture
            // 
            this.WorkPicture.BackColor = System.Drawing.Color.Transparent;
            this.WorkPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WorkPicture.ErrorImage = null;
            this.WorkPicture.Image = global::Course_work.Properties.Resources.Work;
            this.WorkPicture.InitialImage = null;
            this.WorkPicture.Location = new System.Drawing.Point(514, 55);
            this.WorkPicture.Name = "WorkPicture";
            this.WorkPicture.Size = new System.Drawing.Size(256, 256);
            this.WorkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WorkPicture.TabIndex = 3;
            this.WorkPicture.TabStop = false;
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
            // InsurancePaymentLabel
            // 
            this.InsurancePaymentLabel.AutoSize = true;
            this.InsurancePaymentLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsurancePaymentLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsurancePaymentLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.InsurancePaymentLabel.Location = new System.Drawing.Point(105, 160);
            this.InsurancePaymentLabel.Name = "InsurancePaymentLabel";
            this.InsurancePaymentLabel.Size = new System.Drawing.Size(140, 16);
            this.InsurancePaymentLabel.TabIndex = 18;
            this.InsurancePaymentLabel.Text = "Страховая выплата";
            // 
            // ApprovalDateLabel
            // 
            this.ApprovalDateLabel.AutoSize = true;
            this.ApprovalDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ApprovalDateLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApprovalDateLabel.ForeColor = System.Drawing.Color.Violet;
            this.ApprovalDateLabel.Location = new System.Drawing.Point(130, 260);
            this.ApprovalDateLabel.Name = "ApprovalDateLabel";
            this.ApprovalDateLabel.Size = new System.Drawing.Size(115, 16);
            this.ApprovalDateLabel.TabIndex = 16;
            this.ApprovalDateLabel.Text = "Дата заявления";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeadlineLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeadlineLabel.ForeColor = System.Drawing.Color.Violet;
            this.DeadlineLabel.Location = new System.Drawing.Point(119, 210);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(126, 16);
            this.DeadlineLabel.TabIndex = 15;
            this.DeadlineLabel.Text = "Срок выполнения";
            // 
            // ApprovalDateField
            // 
            this.ApprovalDateField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ApprovalDateField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ApprovalDateField.Location = new System.Drawing.Point(260, 259);
            this.ApprovalDateField.Name = "ApprovalDateField";
            this.ApprovalDateField.Size = new System.Drawing.Size(187, 21);
            this.ApprovalDateField.TabIndex = 13;
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
            this.AddButton.Location = new System.Drawing.Point(260, 309);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(187, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CostOfWorkLabel
            // 
            this.CostOfWorkLabel.AutoSize = true;
            this.CostOfWorkLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostOfWorkLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostOfWorkLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.CostOfWorkLabel.Location = new System.Drawing.Point(115, 113);
            this.CostOfWorkLabel.Name = "CostOfWorkLabel";
            this.CostOfWorkLabel.Size = new System.Drawing.Size(130, 16);
            this.CostOfWorkLabel.TabIndex = 10;
            this.CostOfWorkLabel.Text = "Стоимость работы";
            // 
            // TypeOfWorkLabel
            // 
            this.TypeOfWorkLabel.AutoSize = true;
            this.TypeOfWorkLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeOfWorkLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfWorkLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.TypeOfWorkLabel.Location = new System.Drawing.Point(160, 60);
            this.TypeOfWorkLabel.Name = "TypeOfWorkLabel";
            this.TypeOfWorkLabel.Size = new System.Drawing.Size(85, 16);
            this.TypeOfWorkLabel.TabIndex = 8;
            this.TypeOfWorkLabel.Text = "Вид работы";
            // 
            // DeadlineField
            // 
            this.DeadlineField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DeadlineField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeadlineField.Location = new System.Drawing.Point(260, 209);
            this.DeadlineField.Name = "DeadlineField";
            this.DeadlineField.Size = new System.Drawing.Size(187, 21);
            this.DeadlineField.TabIndex = 7;
            // 
            // InsurancePaymentField
            // 
            this.InsurancePaymentField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.InsurancePaymentField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InsurancePaymentField.Location = new System.Drawing.Point(260, 159);
            this.InsurancePaymentField.Name = "InsurancePaymentField";
            this.InsurancePaymentField.Size = new System.Drawing.Size(187, 21);
            this.InsurancePaymentField.TabIndex = 6;
            // 
            // CostOfWorkField
            // 
            this.CostOfWorkField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CostOfWorkField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CostOfWorkField.Location = new System.Drawing.Point(260, 108);
            this.CostOfWorkField.Name = "CostOfWorkField";
            this.CostOfWorkField.Size = new System.Drawing.Size(187, 21);
            this.CostOfWorkField.TabIndex = 5;
            // 
            // TypeOfWorkField
            // 
            this.TypeOfWorkField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TypeOfWorkField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TypeOfWorkField.Location = new System.Drawing.Point(260, 55);
            this.TypeOfWorkField.Name = "TypeOfWorkField";
            this.TypeOfWorkField.Size = new System.Drawing.Size(187, 21);
            this.TypeOfWorkField.TabIndex = 4;
            // 
            // AreaOfWorkLabel
            // 
            this.AreaOfWorkLabel.AutoSize = true;
            this.AreaOfWorkLabel.BackColor = System.Drawing.Color.Transparent;
            this.AreaOfWorkLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AreaOfWorkLabel.ForeColor = System.Drawing.Color.White;
            this.AreaOfWorkLabel.Location = new System.Drawing.Point(114, 21);
            this.AreaOfWorkLabel.Name = "AreaOfWorkLabel";
            this.AreaOfWorkLabel.Size = new System.Drawing.Size(529, 19);
            this.AreaOfWorkLabel.TabIndex = 23;
            this.AreaOfWorkLabel.Text = "Для внесения данных в таблицу заполните следующие поля:";
            this.AreaOfWorkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AreaofWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaofWork";
            this.Text = "AreaOfWork";
            this.Load += new System.EventHandler(this.AreaofWork_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox WorkPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label InsurancePaymentLabel;
        private System.Windows.Forms.Label ApprovalDateLabel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.TextBox ApprovalDateField;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CostOfWorkLabel;
        private System.Windows.Forms.Label TypeOfWorkLabel;
        private System.Windows.Forms.TextBox DeadlineField;
        private System.Windows.Forms.TextBox InsurancePaymentField;
        private System.Windows.Forms.TextBox CostOfWorkField;
        private System.Windows.Forms.TextBox TypeOfWorkField;
        private System.Windows.Forms.Label AreaOfWorkLabel;
    }
}