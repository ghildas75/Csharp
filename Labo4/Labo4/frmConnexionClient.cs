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

namespace Labo4
{
    public partial class frmConnexionClient : Form
    {
       
       
        public frmConnexionClient()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //String connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Portable\Documents\webServer\BDVoyages.mdf; Integrated Security = True; Connect Timeout = 30";
            String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDVoyagesSamir;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //C: \Users\Portable\documents\visual studio 2017\Projects\Labo4\Labo4\BDVoyages.mdf

             SqlConnection conn = new SqlConnection(connectionString);
            String myQuery = " SELECT cliNo from client where cliPrenom=@prenom and cliNom=@nom";
            SqlCommand myCm = new SqlCommand(myQuery, conn);
            conn.Open();
            string nom =txtNom.Text;
            string prenom =txtPrenom.Text;
            //MessageBox.Show(nom + "" + prenom);
            myCm.Parameters.AddWithValue("@prenom", prenom);
            myCm.Parameters.AddWithValue("@nom", nom);

        
          String nClient  = (myCm.ExecuteScalar()).ToString();
            
            MessageBox.Show(nClient.ToString());
            if (nClient != "")
            {
                lblErreur.Text = "connexion reussi";
                frmReservationVoyage fTrip = new frmReservationVoyage();
                fTrip.noClient = nClient;
                this.Hide();
                fTrip.ShowDialog();
                this.Show();
            }
            else
            {
                lblErreur.Text = "Connexion échoué.Taper votre nom et votre prenom svp";
            }
            conn.Close();
        }

        private void frmConnexionClient_Load(object sender, EventArgs e)
        {

        }
    }
}
