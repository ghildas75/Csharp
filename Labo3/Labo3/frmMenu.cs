﻿using System;
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
    public partial class frmMenu : Form
    {
        frmMVC fmvc = new frmMVC();
        frmChargementDynamique frd = new frmChargementDynamique();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mODELEMVCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmvc.ShowDialog();
            this.Show();

        }

      

        private void cHARGEMENTDYNMIQUEDESDONNESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frd.ShowDialog();
            this.Show();
        }

        private void chaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frd.ShowDialog();
            this.Show();
        }
    }
}
