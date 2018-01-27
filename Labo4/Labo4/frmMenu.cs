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
    public partial class frmMenu : Form
    {
        frmAffichageParProgrommation fp = new frmAffichageParProgrommation();
        frmConnexionClient frmConnex = new frmConnexionClient();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void affichageParProgrommationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }

        private void reservationDeVoyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConnex.ShowDialog();
            this.Show();

        }
    }
}
