namespace Course_work
{
    partial class AreaOfWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaOfWork));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.AreaOfWorkLabel = new System.Windows.Forms.Label();
            this.WorkPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ApprovalDateLabel = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.ApprovalDateField = new System.Windows.Forms.TextBox();
            this.CostOfWorkLabel = new System.Windows.Forms.Label();
            this.TypeOfWorkLabel = new System.Windows.Forms.Label();
            this.DeadlineField = new System.Windows.Forms.TextBox();
            this.CostOfWorkField = new System.Windows.Forms.TextBox();
            this.TypeOfWorkField = new System.Windows.Forms.TextBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.AreaOfWorkLabel);
            this.BodyPanel.Controls.Add(this.WorkPicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Controls.Add(this.ApprovalDateLabel);
            this.BodyPanel.Controls.Add(this.DeadlineLabel);
            this.BodyPanel.Controls.Add(this.ApprovalDateField);
            this.BodyPanel.Controls.Add(this.CostOfWorkLabel);
            this.BodyPanel.Controls.Add(this.TypeOfWorkLabel);
            this.BodyPanel.Controls.Add(this.DeadlineField);
            this.BodyPanel.Controls.Add(this.CostOfWorkField);
            this.BodyPanel.Controls.Add(this.TypeOfWorkField);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(834, 461);
            this.BodyPanel.TabIndex = 4;
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
            this.LeftPanel.BackgroundImage = global::Course_work.Properties.Resources.Panel_Background;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(95, 461);
            this.LeftPanel.TabIndex = 20;
            // 
            // ApprovalDateLabel
            // 
            this.ApprovalDateLabel.AutoSize = true;
            this.ApprovalDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ApprovalDateLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApprovalDateLabel.ForeColor = System.Drawing.Color.Violet;
            this.ApprovalDateLabel.Location = new System.Drawing.Point(130, 216);
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
            this.DeadlineLabel.Location = new System.Drawing.Point(119, 162);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(126, 16);
            this.DeadlineLabel.TabIndex = 15;
            this.DeadlineLabel.Text = "Срок выполнения";
            // 
            // ApprovalDateField
            // 
            this.ApprovalDateField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ApprovalDateField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ApprovalDateField.Location = new System.Drawing.Point(260, 215);
            this.ApprovalDateField.Name = "ApprovalDateField";
            this.ApprovalDateField.Size = new System.Drawing.Size(187, 21);
            this.ApprovalDateField.TabIndex = 13;
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
            this.DeadlineField.Location = new System.Drawing.Point(260, 161);
            this.DeadlineField.Name = "DeadlineField";
            this.DeadlineField.Size = new System.Drawing.Size(187, 21);
            this.DeadlineField.TabIndex = 7;
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
            this.AddButton.Location = new System.Drawing.Point(327, 348);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.CancelButton.Location = new System.Drawing.Point(514, 348);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 50);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AreaOfWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaOfWork";
            this.Text = "AreaOfWork";
            this.Load += new System.EventHandler(this.AreaofWork_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox WorkPicture;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label ApprovalDateLabel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.TextBox ApprovalDateField;
        private System.Windows.Forms.Label CostOfWorkLabel;
        private System.Windows.Forms.Label TypeOfWorkLabel;
        private System.Windows.Forms.TextBox DeadlineField;
        private System.Windows.Forms.TextBox CostOfWorkField;
        private System.Windows.Forms.TextBox TypeOfWorkField;
        private System.Windows.Forms.Label AreaOfWorkLabel;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
    }
}