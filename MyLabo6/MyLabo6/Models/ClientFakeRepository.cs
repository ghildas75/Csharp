using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGPCSNETLabo6.Models
{
    public class ClientFakeRepository : IClientRepository
    {
        public IEnumerable<Client> Clients => new List<Client> {
            new Client { CliPrenom = "Justin", CliNom = "Trudeau", cliDateNaiss = Convert.ToDateTime("2000/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
            new Client { CliPrenom = "Stephen", CliNom = "Harper", cliDateNaiss = Convert.ToDateTime("2001/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
            new Client { CliPrenom = "Pauline", CliNom = "Marois", cliDateNaiss = Convert.ToDateTime("2002/10/10"), CliRue = "", CliVille = "", CliTelephone = "" },
            new Client { CliPrenom = "Jean", CliNom = "Charest", cliDateNaiss = Convert.ToDateTime("2003/10/10"), CliRue = "", CliVille = "", CliTelephone = "" }
        };

        IEnumerable<Client> IClientRepository.Clients => throw new NotImplementedException();
        public void deleteClient(int clientID) { }
        
        Client IClientRepository.create()
        {
            throw new NotImplementedException();
        }
        public  void SaveClient()
        {
           
        }

        public void InsertClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
