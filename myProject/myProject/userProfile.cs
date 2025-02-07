using Dapper;
using Microsoft.Data.SqlClient;
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
    public partial class userProfile : Form
    {

        int user_id;
        public userProfile(int id)
        {
            user_id = id;
            InitializeComponent();
        }
        SqlConnection sqlCommand = new("Server=DESKTOP-AFGBK7M\\SQLEXPRESS01;Database=EFproject;Trusted_Connection=True;Trust Server Certificate=True;");

        private void userProfile_Load(object sender, EventArgs e)
        {
            var query = @"
    SELECT 
        m.Id AS MemberId, 
        m.F_name, 
        m.L_name, 
        m.Email, 
        m.Password, 
        m.Address, 
        m.Role, 
        m.Age, 
        m.PhoneNumber, 
        m.isDeleted
    FROM 
        Members m
    WHERE 
        m.Id = @MemberId AND m.isDeleted = 0;

    SELECT 
        p.Id AS PetId, 
        p.Name, 
        p.Species, 
        p.Breed, 
        p.Gender, 
        p.Color, 
        p.Age, 
        p.AdoptionStatus, 
        p.DateAdded, 
        p.Description
    FROM 
        Pets p
    WHERE 
        p.AdopterId = @MemberId;";

            var parameters = new { MemberId = user_id };

            using (var multi = sqlCommand.QueryMultiple(query, param: parameters))
            {
                var member = multi.Read<Members>().FirstOrDefault();

                if (member != null)
                {
                    var pets = multi.Read<Pets>().ToList();

                    member.Adoptedpets = pets;

                    fname.Text = member.F_name;
                    lname.Text = member.L_name;
                    address.Text = member.Address;
                    age.Text = member.Age?.ToString();
                    phone.Text = member.PhoneNumber.ToString();

                    dgv_pets.DataSource = member.Adoptedpets;
                    dgv_pets.Columns[0].Visible = false;
                    dgv_pets.Columns[7].Visible = false;
                    dgv_pets.Columns[10].Visible = false;
                    dgv_pets.Columns[11].Visible = false;
                }

                else
                    MessageBox.Show("Member not found or has been deleted.");
            }
        }

        private void editprofile_btn_Click(object sender, EventArgs e)
        {
            updateuserProfile update = new updateuserProfile(user_id);
            update.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm(user_id);
            this.Close();
            user.Show();
        }
    }
}
