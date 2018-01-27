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
    public partial class frmAffichageAvecFiltre : Form
    {
        public frmAffichageAvecFiltre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employeAvecFiltreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeAvecFiltreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeAvecFiltreTableAdapter.Fill(this.bDVoyagesDataSet.employeAvecFiltre, nomToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
