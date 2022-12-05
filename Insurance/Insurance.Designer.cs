namespace Course_work
{
    partial class Insurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insurance));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.InsuranceLabel = new System.Windows.Forms.Label();
            this.InsurancePicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.FIOField = new Guna.UI2.WinForms.Guna2TextBox();
            this.InsurancePolicyField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateOfInsuranceField = new Guna.UI2.WinForms.Guna2TextBox();
            this.InsuranceCompanyField = new Guna.UI2.WinForms.Guna2TextBox();
            this.InsuranceTypeField = new Guna.UI2.WinForms.Guna2TextBox();
            this.TermOfInsuranceField = new Guna.UI2.WinForms.Guna2TextBox();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsurancePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackgroundImage = global::Course_work.Properties.Resources.Main_Background;
            this.BodyPanel.Controls.Add(this.TermOfInsuranceField);
            this.BodyPanel.Controls.Add(this.InsuranceTypeField);
            this.BodyPanel.Controls.Add(this.InsuranceCompanyField);
            this.BodyPanel.Controls.Add(this.DateOfInsuranceField);
            this.BodyPanel.Controls.Add(this.InsurancePolicyField);
            this.BodyPanel.Controls.Add(this.FIOField);
            this.BodyPanel.Controls.Add(this.CancelButton);
            this.BodyPanel.Controls.Add(this.AddButton);
            this.BodyPanel.Controls.Add(this.InsuranceLabel);
            this.BodyPanel.Controls.Add(this.InsurancePicture);
            this.BodyPanel.Controls.Add(this.LeftPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(834, 461);
            this.BodyPanel.TabIndex = 5;
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
            this.CancelButton.Location = new System.Drawing.Point(641, 369);
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
            this.AddButton.Location = new System.Drawing.Point(505, 369);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InsuranceLabel
            // 
            this.InsuranceLabel.AutoSize = true;
            this.InsuranceLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsuranceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsuranceLabel.ForeColor = System.Drawing.Color.White;
            this.InsuranceLabel.Location = new System.Drawing.Point(122, 19);
            this.InsuranceLabel.Name = "InsuranceLabel";
            this.InsuranceLabel.Size = new System.Drawing.Size(529, 19);
            this.InsuranceLabel.TabIndex = 23;
            this.InsuranceLabel.Text = "Для внесения данных в таблицу заполните следующие поля:";
            this.InsuranceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InsurancePicture
            // 
            this.InsurancePicture.BackColor = System.Drawing.Color.Transparent;
            this.InsurancePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsurancePicture.ErrorImage = null;
            this.InsurancePicture.Image = global::Course_work.Properties.Resources.Insurance;
            this.InsurancePicture.InitialImage = null;
            this.InsurancePicture.Location = new System.Drawing.Point(505, 44);
            this.InsurancePicture.Name = "InsurancePicture";
            this.InsurancePicture.Size = new System.Drawing.Size(256, 256);
            this.InsurancePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsurancePicture.TabIndex = 3;
            this.InsurancePicture.TabStop = false;
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
            this.FIOField.Location = new System.Drawing.Point(527, 60);
            this.FIOField.Name = "FIOField";
            this.FIOField.PasswordChar = '\0';
            this.FIOField.PlaceholderText = "ФИО";
            this.FIOField.SelectedText = "";
            this.FIOField.Size = new System.Drawing.Size(187, 21);
            this.FIOField.TabIndex = 31;
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
            this.InsurancePolicyField.Location = new System.Drawing.Point(527, 109);
            this.InsurancePolicyField.Name = "InsurancePolicyField";
            this.InsurancePolicyField.PasswordChar = '\0';
            this.InsurancePolicyField.PlaceholderText = "Страховой  полис";
            this.InsurancePolicyField.SelectedText = "";
            this.InsurancePolicyField.Size = new System.Drawing.Size(187, 21);
            this.InsurancePolicyField.TabIndex = 32;
            // 
            // DateOfInsuranceField
            // 
            this.DateOfInsuranceField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateOfInsuranceField.DefaultText = "";
            this.DateOfInsuranceField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DateOfInsuranceField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DateOfInsuranceField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateOfInsuranceField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateOfInsuranceField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateOfInsuranceField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateOfInsuranceField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateOfInsuranceField.Location = new System.Drawing.Point(473, 155);
            this.DateOfInsuranceField.Name = "DateOfInsuranceField";
            this.DateOfInsuranceField.PasswordChar = '\0';
            this.DateOfInsuranceField.PlaceholderText = "Дата страхования";
            this.DateOfInsuranceField.SelectedText = "";
            this.DateOfInsuranceField.Size = new System.Drawing.Size(187, 21);
            this.DateOfInsuranceField.TabIndex = 33;
            // 
            // InsuranceCompanyField
            // 
            this.InsuranceCompanyField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InsuranceCompanyField.DefaultText = "";
            this.InsuranceCompanyField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InsuranceCompanyField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InsuranceCompanyField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsuranceCompanyField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsuranceCompanyField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsuranceCompanyField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InsuranceCompanyField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsuranceCompanyField.Location = new System.Drawing.Point(536, 220);
            this.InsuranceCompanyField.Name = "InsuranceCompanyField";
            this.InsuranceCompanyField.PasswordChar = '\0';
            this.InsuranceCompanyField.PlaceholderText = "Страховая компания";
            this.InsuranceCompanyField.SelectedText = "";
            this.InsuranceCompanyField.Size = new System.Drawing.Size(187, 21);
            this.InsuranceCompanyField.TabIndex = 34;
            // 
            // InsuranceTypeField
            // 
            this.InsuranceTypeField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InsuranceTypeField.DefaultText = "";
            this.InsuranceTypeField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InsuranceTypeField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InsuranceTypeField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsuranceTypeField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InsuranceTypeField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsuranceTypeField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InsuranceTypeField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InsuranceTypeField.Location = new System.Drawing.Point(527, 257);
            this.InsuranceTypeField.Name = "InsuranceTypeField";
            this.InsuranceTypeField.PasswordChar = '\0';
            this.InsuranceTypeField.PlaceholderText = "Вид страхования";
            this.InsuranceTypeField.SelectedText = "";
            this.InsuranceTypeField.Size = new System.Drawing.Size(187, 21);
            this.InsuranceTypeField.TabIndex = 35;
            // 
            // TermOfInsuranceField
            // 
            this.TermOfInsuranceField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TermOfInsuranceField.DefaultText = "";
            this.TermOfInsuranceField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TermOfInsuranceField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TermOfInsuranceField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TermOfInsuranceField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TermOfInsuranceField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TermOfInsuranceField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TermOfInsuranceField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TermOfInsuranceField.Location = new System.Drawing.Point(505, 306);
            this.TermOfInsuranceField.Name = "TermOfInsuranceField";
            this.TermOfInsuranceField.PasswordChar = '\0';
            this.TermOfInsuranceField.PlaceholderText = "Срок страхования";
            this.TermOfInsuranceField.SelectedText = "";
            this.TermOfInsuranceField.Size = new System.Drawing.Size(187, 21);
            this.TermOfInsuranceField.TabIndex = 36;
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.BodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insurance";
            this.Text = "Insurance";
            this.Load += new System.EventHandler(this.Insurance_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsurancePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox InsurancePicture;
        private System.Windows.Forms.Label InsuranceLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2TextBox TermOfInsuranceField;
        private Guna.UI2.WinForms.Guna2TextBox InsuranceTypeField;
        private Guna.UI2.WinForms.Guna2TextBox InsuranceCompanyField;
        private Guna.UI2.WinForms.Guna2TextBox DateOfInsuranceField;
        private Guna.UI2.WinForms.Guna2TextBox InsurancePolicyField;
        private Guna.UI2.WinForms.Guna2TextBox FIOField;
    }
}