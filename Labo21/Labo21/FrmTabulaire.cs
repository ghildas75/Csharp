﻿using System;
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
    public partial class FrmTabulaire : Form
    {
        public FrmTabulaire()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesDataSet);

        }

        private void FrmTabulaire_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDVoyagesDataSet.employe);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void employeDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}