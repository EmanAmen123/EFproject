namespace myProject
{
    partial class adminform
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
            adoptions_btn = new Guna.UI2.WinForms.Guna2Button();
            pets_btn = new Guna.UI2.WinForms.Guna2Button();
            users_btn = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // adoptions_btn
            // 
            adoptions_btn.CustomizableEdges = customizableEdges1;
            adoptions_btn.DisabledState.BorderColor = Color.DarkGray;
            adoptions_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            adoptions_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adoptions_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adoptions_btn.Font = new Font("Segoe UI", 9F);
            adoptions_btn.ForeColor = Color.White;
            adoptions_btn.Location = new Point(263, 248);
            adoptions_btn.Name = "adoptions_btn";
            adoptions_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            adoptions_btn.Size = new Size(192, 56);
            adoptions_btn.TabIndex = 7;
            adoptions_btn.Text = "Adoptions";
            adoptions_btn.Click += adoptions_btn_Click;
            // 
            // pets_btn
            // 
            pets_btn.CustomizableEdges = customizableEdges3;
            pets_btn.DisabledState.BorderColor = Color.DarkGray;
            pets_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            pets_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            pets_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            pets_btn.Font = new Font("Segoe UI", 9F);
            pets_btn.ForeColor = Color.White;
            pets_btn.Location = new Point(263, 141);
            pets_btn.Name = "pets_btn";
            pets_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pets_btn.Size = new Size(196, 56);
            pets_btn.TabIndex = 6;
            pets_btn.Text = "pets";
            pets_btn.Click += pets_btn_Click;
            // 
            // users_btn
            // 
            users_btn.CustomizableEdges = customizableEdges5;
            users_btn.DisabledState.BorderColor = Color.DarkGray;
            users_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            users_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            users_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            users_btn.Font = new Font("Segoe UI", 9F);
            users_btn.ForeColor = Color.White;
            users_btn.Location = new Point(265, 45);
            users_btn.Name = "users_btn";
            users_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            users_btn.Size = new Size(194, 56);
            users_btn.TabIndex = 5;
            users_btn.Text = "users";
            users_btn.Click += users_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(23, 397);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 120;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // adminform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(adoptions_btn);
            Controls.Add(pets_btn);
            Controls.Add(users_btn);
            Name = "adminform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminform";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button adoptions_btn;
        private Guna.UI2.WinForms.Guna2Button pets_btn;
        private Guna.UI2.WinForms.Guna2Button users_btn;
        private PictureBox pictureBox1;
    }
}