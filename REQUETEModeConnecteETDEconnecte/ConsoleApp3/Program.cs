using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDTR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(chaine);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employe where empPrenom like @x", con);
            SqlParameter myParam = new SqlParameter("@x", "%M%");
            cmd.Parameters.Add(myParam);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetString(1));
            }
            dr.Close();
            Console.WriteLine("----------------------------");
            SqlTransaction tx = con.BeginTransaction();
            try
            {
                SqlCommand cmd2 = new SqlCommand("insert into  employe(empNo,empPrenom) values(1015,@x)", con);
                Console.WriteLine("entrer un prenom svp");
                string pren = Console.ReadLine();
                SqlParameter myParam2 = new SqlParameter("@x", pren);
                cmd2.Parameters.Add(myParam2);
                cmd2.Transaction = tx;
                cmd2.ExecuteNonQuery();
                tx.Commit();
            }
            catch(Exception e)
            {
                tx.Rollback();
                Console.WriteLine(e.Message);
            }
            con.Close();
            Console.Read();
        }
    }
}
