namespace myProject
{
    partial class AdoptionsRec
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
            dgv_records = new DataGridView();
            dgv_pet = new DataGridView();
            dgv_adopter = new DataGridView();
            dgv_medical = new DataGridView();
            accept_btn = new Guna.UI2.WinForms.Guna2Button();
            delete_btn = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_records).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_pet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_adopter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_medical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_records
            // 
            dgv_records.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_records.Location = new Point(12, 77);
            dgv_records.Name = "dgv_records";
            dgv_records.RowHeadersWidth = 51;
            dgv_records.Size = new Size(631, 257);
            dgv_records.TabIndex = 0;
            dgv_records.RowHeaderMouseClick += dgv_records_RowHeaderMouseClick;
            // 
            // dgv_pet
            // 
            dgv_pet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pet.Location = new Point(679, 54);
            dgv_pet.Name = "dgv_pet";
            dgv_pet.RowHeadersWidth = 51;
            dgv_pet.Size = new Size(486, 91);
            dgv_pet.TabIndex = 1;
            // 
            // dgv_adopter
            // 
            dgv_adopter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adopter.Location = new Point(679, 355);
            dgv_adopter.Name = "dgv_adopter";
            dgv_adopter.RowHeadersWidth = 51;
            dgv_adopter.Size = new Size(486, 95);
            dgv_adopter.TabIndex = 2;
            // 
            // dgv_medical
            // 
            dgv_medical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_medical.Location = new Point(679, 190);
            dgv_medical.Name = "dgv_medical";
            dgv_medical.RowHeadersWidth = 51;
            dgv_medical.Size = new Size(486, 120);
            dgv_medical.TabIndex = 3;
            // 
            // accept_btn
            // 
            accept_btn.CustomizableEdges = customizableEdges1;
            accept_btn.DisabledState.BorderColor = Color.DarkGray;
            accept_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            accept_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            accept_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            accept_btn.Font = new Font("Segoe UI", 9F);
            accept_btn.ForeColor = Color.White;
            accept_btn.Location = new Point(111, 382);
            accept_btn.Name = "accept_btn";
            accept_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            accept_btn.Size = new Size(139, 56);
            accept_btn.TabIndex = 4;
            accept_btn.Text = "Accept Requist";
            accept_btn.Click += accept_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.CustomizableEdges = customizableEdges3;
            delete_btn.DisabledState.BorderColor = Color.DarkGray;
            delete_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            delete_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            delete_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            delete_btn.Font = new Font("Segoe UI", 9F);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(327, 382);
            delete_btn.Name = "delete_btn";
            delete_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            delete_btn.Size = new Size(136, 56);
            delete_btn.TabIndex = 5;
            delete_btn.Text = "Delete Record";
            delete_btn.Click += delete_btn_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(111, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(352, 56);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Adoptions Records";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(861, 15);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(84, 33);
            guna2HtmlLabel2.TabIndex = 7;
            guna2HtmlLabel2.Text = "Pet Info";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(818, 151);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(211, 33);
            guna2HtmlLabel3.TabIndex = 8;
            guna2HtmlLabel3.Text = "Pet Medical Records";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.Location = new Point(861, 316);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(133, 33);
            guna2HtmlLabel4.TabIndex = 9;
            guna2HtmlLabel4.Text = "Adopter Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(23, 486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 119;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdoptionsRec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 539);
            Controls.Add(pictureBox1);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(delete_btn);
            Controls.Add(accept_btn);
            Controls.Add(dgv_medical);
            Controls.Add(dgv_adopter);
            Controls.Add(dgv_pet);
            Controls.Add(dgv_records);
            Name = "AdoptionsRec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adoptions";
            Load += AdoptionsRec_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_records).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_pet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_adopter).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_medical).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_records;
        private DataGridView dgv_pet;
        private DataGridView dgv_adopter;
        private DataGridView dgv_medical;
        private Guna.UI2.WinForms.Guna2Button accept_btn;
        private Guna.UI2.WinForms.Guna2Button delete_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private PictureBox pictureBox1;
    }
}