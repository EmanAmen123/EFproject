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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            adminUsers users = new adminUsers();
            this.Close();
            users.Show();
            //this.Hide();
        }

        private void pets_btn_Click(object sender, EventArgs e)
        {
            adminPets pets = new adminPets();
            this.Close();
            pets.Show();
            //this.Hide();
        }

        private void adoptions_btn_Click(object sender, EventArgs e)
        {
            AdoptionsRec records = new AdoptionsRec();
            this.Close();
            records.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }
    }
}
