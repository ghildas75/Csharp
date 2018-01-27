using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGPCSNETLabo6.Models
{
        public static class DbInitializer
        {
            public static void Initialize(Labo6Context context)
            {
                context.Database.EnsureCreated();

                // Look for any Clients.
                if (context.Clients.Any())
                {
                    return;   // DB has been seeded
                }

                var clients = new Client[]
                {
                        new Client { CliPrenom = "Justin", CliNom = "Trudeau", cliDateNaiss = Convert.ToDateTime("2000/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                        new Client { CliPrenom = "Stephen", CliNom = "Harper", cliDateNaiss = Convert.ToDateTime("2001/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                        new Client { CliPrenom = "Pauline", CliNom = "Marois", cliDateNaiss = Convert.ToDateTime("2002/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                        new Client { CliPrenom = "Jean", CliNom = "Charest", cliDateNaiss = Convert.ToDateTime("2003/10/10"), CliRue = "", CliVille = "", CliTelephone = "" }
                };

            foreach (Client c in clients)
            {
                context.Clients.Add(c);
            }
            context.SaveChanges();

        }
    }
}
