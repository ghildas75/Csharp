using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenu
{
    using System.Data.SqlClient;
    public partial class frmAffichageParProgrommation : Form
    {
        public frmAffichageParProgrommation()
        {
            InitializeComponent();
        }

        private void frmAffichageParProgrommation_Load(object sender, EventArgs e)
        {
            String connect = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDVoyages;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DataSet ds = new DataSet();
        }
    }
}
