using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisionLabo2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void affichageParEnrigistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmEnrigistrement().ShowDialog();
            this.Show();
        }

        private void affichageEnTabulaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAffichageTabulaire().ShowDialog();
            this.Show();
        }

        private void affichageAPartirDePlusieurTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPlusieursTables().ShowDialog();
            this.Show();
        }

        private void affichageMaitreDétailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMasterSlave().ShowDialog();
            this.Show();
        }

        private void affichageFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmFiltre().ShowDialog();
            this.Show();
        }
    }
}
