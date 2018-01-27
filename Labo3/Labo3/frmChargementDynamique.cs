using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo3
{
    public partial class frmChargementDynamique : Form
    {
        public frmChargementDynamique()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesDataSet);

        }

        private void frmChargementDynamique_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratTableAdapter.Fill(this.bDVoyagesDataSet.contrat);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDVoyagesDataSet.employe);

        }

        private void employeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            int noEnrigistrement = employeBindingSource.Position;

            int nbEnrigistrements = employeBindingSource.Count;

            if(noEnrigistrement>=0 && noEnrigistrement< nbEnrigistrements)
            {
                dynamic enrigistrementSelectionne = employeBindingSource.Current;
                decimal noEmployeSelectionne = enrigistrementSelectionne["empNo"];
                contratTableAdapter.ClearBeforeFill = true;
                contratTableAdapter.Fill(bDVoyagesDataSet.contrat, noEmployeSelectionne);
            }
        }
    }
}
