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
    public partial class frmPlusieursTables : Form
    {
        public frmPlusieursTables()
        {
            InitializeComponent();
        }

        private void frmPlusieursTables_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesDataSet.contratEmploye'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratEmployeTableAdapter.Fill(this.bDVoyagesDataSet.contratEmploye);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
