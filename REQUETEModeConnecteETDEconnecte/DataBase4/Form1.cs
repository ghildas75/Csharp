using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string prenom = txtFind.Text;
            string chaine = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDTR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from employe where empPrenom like @x";
            SqlParameter pram = new SqlParameter("@x", "%"+prenom+"%");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(pram);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
