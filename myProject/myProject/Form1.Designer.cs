namespace myProject
{
    partial class Form1
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
            email_inp = new Guna.UI2.WinForms.Guna2TextBox();
            password_inp = new Guna.UI2.WinForms.Guna2TextBox();
            signin_btn = new Guna.UI2.WinForms.Guna2Button();
            signup_btn = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // email_inp
            // 
            email_inp.CustomizableEdges = customizableEdges1;
            email_inp.DefaultText = "";
            email_inp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            email_inp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            email_inp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            email_inp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            email_inp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            email_inp.Font = new Font("Segoe UI", 9F);
            email_inp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            email_inp.Location = new Point(416, 54);
            email_inp.Margin = new Padding(3, 4, 3, 4);
            email_inp.Name = "email_inp";
            email_inp.PasswordChar = '\0';
            email_inp.PlaceholderText = "";
            email_inp.SelectedText = "";
            email_inp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            email_inp.Size = new Size(286, 53);
            email_inp.TabIndex = 0;
            // 
            // password_inp
            // 
            password_inp.CustomizableEdges = customizableEdges3;
            password_inp.DefaultText = "";
            password_inp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password_inp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password_inp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password_inp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password_inp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password_inp.Font = new Font("Segoe UI", 9F);
            password_inp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password_inp.Location = new Point(416, 161);
            password_inp.Margin = new Padding(3, 4, 3, 4);
            password_inp.Name = "password_inp";
            password_inp.PasswordChar = '*';
            password_inp.PlaceholderText = "";
            password_inp.SelectedText = "";
            password_inp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            password_inp.Size = new Size(286, 44);
            password_inp.TabIndex = 1;
            // 
            // signin_btn
            // 
            signin_btn.CustomizableEdges = customizableEdges5;
            signin_btn.DisabledState.BorderColor = Color.DarkGray;
            signin_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            signin_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signin_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signin_btn.Font = new Font("Segoe UI", 9F);
            signin_btn.ForeColor = Color.White;
            signin_btn.Location = new Point(456, 261);
            signin_btn.Name = "signin_btn";
            signin_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            signin_btn.Size = new Size(225, 56);
            signin_btn.TabIndex = 2;
            signin_btn.Text = "sign in";
            signin_btn.Click += signin_btn_Click;
            // 
            // signup_btn
            // 
            signup_btn.CustomizableEdges = customizableEdges7;
            signup_btn.DisabledState.BorderColor = Color.DarkGray;
            signup_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            signup_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signup_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signup_btn.Font = new Font("Segoe UI", 9F);
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(184, 261);
            signup_btn.Name = "signup_btn";
            signup_btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            signup_btn.Size = new Size(225, 56);
            signup_btn.TabIndex = 3;
            signup_btn.Text = "signup";
            signup_btn.Click += signup_btn_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(254, 76);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(40, 22);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Email";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(254, 178);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(65, 22);
            guna2HtmlLabel2.TabIndex = 5;
            guna2HtmlLabel2.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(570, 212);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(signup_btn);
            Controls.Add(signin_btn);
            Controls.Add(password_inp);
            Controls.Add(email_inp);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox email_inp;
        private Guna.UI2.WinForms.Guna2TextBox password_inp;
        private Guna.UI2.WinForms.Guna2Button signin_btn;
        private Guna.UI2.WinForms.Guna2Button signup_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private CheckBox checkBox1;
    }
}