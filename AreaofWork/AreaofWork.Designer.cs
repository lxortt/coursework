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
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.AreaOfWorkLabel = new System.Windows.Forms.Label();
            this.WorkPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TypeOfWorkField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeadlineField = new Guna.UI2.WinForms.Guna2TextBox();
            this.CostOfWorkField = new Guna.UI2.WinForms.Guna2TextBox();
            this.ApprovalDateField = new Guna.UI2.WinForms.Guna2TextBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.ApprovalDateField);
            this.BodyPanel.Controls.Add(this.CostOfWorkField);
            this.BodyPanel.Controls.Add(this.DeadlineField);
            this.BodyPanel.Controls.Add(this.TypeOfWorkField);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.AreaOfWorkLabel);
            this.BodyPanel.Controls.Add(this.WorkPicture);
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
            this.CancelButton.Location = new System.Drawing.Point(514, 348);
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
            this.AddButton.Location = new System.Drawing.Point(327, 348);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            // TypeOfWorkField
            // 
            this.TypeOfWorkField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeOfWorkField.DefaultText = "";
            this.TypeOfWorkField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TypeOfWorkField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TypeOfWorkField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeOfWorkField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeOfWorkField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeOfWorkField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TypeOfWorkField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeOfWorkField.Location = new System.Drawing.Point(145, 82);
            this.TypeOfWorkField.Name = "TypeOfWorkField";
            this.TypeOfWorkField.PasswordChar = '\0';
            this.TypeOfWorkField.PlaceholderText = "Вид работы";
            this.TypeOfWorkField.SelectedText = "";
            this.TypeOfWorkField.Size = new System.Drawing.Size(187, 21);
            this.TypeOfWorkField.TabIndex = 29;
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
            this.DeadlineField.Location = new System.Drawing.Point(145, 193);
            this.DeadlineField.Name = "DeadlineField";
            this.DeadlineField.PasswordChar = '\0';
            this.DeadlineField.PlaceholderText = "Срок выполнения";
            this.DeadlineField.SelectedText = "";
            this.DeadlineField.Size = new System.Drawing.Size(187, 21);
            this.DeadlineField.TabIndex = 30;
            // 
            // CostOfWorkField
            // 
            this.CostOfWorkField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CostOfWorkField.DefaultText = "";
            this.CostOfWorkField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CostOfWorkField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CostOfWorkField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostOfWorkField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostOfWorkField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostOfWorkField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CostOfWorkField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostOfWorkField.Location = new System.Drawing.Point(145, 147);
            this.CostOfWorkField.Name = "CostOfWorkField";
            this.CostOfWorkField.PasswordChar = '\0';
            this.CostOfWorkField.PlaceholderText = "Стоимость работы";
            this.CostOfWorkField.SelectedText = "";
            this.CostOfWorkField.Size = new System.Drawing.Size(187, 21);
            this.CostOfWorkField.TabIndex = 31;
            // 
            // ApprovalDateField
            // 
            this.ApprovalDateField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApprovalDateField.DefaultText = "";
            this.ApprovalDateField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ApprovalDateField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ApprovalDateField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ApprovalDateField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ApprovalDateField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApprovalDateField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ApprovalDateField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApprovalDateField.Location = new System.Drawing.Point(145, 265);
            this.ApprovalDateField.Name = "ApprovalDateField";
            this.ApprovalDateField.PasswordChar = '\0';
            this.ApprovalDateField.PlaceholderText = "Дата заявления";
            this.ApprovalDateField.SelectedText = "";
            this.ApprovalDateField.Size = new System.Drawing.Size(187, 21);
            this.ApprovalDateField.TabIndex = 32;
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
        private System.Windows.Forms.Label AreaOfWorkLabel;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2TextBox ApprovalDateField;
        private Guna.UI2.WinForms.Guna2TextBox CostOfWorkField;
        private Guna.UI2.WinForms.Guna2TextBox DeadlineField;
        private Guna.UI2.WinForms.Guna2TextBox TypeOfWorkField;
    }
}