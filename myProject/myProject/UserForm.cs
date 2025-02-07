using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using myProject.Models;

namespace myProject
{
    public partial class UserForm : Form
    {
        MyContext db;
        int user_id;
        int pet_or_doc_id;
        int id;
        public UserForm(int id)
        {
            db = new MyContext();
            user_id = id;
            InitializeComponent();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            userProfile profile = new userProfile(user_id);
            this.Close();
            profile.Show();

        }

        private void prts_btn_Click(object sender, EventArgs e)
        {
            dgv_doctors.Visible = false;
            dgv.DataSource = db.Pets.Where(n => n.AdoptionStatus == false).ToList();
            dgv.Columns[0].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Visible = true;
        }

        private void doctors_btn_Click(object sender, EventArgs e)
        {
            dgv_doctors.Visible = true;
            dgv.Visible = false;
            dgv_doctors.DataSource = db.Members.Where(n => n.Role == "doctor").ToList();
            adopt_btn.Visible = false;
            medical_lbl.Visible = false;
            dgv_medical.Visible = false;
            adopt_btn.Visible = false;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dgv.Visible = false;
            adopt_btn.Visible = false;
            medical_lbl.Visible = false;
            dgv_medical.Visible = false;
            dgv_doctors.Visible = false;
        }



        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pet_or_doc_id = (int)dgv.Rows[0].Cells[0].Value;
            //adopt_btn.Visible = true;

        }

        private void adopt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Adoptions request = new Adoptions()
                {
                    AcceptRequesr = false,
                    RequestDate = DateTime.Today,
                    petId = pet_or_doc_id,
                    adopterId = user_id
                };
                db.Adoptions.Add(request);
                db.SaveChanges();
                MessageBox.Show("Your request has been sent,Wait for the admin's response");
            }
            catch
            {
                MessageBox.Show("please try again"); //////
            }

        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pet_or_doc_id = (int)dgv.Rows[0].Cells[0].Value;
            //if (dgv.Rows[0].Cells.Count <=9)
            //{
            medical_lbl.Visible = true;
            dgv_medical.Visible = true;
            adopt_btn.Visible = true;

            //}

            id = (int)dgv.SelectedRows[0].Cells[0].Value;
            Pets pet = db.Pets.Where(n => n.Id == id).SingleOrDefault();

            if (pet != null)
            {
                dgv_medical.DataSource = db.Medical.Where(n => n.petId == id).Select(
                    n => new
                    {
                        n.Date,
                        n.Description,
                        n.NextAppointment,
                        n.Vaccine_name,
                        n.VetName,

                    }
                    ).ToList();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }
    }
}
