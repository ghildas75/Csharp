using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4
{
    using System.Data.SqlClient;
    public partial class frmAffichageParProgrommation : Form
    {
        string myConnexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Portable\Documents\webServer\BDVoyages.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection myConnexion = new SqlConnection();
        DataSet myDataSet = new DataSet();

        public frmAffichageParProgrommation()
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

        private void lstEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (myDataSet.Tables["prenomNomEmploye"].Rows.Count == 0)
                MessageBox.Show("la table employe est vide", "error");*/


            int indiceSelection = lstEmploye.SelectedIndex;
            DataRow lineEmployeChoise = myDataSet.Tables["prenomNomEmploye"].Rows[indiceSelection];
            String prenom = lineEmployeChoise["empPrenom"].ToString();
            String nom = lineEmployeChoise["empNom"].ToString();
            //
            
           string myQuery = "select conNo from contrat, employe where employe.empNo=contrat.empNo and empPrenom=@prenomEmploye and empNom=@nomEmploye";
            SqlParameter prenomEmploye = new SqlParameter("@prenomEmploye", prenom);
            SqlParameter nomEmploye = new SqlParameter("@nomEmploye", nom);
            //SqlParameter nomEmploye = new SqlParameter("@nomEmploye", nom);
            //creer un dataadapter qui permet de faire le lien entre la base de donne et le dataset
            SqlDataAdapter dataAdapterContratEmploye = new SqlDataAdapter(myQuery, myConnexion);
            dataAdapterContratEmploye.SelectCommand.Parameters.Add(prenomEmploye);
              dataAdapterContratEmploye.SelectCommand.Parameters.Add(nomEmploye);
            if (dataAdapterContratEmploye == null)
            {
                lstContrats.Items.Add("aucun contrat");
                //MessageBox.Show("aucun contrat");
            }
            if (myDataSet.Tables.Contains("contratEmploye"))
                myDataSet.Tables.Remove("contratEmploye");
            dataAdapterContratEmploye.Fill(myDataSet, "contratEmploye");
            if (myDataSet.Tables["contratEmploye"].Rows.Count == 0)
            {
                lstContrats.Items.Clear();
                lstContrats.Items.Add("aucun contrat");
                //MessageBox.Show("la table contrat est vide", "error");
               
            }
            else
            {
                lstContrats.Items.Clear();
                foreach (DataRow lineContratEmploye in myDataSet.Tables["contratEmploye"].Rows)
                {
                    string contratNumber = lineContratEmploye["conNo"] + "  ";
                    lstContrats.Items.Add(contratNumber);

                }
            }
        }

    }
}