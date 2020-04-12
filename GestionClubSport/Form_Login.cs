using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionClubSport
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Inscription fi = new Form_Inscription();
            fi.Show();
            Form_Login fl = new Form_Login();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            //Program.Charger_Dataset();            
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //string req = string.Format(@"select * from Login_ where Username='{0}' and Password = '{1}'", Textbox_user.Text.Trim(), Textbox_pass.Text.Trim());
            //Program.da_login = new SqlDataAdapter(req,Program.con);
            //DataTable dt = new DataTable();
            //Program.da_login.Fill(dt);
            //if(dt.Rows.Count==1)
            //{
            //    Form_Home fh = new Form_Home();
            //    this.Visible = false;
            //    fh.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Check Your Username And Password");
            //}
        }

        private void Tbx_pass_Enter(object sender, DragEventArgs e)
        {
            if (Textbox_pass.Text == @"Password")
            {
                Textbox_pass.Text = "";
            }
        }

        private void Tbx_pass_Leave(object sender, EventArgs e)
        {
            if (Textbox_pass.Text=="")
            {
                Textbox_pass.Text = @"Password";
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked == false)
            {
                Textbox_pass.isPassword = true;
            }
            else
            {
                Textbox_pass.isPassword = false;
            }
        }

        private void textBox_username_Enter(object sender, DragEventArgs e)
        {
            if (Textbox_user.Text==("Username"))
            {
                Textbox_user.Text = "";
            }
        }

        private void txtbx_username_Leave(object sender, EventArgs e)
        {
            if (Textbox_user.Text == "")
            {
                Textbox_user.Text = "Username";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Textbox_pass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
