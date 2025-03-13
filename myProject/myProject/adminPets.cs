using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myProject
{
    public partial class adminPets : Form
    {
        MyContext db;
        int id;
        Pets pet;
        int record_id;
        MedicalRecords record;
        public adminPets()
        {
            db = new MyContext();
            InitializeComponent();
        }
        public void DisplayPetInps(bool display)
        {
            name_inp.Visible = display;
            spieces_inp.Visible = display;
            breed_inp.Visible = display;
            petage_inp.Visible = display;
            petdiscr_inp.Visible = display;
            gender_inp.Visible = display;
            color_inp.Visible = display;
            petname_lbl.Visible = display;
            spieces_lbl.Visible = display;
            breed_lbl.Visible = display;
            colorpet_lbl.Visible = display;
            petage_lbl.Visible = display;
            genderpet_lbl.Visible = display;
            descpet_lbl.Visible = display;
            addpet_btn.Visible = display;
            vaccinelbl.Visible = display;
            vaccinename.Visible = display;
        }
        public void DisplayRecordInps(bool display)
        {
            daterecord_inp.Visible = display;
            recorddesc_inp.Visible = display;
            vetname_inp.Visible = display;
            nextdate_inp.Visible = display;
            saveaddrec_btn.Visible = display;
            guna2HtmlLabel1.Visible = display;

            recorddate_lbl.Visible = display;
            recdesc_inp.Visible = display;
            vetname_lbl.Visible = display;
            nextdate_lbl.Visible = display;
            vaccinelbl.Visible = display;
            vaccinename.Visible = display;
        }
        private void adminPets_Load(object sender, EventArgs e)
        {
            dgv_medical.Visible = false;
            addmedical_btn.Visible = false;
            delmedical_btn.Visible = false;
            updatemedical_btn.Visible = false;
            DisplayPetInps(true);
            DisplayRecordInps(false);
            dgv.DataSource = db.Pets.Include(n => n.Adopter).Include(n => n.Records).Select(n => new
            {
                n.Id,
                n.Name,
                n.Species,
                n.Breed,
                n.Gender,
                n.Color,
                n.Age,
                n.Description,
                AdoptionStatus = n.AdoptionStatus == false ? "false" : "true",
                AdopterName = n.Adopter != null ? n.Adopter.F_name + " " + n.Adopter.L_name : "No Adopter"
            })
            .ToList();
            dgv.Columns[0].Visible = false;
            //dgv.Columns[10].Visible = false;
            updatepet_btn.Visible = false;
            delete_btn.Visible = false;
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayPetInps(true);
            DisplayRecordInps(false);
            delmedical_btn.Visible = false;
            updatemedical_btn.Visible = false;
            id = (int)dgv.SelectedRows[0].Cells[0].Value;
            pet = db.Pets.Where(n => n.Id == id).SingleOrDefault();
            updatepet_btn.Visible = true;
            delete_btn.Visible = true;
            addpet_btn.Visible = false;
            if (pet != null)
            {
                name_inp.Text = pet.Name;
                spieces_inp.Text = pet.Species;
                breed_inp.Text = pet.Breed;
                petdiscr_inp.Text = pet.Description;
                gender_inp.Text = pet.Gender;
                color_inp.Text = pet.Color;
                petage_inp.Text = pet.Age;
                dgv_medical.Visible = true;
                addmedical_btn.Visible = true;
                dgv_medical.DataSource = db.Medical.Where(n => n.petId == id).Select(
                    n => new
                    {
                        n.Id,
                        n.Date,
                        n.Description,
                        n.NextAppointment,
                        n.Vaccine_name,
                        n.VetName,
                        n.petId
                    }
                    ).ToList();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this pet", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Pets.Remove(pet);
                db.SaveChanges();
                dgv.DataSource = db.Pets.Include(n => n.Adopter).Include(n => n.Records).Select(n => new
                {
                    n.Id,
                    n.Name,
                    n.Species,
                    n.Breed,
                    n.Gender,
                    n.Color,
                    n.Age,
                    n.Description,
                    AdoptionStatus = n.AdoptionStatus == false ? "false" : "true",
                    AdopterName = n.Adopter != null ? n.Adopter.F_name + " " + n.Adopter.L_name : "No Adopter"
                })
                   .ToList();
                name_inp.Text = spieces_inp.Text = breed_inp.Text = gender_inp.Text =
                color_inp.Text = petage_inp.Text = petdiscr_inp.Text = "";
                MessageBox.Show("pet deleted");
            }

        }

        private void addpet_btn_Click(object sender, EventArgs e)
        {
            if (name_inp.Text != "" && spieces_inp.Text != "" && breed_inp.Text != "" && gender_inp.Text != ""
            && color_inp.Text != "" && petage_inp.Text != "" && petdiscr_inp.Text != "")
            {

                Pets pet = new Pets()
                {
                    Name = name_inp.Text,
                    Species = spieces_inp.Text,
                    Description = petdiscr_inp.Text,
                    Breed = breed_inp.Text,
                    Gender = gender_inp.Text,
                    Color = color_inp.Text,
                    Age = petage_inp.Text,
                    //Records=medical_inp.Text
                    DateAdded = DateTime.Today,
                    AdoptionStatus = false,

                };
                db.Pets.Add(pet);
                db.SaveChanges();
                dgv.DataSource = db.Pets.Include(n => n.Adopter).Select(n => new
                {
                    n.Id,
                    n.Name,
                    n.Species,
                    n.Breed,
                    n.Gender,
                    n.Color,
                    n.Age,
                    n.Description,
                    AdoptionStatus = n.AdoptionStatus == false ? "false" : "true",
                    AdopterName = n.Adopter != null ? n.Adopter.F_name + " " + n.Adopter.L_name : "No Adopter"
                })
                .ToList();
                MessageBox.Show("Pet added successfuly.");
                name_inp.Text = spieces_inp.Text = breed_inp.Text = gender_inp.Text =
              color_inp.Text = petage_inp.Text = petdiscr_inp.Text = "";
                //Display(false);
                delete_btn.Visible = false;

            }
            else
                MessageBox.Show("all inputs are required");
        }

        private void updatepet_btn_Click(object sender, EventArgs e)
        {
            if (name_inp.Text != "" && spieces_inp.Text != "" && breed_inp.Text != "" && gender_inp.Text != ""
          && color_inp.Text != "" && petage_inp.Text != "" && petdiscr_inp.Text != "")
            {
                pet.Name = name_inp.Text;
                pet.Species = spieces_inp.Text;
                pet.Description = petdiscr_inp.Text;
                pet.Breed = breed_inp.Text;
                pet.Gender = gender_inp.Text;
                pet.Color = color_inp.Text;
                pet.Age = petage_inp.Text;
                //Records=medical_inp.Text
                pet.DateAdded = daterecord_inp.Value;
                pet.AdoptionStatus = false;
                db.SaveChanges();
                dgv.DataSource = db.Pets.Include(n => n.Adopter).Select(n => new
                {
                    n.Id,
                    n.Name,
                    n.Species,
                    n.Breed,
                    n.Gender,
                    n.Color,
                    n.Age,
                    n.Description,
                    AdoptionStatus = n.AdoptionStatus == false ? "false" : "true",
                    AdopterName = n.Adopter != null ? n.Adopter.F_name + " " + n.Adopter.L_name : "No Adopter"
                })
                .ToList();
                MessageBox.Show("Pet added successfuly.");
                name_inp.Text = spieces_inp.Text = breed_inp.Text = gender_inp.Text =
              color_inp.Text = petage_inp.Text = petdiscr_inp.Text = "";
                //Display(false);
                delete_btn.Visible = false;

            }
            else
                MessageBox.Show("all inputs are required");
        }

        private void addmedical_btn_Click(object sender, EventArgs e)
        {
            DisplayPetInps(false);
            DisplayRecordInps(true);


        }

        private void saveaddrec_btn_Click(object sender, EventArgs e)
        {
            if (recdesc_inp.Text != "" && vetname_inp.Text != "" && vaccinename.Text != "")
            {
                MedicalRecords med = new MedicalRecords()
                {
                    Date = daterecord_inp.Value,
                    Description = recorddesc_inp.Text,
                    VetName = vetname_inp.Text,
                    NextAppointment = nextdate_inp.Value,
                    petId = id,
                    Vaccine_name = vaccinename.Text

                };
                db.Medical.Add(med);
                db.SaveChanges();
                dgv_medical.DataSource = db.Medical.Where(n => n.petId == id).Select(
                    n => new
                    {
                        n.Id,
                        n.Date,
                        n.Description,
                        n.NextAppointment,
                        n.VetName,
                        n.petId
                    }
                    ).ToList();
                MessageBox.Show("record added");
            }

        }

        private void dgv_medical_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            record_id = (int)dgv_medical.SelectedRows[0].Cells[0].Value;
            record = db.Medical.Where(n => n.Id == record_id).SingleOrDefault();
            delmedical_btn.Visible = true;
            updatemedical_btn.Visible = true;
            DisplayPetInps(false);
            DisplayRecordInps(true);
            daterecord_inp.Value = record.Date;
            recorddesc_inp.Text = record.Description;
            vetname_inp.Text = record.VetName;
            nextdate_inp.Value = record.NextAppointment;
            vaccinename.Text = record.Vaccine_name;

        }

        private void updatemedical_btn_Click(object sender, EventArgs e)
        {
            if (recorddesc_inp.Text != "" && vetname_inp.Text != "" && vaccinename.Text != "")
            {
                record.Date = daterecord_inp.Value;
                record.Description = recorddesc_inp.Text;
                record.VetName = vetname_inp.Text;
                record.NextAppointment = nextdate_inp.Value;
                record.Vaccine_name = vaccinename.Text;
                db.SaveChanges();
                dgv_medical.DataSource = db.Medical.Where(n => n.petId == id).Select(
                   n => new
                   {
                       n.Id,
                       n.Date,
                       n.Description,
                       n.NextAppointment,
                       n.VetName,
                       n.Vaccine_name,
                       n.petId
                   }
                   ).ToList();
                recorddesc_inp.Text = vetname_inp.Text = "";
                MessageBox.Show("record apdated");
            }
        }

        private void delmedical_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this pet", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Medical.Remove(record);
                db.SaveChanges();
                recorddesc_inp.Text = vetname_inp.Text = "";
                dgv_medical.DataSource = db.Medical.Where(n => n.petId == id).Select(
                  n => new
                  {
                      n.Id,
                      n.Date,
                      n.Description,
                      n.NextAppointment,
                      n.VetName,
                      n.petId
                  }
                  ).ToList();
                MessageBox.Show("medical record deleted");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminform admin = new adminform();
            this.Close();
            admin.Show();
        }

        private void dgv_medical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
