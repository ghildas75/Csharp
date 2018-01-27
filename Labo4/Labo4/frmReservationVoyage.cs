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

namespace Labo4
{
    public partial class frmReservationVoyage : Form
    {
        public String noClient { get; set; }
        public frmReservationVoyage()
        {
            InitializeComponent();
        }

        private void frmReservationVoyage_Load(object sender, EventArgs e)
        {
            this.destinationsVoyagesTableAdapter.Fill(this.bDVoyagesDataSet.destinationsVoyages);

            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.infoVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.infoVoyagesTableAdapter.Fill(this.bDVoyagesDataSet.infoVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.destinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationsVoyagesTableAdapter.Fill(bDVoyagesDataSet.reservationsVoyages, Convert.ToDecimal(noClient));
          
            {

            }
        }

        private void dgInfoVoyages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.reservationsVoyagesTableAdapter.Fill(this.bDVoyagesDataSet.reservationsVoyages, ((decimal)(System.Convert.ChangeType(noClientToolStripTextBox.Text, typeof(decimal)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnAjoutVoyageSelectionné_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Portable\Documents\webServer\BDVoyages.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            String myreq1 = "INSERT INTO contrat VALUES (@noContrat, @maintenant, 200.00, 1140.58, 200.00, 1, 1002, @noVoyage, @noClient);";
            String myreq2 = "INSERT INTO faitLeVoyage VALUES (@noContrat, @noClient);";
            SqlCommand myCmk = new SqlCommand(myreq1, conn);
            SqlCommand myCmk2 = new SqlCommand(myreq2, conn);

            String noVoyage = dgInfoVoyages.CurrentRow.Cells[0].Value.ToString();
            String mtn = (DateTime.Now.Date).ToString();
            string reqContrat = "SELECT @numcontrat = MAX(conNo) FROM contrat";
            
            SqlCommand myCmContrat = new SqlCommand(reqContrat, conn);
            int numContrat = 0;
            SqlParameter parmNumcontrat = new SqlParameter("@numcontrat", null);
            parmNumcontrat.SqlDbType = SqlDbType.Int;
            parmNumcontrat.Direction = ParameterDirection.Output;
            myCmContrat.Parameters.Add(parmNumcontrat);

            myCmContrat.ExecuteScalar();

            numContrat = (int)myCmContrat.Parameters["@numcontrat"].Value + 1;
            MessageBox.Show("" + numContrat);
            //string numContrat = myCmContrat.ExecuteScalar().ToString();
            //int NContrat = (int.Parse(numContrat))+1;
            //MessageBox.Show("" + parmatContrat);
            SqlParameter parmNcontrat = new SqlParameter("@noContrat", numContrat);
            SqlParameter parmNow = new SqlParameter("@maintenant", mtn);
            SqlParameter parmVoyage = new SqlParameter("@noVoyage",noVoyage);
            SqlParameter parmClient = new SqlParameter("@noClient", noClient);
            myCmk.Parameters.Add(parmNcontrat);
            myCmk.Parameters.Add(parmNow);
            myCmk.Parameters.Add(parmVoyage);
            myCmk.Parameters.Add(parmClient);

            SqlParameter parmNcontrat2 = new SqlParameter("@noContrat", numContrat);
            SqlParameter parmClient2 = new SqlParameter("@noClient", noClient);

            myCmk2.Parameters.Add(parmNcontrat2);
            myCmk2.Parameters.Add(parmClient2);
            int nbreLigne= myCmk.ExecuteNonQuery();
            int nbreLigne2 = myCmk2.ExecuteNonQuery();
            //MessageBox.Show("" + nbreLigne+""+mtn);



            if (infoVoyagesBindingSource.Current != null)
            {
                this.reservationsVoyagesTableAdapter.Fill(bDVoyagesDataSet.reservationsVoyages, Convert.ToDecimal(noClient));
            }
           
            conn.Close();
        }     
    }
}
