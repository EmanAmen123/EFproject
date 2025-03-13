using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myProject.Models;
using BCrypt.Net;

namespace myProject
{
    public partial class register : Form
    {
        MyContext db;
        public register()
        {
            db = new MyContext();
            InitializeComponent();
        }
        private void oldpass_lbl_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (fname_inp.Text != "" && lname_inp.Text != "" && address_inp.Text != "" && age_inp.Value != 0 && email_inp.Text != ""
                && pass_input.Text != "" && confirmpass_inp.Text != "" && phone_inp.Text != "")
            {
                if (pass_input.Text == confirmpass_inp.Text)
                {
                    var users = db.Members.Select(n => n);   //select or to list?
                    if (users.Any(n => n.Email == email_inp.Text))
                        MessageBox.Show("email is already exist");
                    else if (users.Any(n => n.PhoneNumber == int.Parse(phone_inp.Text)))
                        MessageBox.Show("phone number is already exist");
                    else
                    {
                        Members user = new Members()
                        {
                            F_name = fname_inp.Text,
                            L_name = lname_inp.Text,
                            Email = email_inp.Text,
                            Password = BCrypt.Net.BCrypt.HashPassword(pass_input.Text),
                            Age = (int)age_inp.Value,
                            Address = address_inp.Text,
                            Role = "user",
                            PhoneNumber = int.Parse(phone_inp.Text)

                        };
                        db.Members.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("registered successfuly.");
                        Form1 signin = new Form1();
                        signin.Show();

                        //this.Hide();

                    }

                }
                else
                    MessageBox.Show("password and confirm password are not matched");


            }
            else
                MessageBox.Show("all inputs are required..");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pass_input.PasswordChar = '\0';

            else
                pass_input.PasswordChar = '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                confirmpass_inp.PasswordChar = '\0';

            else
                confirmpass_inp.PasswordChar = '*';
        }
    }
}
