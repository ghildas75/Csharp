using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCConsoleVoyage
{
    class Program
    {
        static void Main(string[] args)
        {
            String connectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=BDVoyages;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            String maRequeteSQL = " SELECT empPrenom, empNom FROM employe";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, conn);
            SqlDataReader monReader = maCommande.ExecuteReader();
            while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
            {
                // L'index peut être un numéro de colonne ou le nom d'une colonne
                Console.WriteLine("Prénom = " + monReader[0] + ", Nom = " + monReader["empNom"]);
            }
            monReader.Close();   // IMPORTANT: Libérer les ressources  
            maCommande.CommandText = "update employe set empPrenom='samir' where emp=1001 ";
            Console.WriteLine("".PadRight(80, '*'));
            int result = maCommande.ExecuteNonQuery();
            Console.WriteLine(result);
            maCommande.CommandText= "insert into employe values (10015, 'samir', 'L', 'DI', 777.00, NULL, NULL, 'stf')";
            
            conn.Close();
            Console.ReadKey();

        }
    }
}
