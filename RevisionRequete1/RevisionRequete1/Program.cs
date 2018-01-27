using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RevisionRequete1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=E5550-FC-05;Initial Catalog=BDTest;Integrated Security=True;Pooling=False");
            
            myConnection.Open();
            SqlCommand mycm = new SqlCommand("SELECT empPrenom,EmpNom  FROM employe", myConnection);
            SqlDataReader dr = mycm.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("prenom: " + dr[0] +"," +"nom: " + dr[1]);
            }
            dr.Close();

            /*b.	A l’aide d’un DataReader, pour chaque contrat, affichez le numéro, la date et le nom de l’employé responsable 
             * (le nom de l’employé responsable est situé dans la table employe)*/
            string query = "select conNo,conDate,empNom from contrat,employe where employe.empNo=contrat.empNo;";
            SqlCommand mycm2 = new SqlCommand(query, myConnection);
            SqlDataReader dr2 = mycm2.ExecuteReader();
            while (dr2.Read())
            {
                Console.WriteLine("" + dr2["conNo"] + "" + dr2["conDate"] + "" + dr2["empNom"]);
            }
            dr2.Close();
            string sql2 = "SELECT employe.empNo, employe.empNom, count(contrat.empNo) FROM contrat, employe where contrat.empNo = employe.empNo group by employe.empNo, employe.empNom";
            SqlCommand mycm3 = new SqlCommand(sql2, myConnection);
            SqlDataReader dr3 = mycm3.ExecuteReader();
            while (dr3.Read())
            {
                Console.WriteLine("" + dr3[0] + "" + dr3[1] + "" + dr3[2]);
            }
            dr3.Close();
            // 
            string sql4 = "select count (hotNom) from hotel where hotNom like '%Montréal%'";
            SqlCommand mycm4 = new SqlCommand(sql4, myConnection);
            int nombreHotel = (int)mycm4.ExecuteScalar();
            Console.WriteLine("nombre hotel a montreal" + nombreHotel);
            //requete avec un parametre de sortie
            string sql5 = "select @nbreHotel=count(hotNom) from hotel where hotNom like @city";
            SqlCommand mycm5 = new SqlCommand(sql5, myConnection);
            String ville = "%Montréal%";
            SqlParameter parmEntre = new SqlParameter("@city",ville);
            parmEntre.SqlDbType = SqlDbType.VarChar;
            parmEntre.Direction = ParameterDirection.Input;
            mycm5.Parameters.Add(parmEntre);
           SqlParameter parmSortie = new SqlParameter("@nbreHotel", null);
            parmSortie.SqlDbType = SqlDbType.Int;
            parmSortie.Direction = ParameterDirection.Output;
            mycm5.Parameters.Add(parmSortie);
            //mycm5.Parameters.AddWithValue("@city", "%Montréal%");

            int nombreLigne = mycm5.ExecuteNonQuery();
            if (nombreLigne == 0)
                Console.WriteLine("aucun hotel n'existe pas. ");
            else
                Console.WriteLine("nombre Hotel " + mycm5.Parameters["@nbreHotel"].Value);

            Console.WriteLine("" + nombreLigne);
            


            Console.ReadKey();

            myConnection.Close();
        }

    }
}
