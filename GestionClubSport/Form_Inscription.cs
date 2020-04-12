using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GestionClubSport
{
    public partial class Form_Inscription : Form
    {
        public Form_Inscription()
        {
            InitializeComponent();
        }

        

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Inscription_Load(object sender, EventArgs e)
        {
            
            

            //gcE.Adherents.ToList();
            //bs.DataSource = gcE.Adherents.Local;
            ////bs.DataSource = Program.da_Adherent;
            //Textbox_Nom.DataBindings.Add(new Binding("text", bs, "NomA"));
            //Textbox_Prenom.DataBindings.Add(new Binding("text", bs, "PrenomA"));
            //Datepicker_DN.DataBindings.Add(new Binding("text", bs, "DateN"));
            //Cmbbx_Sexe.DataBindings.Add(new Binding("text", bs, "Sexe"));
            //Textbox_Adresse.DataBindings.Add(new Binding("text", bs, "Adresse"));
            //Textbox_Ville.DataBindings.Add(new Binding("text", bs, "VilleA"));
            //Textbox_Tel.DataBindings.Add(new Binding("text", bs, "Tel"));
            //bs2.DataSource = gcE.Login_.Local;
            //Textbox_Username.DataBindings.Add(new Binding("text", bs2, "Username"));
            //pass.DataBindings.Add(new Binding("text", bs2, "Password"));
        }

        private void Textbox_Adresse_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
