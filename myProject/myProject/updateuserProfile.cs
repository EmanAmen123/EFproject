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
using BCrypt.Net;

namespace myProject
{
    public partial class updateuserProfile : Form
    {
        MyContext db;
        int user_id;
        Members user;
        public updateuserProfile(int id)
        {
            user_id = id;
            db = new MyContext();
            InitializeComponent();
        }
        public void DisplayprofileInputs(bool display)
        {
            fname_inp.Visible = display;
            lname_inp.Visible = display;
            phone_input.Visible = display;
            address_inp.Visible = display;
            age_inp.Visible = display;

            fb_lbl.Visible = display;
            ln_lbl.Visible = display;
            adrs_lbl.Visible = display;
            age_lbl.Visible = display;
            phone_lbl.Visible = display;

            edit_btn.Visible = display;
            changeemail_btn.Visible = display;
            changepass_btn.Visible = display;
        }
        public void DisplayEmailinputs(bool display)
        {
            email.Visible = display;
            email_inp.Visible = display;
            newpass_lbl.Visible = display;
            oldoldpass_inp.Visible = display;
            checkBox2.Visible = display;
            change_empass.Visible = display;
        }
        public void DisplayPassInputs(bool display)
        {
            oldpass_lbl.Visible = display;
            oldpass_inp.Visible = display; //old
            checkBox1.Visible = display;
            nwpass_lbl.Visible = display;
            oldoldpass_inp.Visible = display;  //new
            checkBox2.Visible = display;
            change_pass.Visible = display;
            
        }
        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void userProfile_Load(object sender, EventArgs e)
        {
            DisplayEmailinputs(false);
            DisplayPassInputs(false);
            DisplayprofileInputs(true);

            user = db.Members.Where(n => n.Id == user_id).SingleOrDefault();
            if (user != null)
            {
                fname_inp.Text = user.F_name;
                lname_inp.Text = user.L_name;
                address_inp.Text = user.Address;
                age_inp.Value = (int)user.Age;
                phone_input.Text = user.PhoneNumber.ToString();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (fname_inp.Text != "" && lname_inp.Text != "" && address_inp.Text != "" && age_inp.Value != 0 && phone_input.Text != "")
            {
                user.F_name = fname_inp.Text;
                user.L_name = lname_inp.Text;
                user.Address = address_inp.Text;
                user.Age = (int)age_inp.Value;
                user.PhoneNumber = int.Parse(phone_input.Text);
                db.SaveChanges();
                MessageBox.Show("profile updated");
            }
            else
                MessageBox.Show("all inputs are required");

        }

        private void changeemail_btn_Click_1(object sender, EventArgs e)
        {
            DisplayprofileInputs(false);
            DisplayPassInputs(false);
            DisplayEmailinputs(true);

            email_inp.Text = user.Email;

        }

        private void change_empass_Click(object sender, EventArgs e)
        {
            if (email_inp.Text != "")
            {
                if (oldoldpass_inp.Text != "")
                {
                    if (oldoldpass_inp.Text == user.Password)
                    {
                        user.Email = email_inp.Text;
                        db.SaveChanges();
                        MessageBox.Show("E-mail changed Successfully");
                        email_inp.Text = user.Email;
                        oldoldpass_inp.Text = "";
                    }
                    else
                        MessageBox.Show("Password you entered is incorrect");
                }
                else
                    MessageBox.Show("Password is required..");
            }

        }

        private void changepass_btn_Click(object sender, EventArgs e)
        {
            DisplayprofileInputs(false);
            DisplayEmailinputs(false);
            DisplayPassInputs(true);

        }
        private void change_pass_Click(object sender, EventArgs e)
        {
            if (oldpass_inp.Text != "")
            {
                if (oldoldpass_inp.Text != "")
                {
                    if (oldpass_inp.Text == user.Password)
                    {
                        user.Password = BCrypt.Net.BCrypt.HashPassword( oldoldpass_inp.Text);
                        db.SaveChanges();
                        MessageBox.Show("Passowrd changed Successfully");
                        oldpass_inp.Text = oldoldpass_inp.Text = "";
                    }
                    else
                        MessageBox.Show("Old Password is incorrect");
                }
                else
                    MessageBox.Show("Please Enter The New Password.");
            }
            else
                MessageBox.Show("Please Enter Your Current Password.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                oldpass_inp.PasswordChar = '\0';

            else
                oldpass_inp.PasswordChar = '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                oldoldpass_inp.PasswordChar = '\0';

            else
                oldoldpass_inp.PasswordChar = '*';
        }
    }
}
