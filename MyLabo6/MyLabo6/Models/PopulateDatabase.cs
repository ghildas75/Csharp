using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGPCSNETLabo6.Models
{
    public static class PopulateDatabase
    {

        //private static Labo6Context _context;

        //public PopulateDatabase(Labo6Context context)
        //{
        //    _context = context;
        //}

        public static void EnsurePopulated(Labo6Context context)
        {
            context.Database.EnsureCreated();
            //Labo6Context context = app.ApplicationServices
            //    .GetRequiredService<Labo6Context>();
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client { CliPrenom = "Justin", CliNom = "Trudeau", cliDateNaiss = Convert.ToDateTime("2000/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                    new Client { CliPrenom = "Stephen", CliNom = "Harper", cliDateNaiss = Convert.ToDateTime("2001/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                    new Client { CliPrenom = "Pauline", CliNom = "Marois", cliDateNaiss = Convert.ToDateTime("2002/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
                    new Client { CliPrenom = "Jean", CliNom = "Charest", cliDateNaiss = Convert.ToDateTime("2003/10/10"), CliRue = "", CliVille = "", CliTelephone = "" }
                );

                context.SaveChanges();
            }
        }
    }
}
