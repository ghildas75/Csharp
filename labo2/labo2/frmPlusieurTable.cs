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
    public partial class frmPlusieurTable : Form
    {
        public frmPlusieurTable()
        {
            InitializeComponent();
        }

        private void frmPlusieurTable_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.contrat1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contrat1TableAdapter.Fill(this.bDVoyagesDataSet.contrat1);

        }
    }
}
