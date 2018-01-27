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
namespace labo41
{
    public partial class FrmAffichageParProgrammation : Form
    {
        string myConnexionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDVoyagesSamir;Integrated Security=True;";
        SqlConnection myConnexion = new SqlConnection();
        DataSet myDataSet = new DataSet();

        public FrmAffichageParProgrammation()
        {
            InitializeComponent();
        }

        private void btnAfficherEmployes_Click(object sender, EventArgs e)
        {
            myConnexion.ConnectionString = myConnexionString;
            string myQuery = "select empPrenom,empNom from employe";
            //creer un dataadapter qui permet de faire le lien entre la base de donne et le dataset
            SqlDataAdapter dataAdapterEmploye = new SqlDataAdapter(myQuery, myConnexion);
            if (myDataSet.Tables.Contains("prenomNomEmploye"))
                myDataSet.Tables.Remove("prenomNomEmploye");
            dataAdapterEmploye.Fill(myDataSet, "prenomNomEmploye");
            if (myDataSet.Tables["prenomNomEmploye"].Rows.Count == 0)
                MessageBox.Show("la table employe est vide", "error");
            else
            {
                lstEmploye.Items.Clear();
                foreach (DataRow lineEmploye in myDataSet.Tables["prenomNomEmploye"].Rows)
                {
                    string firstLastNameEmploy = lineEmploye["empPrenom"] + "  " + lineEmploye["empNom"];
                    lstEmploye.Items.Add(firstLastNameEmploy);

                }
            }

        }
    }
}
