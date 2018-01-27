using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDVoyages;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            String maRequeteSQL = " SELECT empPrenom, empNom , empEmploi FROM employe";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, conn);
            SqlDataReader monReader = maCommande.ExecuteReader();
            while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
            {
                // L'index peut être un numéro de colonne ou le nom d'une colonne
                Console.WriteLine("Prénom = " + monReader[0] + ", Nom = " + monReader["empNom"]+" ,  type employe= "+monReader[2]);
            }
            monReader.Close();
            Console.WriteLine("here ........");
            String sql = "select contrat.conNo,contrat.conDate ,employe.empNom from contrat,employe where contrat.empNo=employe.empNo";
            SqlCommand maCm = new SqlCommand(sql, conn);
           SqlDataReader monRe = maCm.ExecuteReader();
            while (monRe.Read()) // Lire le prochain enregistrement (la prochaine ligne)
            {
                // L'index peut être un numéro de colonne ou le nom d'une colonne
         Console.WriteLine("numero contrat = " + monRe[0]  + ", date = " + monRe[1] + ", = "+monRe[2].ToString());
            }
            // IMPORTANT: Libérer les ressources  
            monRe.Close();

            /// 3eme requete
            /// 
            string sql2= "SELECT employe.empNo, employe.empNom, count(contrat.empNo) FROM contrat, employe where contrat.empNo = employe.empNo group by employe.empNo, employe.empNom"; 
            SqlCommand maC = new SqlCommand(sql2, conn);
          SqlDataReader monRe3 = maC.ExecuteReader();
            while (monRe3.Read()) // Lire le prochain enregistrement (la prochaine ligne)
            {
                // L'index peut être un numéro de colonne ou le nom d'une colonne
                Console.WriteLine("numero = " + monRe3[0] + ", nom = " + monRe3[1] + ", nombre contrat = " + monRe3[2].ToString());
            }
            monRe3.Close();
            //requete 4
            string sql4 = "select count(hotel.hotNom) from hotel where   hotNom like '%Montréal'";
            SqlCommand cmd = new SqlCommand(sql4, conn);
            Int32 value  =(Int32)cmd.ExecuteScalar();
            Console.WriteLine("nombre hotel" + value);

            //requete avec parametre

            string sql5 = "select  @nbHotels = count(hotel.hotNom) from hotel where hotNom like @city";
            SqlCommand cmd5 = new SqlCommand(sql5, conn);
            String ville = "%Montréal%";
            SqlParameter monParametreSQL = new SqlParameter("@city",ville);
            monParametreSQL.SqlDbType = SqlDbType.VarChar;
            monParametreSQL.Direction = ParameterDirection.Input;
            cmd5.Parameters.Add(monParametreSQL);

            SqlParameter nbhotel = new SqlParameter("@nbHotels", null);
            nbhotel.SqlDbType = SqlDbType.Int;
            nbhotel.Direction = ParameterDirection.Output;
            cmd5.Parameters.Add(nbhotel);

            int res = cmd5.ExecuteNonQuery();
            if (res == 0)
                Console.WriteLine("aucun hotel n'existe pas. ");
            else
                Console.WriteLine("nombre Hotel " + cmd5.Parameters["@nbHotels"].Value);


            /**************requete E******************************/
            String sqlE = "select voyNo,voyDateDepart,voyDateArrive from voyage where voyDestination like'%Montréal'";
            SqlCommand cmd6 = new SqlCommand(sqlE, conn);
            SqlDataReader monRe6 = cmd6.ExecuteReader();
            while (monRe6.Read()) // Lire le prochain enregistrement (la prochaine ligne)
            {
                // L'index peut être un numéro de colonne ou le nom d'une colonne
                Console.WriteLine("numero de vol= " + monRe6[0] + ", date départ = " + monRe6[1] + ", data arrive = " + monRe6[2].ToString());
            }
            monRe6.Close();
            //requet f
            String mySqlF = " UPDATE voyage SET tarifSimple =0.1*tarifSimple WHERE voyDestination  ='Montréal'";
            SqlCommand myCmf = new SqlCommand(mySqlF, conn);
            int nbLignes = myCmf.ExecuteNonQuery();
            Console.WriteLine(nbLignes.ToString() + " ligne(s) modifiée(s) dans la commande F");



            //requete g
            string sqlG = "SELECT contrat.empNo, sum(conMontant) from contrat group by contrat.empNo";
            SqlCommand cmd7 = new SqlCommand(sqlG, conn);
            SqlDataReader monRe7 = cmd7.ExecuteReader();
            while (monRe7.Read()) // Lire le prochain enregistrement (la prochaine ligne)
            {
                // L'index peut être un numéro de colonne ou le nom d'une colonne
                Console.WriteLine("numero de vol= " + monRe7[0] + ", montant contrat = " + monRe7[1] );
            }
            
            monRe7.Close();

            //h.	Affichez le nom de l’hôtel affecté à un numéro de voyage entré par l’utilisateur. Utiliser un paramètre SQL Serveur en entrée.

            Console.Write("Entrez un numéro de voyage: ");
            String num = Console.ReadLine().Trim();

            String mySQLH = " SELECT hotNom FROM hotel,voyage WHERE hotel.hotNo=voyage.hotno and voyNo = " + num;
            SqlCommand myCm = new SqlCommand(mySQLH, conn);
            dynamic nom = myCm.ExecuteScalar();
            if (nom == null)
                Console.WriteLine("Cet hotel n'existe pas. ");
            else
                Console.WriteLine("Son nom est " + nom);
            /// La requête ne retourne aucun résultat; la méthode retourne le nombre d'enregistrements modifiés
           /* String mySQLI = " INSERT INTO faitLeVoyage VALUES (444015 ,123024);";
            SqlCommand myCmi = new SqlCommand(mySQLI, conn);

            int nbLignesModifies = myCmi.ExecuteNonQuery();
            Console.WriteLine(nbLignesModifies.ToString() + " ligne(s) modifiée(s) dans la commande 1");


            // La requête j
            String mySQLJ = "delete from faitLeVoyage where  cliNo='123024';";
            SqlCommand myCmJ = new SqlCommand(mySQLJ, conn);
            int nbLignesMo = myCmJ.ExecuteNonQuery();
            Console.WriteLine(nbLignesMo.ToString() + " ligne(s) supprimer dans la commande 2");*/
            //requete k
            Console.Write("Entrez un numero employe: ");
            String numeroEmploye= Console.ReadLine().Trim();
            String maRequeteSQ = "SELECT empPrenom	, empNom FROM employe WHERE  empNo= @numeroEmploye; " +
                "SELECT @nbAnime = COUNT(voyNo) FROM voyage WHERE empNo = @numeroEmploye; ";
            SqlCommand myCmk = new SqlCommand(maRequeteSQ,conn);
            // Ajout du paramètre SQL Server @destinationVoyage en entrée
            SqlParameter paramNumEmploye = new SqlParameter("@numeroEmploye",numeroEmploye);
            paramNumEmploye.SqlDbType = SqlDbType.VarChar;  // On indique que la donnée est de type varchar (pas obligatoire)
            paramNumEmploye.Direction = ParameterDirection.Input; // On indique que c'est en entrée (pas obligatoire)
            myCmk.Parameters.Add(paramNumEmploye); // On ajoute ce paramètre dans la commande
            // Ajout du paramètre SQL Server @nbVoyages en sortie
            SqlParameter paramNbContrats = new SqlParameter("@nbAnime", null);
            paramNbContrats.SqlDbType = SqlDbType.Int;  // On indique que la donnée en sortie est de type int (nécessaire)
            paramNbContrats.Direction = ParameterDirection.Output; // On indique que c'est en sortie (nécessaire)
            myCmk.Parameters.Add(paramNbContrats); // On ajoute ce paramètre dans la commande

            // Utilisation d'un DataReader car il y a plusieurs résultats
            SqlDataReader myRead = myCmk.ExecuteReader();
            while (myRead.Read())
            {
                Console.WriteLine("Prénom: {0} et Nom {1}", myRead["empPrenom"], myRead["empNom"]);

            }
            myRead.Dispose();   // Libérer les ressources ; Important pour avoir la valeur du paramètre SQL Server en sortie 
            // Paramètre en sortie
            Console.WriteLine("Lecture du paramètre en sortie:");
            Console.WriteLine("Il y a {0} anime pour cette destination ", myCmk.Parameters["@nbAnime"].Value);

            Console.ReadLine();
            conn.Close();
        }

        
    }
}
