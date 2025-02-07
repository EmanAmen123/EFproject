using myProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myProject
{
    public partial class Form1 : Form
    {
        MyContext db;
        UserForm user;
        public Form1()
        {
            db = new MyContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            string email = email_inp.Text;
            string password = password_inp.Text;
            if (email != "" && password != "")
            {
                Members member = db.Members.Where(n => n.Email == email && n.Password == password).SingleOrDefault();
                if (member != null)
                {
                    if (member.isDeleted != true)
                    {
                        if (member.Role == "user" || member.Role == "doctor")
                        {
                            UserForm user = new UserForm(member.Id);
                        
                            user.Show();
                            //this.Hide();

                        }
                        else if (member.Role == "admin")
                        {
                            adminform admin = new adminform();
                            admin.Show();
                            //this.Hide();
                        }
                        //else if (member.Role == "doctor")
                        //{
                        //    doctorForm doctor = new doctorForm();
                        //    doctor.Show();
                        //    //this.Hide();
                        //}
                        else
                            MessageBox.Show("try again");
                    }
                    else
                        MessageBox.Show("Sorry , this account was deleted");


                }
                else
                    MessageBox.Show("email or password is not valid");
            }
            else
                MessageBox.Show("email & password are required");
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            //this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                password_inp.PasswordChar = '\0';

            else
                password_inp.PasswordChar = '*';
        }
    }
}
