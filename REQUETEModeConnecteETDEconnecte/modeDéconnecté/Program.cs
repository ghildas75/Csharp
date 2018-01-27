using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace modeDéconnecté
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDTR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from employe";
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            foreach (DataColumn DC in ds.Tables[0].Columns)
            {
                Console.Write(DC.ColumnName + "\t");        
                    }
            Console.WriteLine();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                foreach (DataColumn DC in ds.Tables[0].Columns)
                {
                    Console.Write(dr[DC.ColumnName] + "\t");
                }
                Console.Write("");
            }

            Console.Read();


        }
    }
}
