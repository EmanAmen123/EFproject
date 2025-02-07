using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using myProject.Models;

namespace myProject
{
    public partial class adminUsers : Form
    {
        MyContext db;
        int id;
        Members user;
        public adminUsers()
        {
            db = new MyContext();
            InitializeComponent();

        }
        public void Display(bool display)
        {

            fname_inp.Visible = display;
            lname_inp.Visible = display;
            address_inp.Visible = display;
            age_inp.Visible = display;
            email_inp.Visible = display;
            phone_inp.Visible = display;
            pass_input.Visible = display;
            fb_lbl.Visible = display;
            ln_lbl.Visible = display;
            adrs_lbl.Visible = display;
            email_lbl.Visible = display;
            age_lbl.Visible = display;
            phone_lbl.Visible = display;
            newpass_lbl.Visible = display;
            saveadd_btn.Visible = display;
            rule_inp.Visible = display;
            rule_lbl.Visible = display;
            saveupdate_btn.Visible = display;
            //medical_lbl.Visible = false;
            //medical_inp.Visible = false;

        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            Display(true);
            update_btn.Visible = false;
            delete_btn.Visible = false;
            dgv.DataSource = db.Members.Where(n => n.isDeleted == false).ToList();
            dgv.Columns[0].Visible = false;
            dgv.Columns[9].Visible = false;

            add_btn.Visible = false;
            update_btn.Visible = false;
            delete_btn.Visible = false;
            saveupdate_btn.Visible = false;

        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            //Display(true);
            //dgv.DataSource = db.Members.Where(n => n.isDeleted == false).ToList();
            //dgv.Columns[0].Visible = false;
            //dgv.Columns[9].Visible = false;

            //add_btn.Visible = false;
            //update_btn.Visible = false;
            //delete_btn.Visible = false;
            //saveupdate_btn.Visible = false;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void saveadd_btn_Click(object sender, EventArgs e)
        {

            if (fname_inp.Text != "" && lname_inp.Text != "" && address_inp.Text != "" && age_inp.Value != 0 && email_inp.Text != ""
               && pass_input.Text != "" && phone_inp.Text != "")
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
                        Password = pass_input.Text,
                        Age = (int)age_inp.Value,
                        Address = address_inp.Text,
                        Role = rule_inp.Text,
                        PhoneNumber = int.Parse(phone_inp.Text)

                    };
                    db.Members.Add(user);
                    db.SaveChanges();
                    dgv.DataSource = db.Members.Where(n => n.isDeleted == false).ToList();
                    MessageBox.Show("user added successfuly.");
                    //Display(false);
                    update_btn.Visible = false;
                    delete_btn.Visible = false;

                }

            }
            else
                MessageBox.Show("all inputs are required");
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = (int)dgv.SelectedRows[0].Cells[0].Value;

                user = db.Members.Where(n => n.Id == id).SingleOrDefault();
                if (user != null)
                {
                    update_btn.Visible = true;
                    delete_btn.Visible = true;
                }

            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Display(false);
                update_btn.Visible = false;
                delete_btn.Visible = false;
                saveupdate_btn.Visible = true;
                rule_inp.Visible = true;
                rule_lbl.Visible = true;
                rule_inp.Text = user.Role;
            }
            catch
            {
                MessageBox.Show("error");
            }


        }

        private void saveupdate_btn_Click(object sender, EventArgs e) ////
        {
            try
            {
                user.Role = rule_inp.Text;
                db.SaveChanges();

                MessageBox.Show("updated Successfully");
                Display(true);
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //db.Members.Remove(user);
                    user.isDeleted = true;
                    db.SaveChanges();
                    dgv.DataSource = db.Members.Where(n => n.isDeleted == false).ToList();
                    MessageBox.Show("user deleted");
                    update_btn.Visible = false;
                    delete_btn.Visible = false;
                }
            }

        }

        private void pets_btn_Click(object sender, EventArgs e)
        {
            adminPets pets = new adminPets();
            pets.Show();
            //this.Hide();

        }


        private void saveupdate_btn_Click_1(object sender, EventArgs e)
        {
            user.Role = rule_inp.Text;
            db.SaveChanges();
            dgv.DataSource = db.Members.Where(n => n.isDeleted == false).ToList();
            //dgv.Columns[0].Visible = false;
            MessageBox.Show("updated successfully");
            rule_inp.Visible = false;
            rule_lbl.Visible = false;
            Display(true);
            saveupdate_btn.Visible = false;
        }

        private void adoptions_btn_Click(object sender, EventArgs e)
        {
            AdoptionsRec records = new AdoptionsRec();
            records.Show();
            //this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminform admin = new adminform();
            this.Close();
            admin.Show();
        }
    }

}
