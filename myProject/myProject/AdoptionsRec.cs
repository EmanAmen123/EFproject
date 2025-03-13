using Microsoft.EntityFrameworkCore;
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
    public partial class AdoptionsRec : Form
    {
        MyContext db;
        int pet_id;
        int adopter_id;
        int adoption_id;
        string request_value;
        public AdoptionsRec()
        {
            db = new MyContext();
            InitializeComponent();
        }
        public void display(bool dis)
        {
            guna2HtmlLabel2.Visible = dis;
            guna2HtmlLabel3.Visible = dis;
            guna2HtmlLabel4.Visible = dis;
            dgv_pet.Visible = dis;
            dgv_medical.Visible = dis;
            dgv_adopter.Visible = dis;
            delete_btn.Visible = dis;
            accept_btn.Visible = dis;
        }
        private void AdoptionsRec_Load(object sender, EventArgs e)
        {
            display(false);
            delete_btn.Visible = false;
            accept_btn.Visible = false;
        
            dgv_records.DataSource = db.Adoptions.Include(n => n.AdoptedPet).Include(n => n.Adopter).Select(
                n => new
                {
                    n.AdoptionID,
                    Acsept_request = n.AcceptRequesr == false ? "false" : "true",
                    n.RequestDate,
                    AccepetDate = n.AdoptionDate != null ? n.AdoptionDate.ToString() : "not accepted yet",
                    n.petId,
                    n.adopterId,
                    adopterName = n.Adopter.F_name + " " + n.Adopter.L_name

                }
                ).ToList();

        }
        private void dgv_records_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            accept_btn.Visible = true;
            adoption_id = (int)dgv_records.SelectedRows[0].Cells[0].Value;
            request_value = dgv_records.SelectedRows[0].Cells[1].Value.ToString();

            pet_id = (int)dgv_records.SelectedRows[0].Cells["petId"].Value;
            adopter_id = (int)dgv_records.SelectedRows[0].Cells["adopterId"].Value;
            display(true);
            //dgv_medical.Columns[6].Visible = false;
            delete_btn.Visible = true;
            dgv_pet.DataSource = db.Pets.Where(n => n.Id == pet_id).Select(n => new
            {
                n.Id,
                n.Name,
                n.Age,
                n.Breed,
                n.Species,
                n.Gender,
                n.Color
            }).ToList();
            dgv_medical.DataSource = db.Medical.Where(n => n.petId == pet_id).ToList();
            dgv_adopter.DataSource = db.Members.Where(n => n.Id == adopter_id).ToList();
            //if (dgv_adopter.SelectedRows[0].Cells[1].Value == "false") /////not working
            //{
            //    accept_btn.Visible = true;
            //}

        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var adoption = db.Adoptions.Where(n => n.AdoptionID == adoption_id).SingleOrDefault();
                adoption.AcceptRequesr = true;
                Pets pet = db.Pets.Where(n => n.Id == pet_id).SingleOrDefault();
                pet.AdoptionStatus = true;
                pet.AdopterId = adopter_id;
                adoption.AdoptionDate = DateTime.Today;
                db.SaveChanges();
                dgv_records.DataSource = db.Adoptions.Include(n => n.AdoptedPet).Include(n => n.Adopter).Select(
               n => new
               {
                   n.AdoptionID,
                   Acsept_request = n.AcceptRequesr == false ? "false" : "true",
                   n.RequestDate,
                   AccepetDate = n.AdoptionDate != null ? n.AdoptionDate.ToString() : "not accepted yet",
                   n.petId,
                   n.adopterId,
                   adopterName = n.Adopter.F_name + " " + n.Adopter.L_name

               }
               ).ToList();

                MessageBox.Show("Accepted");

            }
            catch
            {
                MessageBox.Show("try again");
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Adoptions adoption = db.Adoptions.Where(n => n.AdoptionID == adoption_id).SingleOrDefault();
                db.Adoptions.Remove(adoption);
                db.SaveChanges();
                dgv_records.DataSource = db.Adoptions.Include(n => n.AdoptedPet).Include(n => n.Adopter).Select(
               n => new
               {
                   n.AdoptionID,
                   Acsept_request = n.AcceptRequesr == false ? "false" : "true",
                   n.RequestDate,
                   AccepetDate = n.AdoptionDate != null ? n.AdoptionDate.ToString() : "not accepted yet",
                   n.petId,
                   n.adopterId,
                   adopterName = n.Adopter.F_name + " " + n.Adopter.L_name

               }
               ).ToList();
                MessageBox.Show("Record Deleted");

            }
            catch
            {
                MessageBox.Show("something wrong , try again");

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminform admin = new adminform();
            this.Close();
            admin.Show();
        }
    }
}
