using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo21
{
    public partial class FrmMenu : Form
    {
        FrmEnrigistrement fEnr = new FrmEnrigistrement();
        FrmTabulaire fTbl = new FrmTabulaire();
        frmPlusieursTables fpts = new frmPlusieursTables();
        frmMaitreDetail fmd = new frmMaitreDetail();
        frmAffichageAvecFiltre ffil = new frmAffichageAvecFiltre();
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void affichageEnrigistrementparEnrigistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lABORATOIREToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aFFICHERENRIGISTREMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fEnr.ShowDialog();
            this.Show();
        }

        private void aFFICHAGETABULAIREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTbl.ShowDialog();
            this.Show();
        }

        private void affichageDePlusieursTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fpts.ShowDialog();
            this.Show();

        }

        private void affichageMaitreDAÉTAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmd.ShowDialog();
            this.Show();
        }

        private void affichageAvecFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ffil.ShowDialog();
            this.Show();

        }
    }


}
