namespace myProject
{
    partial class UserForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            profile_btn = new Guna.UI2.WinForms.Guna2Button();
            prts_btn = new Guna.UI2.WinForms.Guna2Button();
            doctors_btn = new Guna.UI2.WinForms.Guna2Button();
            dgv = new DataGridView();
            adopt_btn = new Guna.UI2.WinForms.Guna2Button();
            dgv_medical = new DataGridView();
            medical_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgv_doctors = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_medical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // profile_btn
            // 
            profile_btn.CustomizableEdges = customizableEdges1;
            profile_btn.DisabledState.BorderColor = Color.DarkGray;
            profile_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            profile_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            profile_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            profile_btn.Font = new Font("Segoe UI", 9F);
            profile_btn.ForeColor = Color.White;
            profile_btn.Location = new Point(23, 65);
            profile_btn.Name = "profile_btn";
            profile_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            profile_btn.Size = new Size(225, 56);
            profile_btn.TabIndex = 0;
            profile_btn.Text = "profile";
            profile_btn.Click += profile_btn_Click;
            // 
            // prts_btn
            // 
            prts_btn.CustomizableEdges = customizableEdges3;
            prts_btn.DisabledState.BorderColor = Color.DarkGray;
            prts_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            prts_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            prts_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            prts_btn.Font = new Font("Segoe UI", 9F);
            prts_btn.ForeColor = Color.White;
            prts_btn.Location = new Point(23, 171);
            prts_btn.Name = "prts_btn";
            prts_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            prts_btn.Size = new Size(225, 56);
            prts_btn.TabIndex = 1;
            prts_btn.Text = "pets";
            prts_btn.Click += prts_btn_Click;
            // 
            // doctors_btn
            // 
            doctors_btn.CustomizableEdges = customizableEdges5;
            doctors_btn.DisabledState.BorderColor = Color.DarkGray;
            doctors_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            doctors_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            doctors_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            doctors_btn.Font = new Font("Segoe UI", 9F);
            doctors_btn.ForeColor = Color.White;
            doctors_btn.Location = new Point(23, 271);
            doctors_btn.Name = "doctors_btn";
            doctors_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            doctors_btn.Size = new Size(225, 56);
            doctors_btn.TabIndex = 2;
            doctors_btn.Text = "doctors";
            doctors_btn.Click += doctors_btn_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(311, 65);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(680, 262);
            dgv.TabIndex = 3;
            dgv.RowHeaderMouseClick += dgv_RowHeaderMouseClick;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // adopt_btn
            // 
            adopt_btn.CustomizableEdges = customizableEdges7;
            adopt_btn.DisabledState.BorderColor = Color.DarkGray;
            adopt_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            adopt_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adopt_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adopt_btn.Font = new Font("Segoe UI", 9F);
            adopt_btn.ForeColor = Color.White;
            adopt_btn.Location = new Point(570, 499);
            adopt_btn.Name = "adopt_btn";
            adopt_btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            adopt_btn.Size = new Size(180, 56);
            adopt_btn.TabIndex = 4;
            adopt_btn.Text = "requist to adoption";
            adopt_btn.Click += adopt_btn_Click;
            // 
            // dgv_medical
            // 
            dgv_medical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_medical.Location = new Point(311, 378);
            dgv_medical.Name = "dgv_medical";
            dgv_medical.RowHeadersWidth = 51;
            dgv_medical.Size = new Size(680, 106);
            dgv_medical.TabIndex = 5;
            // 
            // medical_lbl
            // 
            medical_lbl.BackColor = Color.Transparent;
            medical_lbl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            medical_lbl.Location = new Point(579, 339);
            medical_lbl.Name = "medical_lbl";
            medical_lbl.Size = new Size(201, 33);
            medical_lbl.TabIndex = 6;
            medical_lbl.Text = "Pet Medical Record";
            // 
            // dgv_doctors
            // 
            dgv_doctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_doctors.Location = new Point(311, 65);
            dgv_doctors.Name = "dgv_doctors";
            dgv_doctors.RowHeadersWidth = 51;
            dgv_doctors.Size = new Size(680, 262);
            dgv_doctors.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(23, 520);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 567);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_doctors);
            Controls.Add(medical_lbl);
            Controls.Add(dgv_medical);
            Controls.Add(adopt_btn);
            Controls.Add(dgv);
            Controls.Add(doctors_btn);
            Controls.Add(prts_btn);
            Controls.Add(profile_btn);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_medical).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button profile_btn;
        private Guna.UI2.WinForms.Guna2Button prts_btn;
        private Guna.UI2.WinForms.Guna2Button doctors_btn;
        private DataGridView dgv;
        private Guna.UI2.WinForms.Guna2Button adopt_btn;
        private DataGridView dgv_medical;
        private Guna.UI2.WinForms.Guna2HtmlLabel medical_lbl;
        private DataGridView dgv_doctors;
        private PictureBox pictureBox1;
    }
}