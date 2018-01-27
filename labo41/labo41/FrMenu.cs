using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labo41
{
    public partial class FrMenu : Form
    {
        FrmAffichageParProgrammation frp = new FrmAffichageParProgrammation();
        public FrMenu()
        {
            InitializeComponent();
        }

        private void affichageParProgrammationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frp.ShowDialog();
            this.Show();
        }
    }
}
