using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GestionClubSport
{
    static class Program
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=ANDROID-RF76Y98\SQLEXPRESS;
                          Initial Catalog=gestion_club_sport;
                          Integrated Security=True");
        public static SqlDataAdapter da_Adherent;
        public static SqlDataAdapter da_login;
        //public static SqlDataAdapter da = new SqlDataAdapter("select * from Login_", con);
        public static DataSet ds = new DataSet();




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }

        public static void Charger_Dataset()
        {
            da_Adherent = new SqlDataAdapter("select * from Adherent", con);
            da_Adherent.Fill(ds, "Adherent");
            //définir les clés primaires
            ds.Tables["Adherent"].PrimaryKey = new DataColumn[] {
                                    ds.Tables ["Adherent"].Columns[0] };

            da_login = new SqlDataAdapter("select * from Login_", con);
            da_login.Fill(ds, "Login_");
            //définir les clés primaires
            ds.Tables["Login_"].PrimaryKey = new DataColumn[] {
                                    ds.Tables ["Login_"].Columns[0] };

            //définir les relations(clé étrangère)
            ds.Relations.Add(new DataRelation("CLII",
                                        ds.Tables["Adherent"].Columns[0],
                                        ds.Tables["Login_"].Columns[0]));
        }

        public static void mettre_a_jour_clt()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da_Adherent);
            da_Adherent.Update(ds.Tables["Adherent"]);
            SqlCommandBuilder cbC = new SqlCommandBuilder(da_login);
            da_login.Update(ds.Tables["Login_"]);
        }
    }
}
