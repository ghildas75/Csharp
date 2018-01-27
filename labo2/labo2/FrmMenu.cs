using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labo2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void affichageParEnrigistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmEnrigistrement().ShowDialog();
            this.Show();
        }

        private void affichageTabulaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTabulaire().ShowDialog();
            this.Show();
        }

        private void affichageAPartirDePlusieursTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPlusieurTable().ShowDialog();
            this.Show();
        }

        private void affichageAvecFiltresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMaitreDétail().ShowDialog();
            this.Show();
        }

        private void affichageAvecFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmFiltre().ShowDialog();
            this.Show();
        }
    }
}
