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

namespace RevisionLabo4
{
    public partial class frmAffichageProg : Form
    {
        string str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDTR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con = new SqlConnection();
        DataSet ds = new DataSet();
        public frmAffichageProg()
        {
            InitializeComponent();
        }

        private void frmAffichageProg_Load(object sender, EventArgs e)
        {

        }

        private void btnAfficheEmploye_Click(object sender, EventArgs e)
        {
            con.ConnectionString = str;
            string req = "select * from employe";
            SqlDataAdapter dataAdapterEmploy = new SqlDataAdapter(req, con);
            if (ds.Tables.Contains("fullNameEmploye")){
                ds.Tables.Remove("fullNameEmploye");
            }
            dataAdapterEmploy.Fill(ds, "fullNameEmploye");
            if (ds.Tables["fullNameEmploye"].Rows.Count == 0)
            {
                MessageBox.Show("la table employe est vide");
            }
            else
            {
                lstEmploye.Items.Clear();
                foreach (DataRow  ligneEmploye in ds.Tables[0].Rows)
                {
                    string fullName = ligneEmploye[1] + " " + ligneEmploye[2];
                    lstEmploye.Items.Add(fullName);
                }
            }
        }

        private void lstEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelec = lstEmploye.SelectedIndex;
            var ligneEmploy = ds.Tables[0].Rows[indiceSelec];
            string prenom = ligneEmploy["empPrenom"].ToString();
            string nom = ligneEmploy["empNom"].ToString();
            String req = "SELECT c.conNo FROM employe e, contrat c where e.empNo = c.empNo and e.empPrenom = '" + prenom + "' and e.empNom = '" + nom + "'";

            SqlDataAdapter da = new SqlDataAdapter(req, con);
            da.Fill(ds, "contratEmploye");
            foreach (DataRow dr in ds.Tables[1].Rows)
            {
                lstContrat.Items.Clear();
                string numContrat = dr[0].ToString();
                lstContrat.Items.Add(numContrat);
            }
        }
    }
}
