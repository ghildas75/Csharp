using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGPCSNETLabo6.Models
{
    public class ClientEFRepository : IClientRepository
    {
        private Labo6Context _context;

        public ClientEFRepository(Labo6Context context)
        {
            _context = context;
        }

        IEnumerable<Client> IClientRepository.Clients => _context.Clients;

        public Client create()
        {
            throw new NotImplementedException();
        }

        public void deleteClient(int clientID)
        {
            Client client=_context.Clients.Find(clientID);
            _context.Remove(client);
        }

        public void InsertClient(Client client)
        {
            _context.Clients.Add(client);
        }
        public void SaveClient()
        {
            _context.SaveChanges();
        }
    }
}


//IEnumerable<Client> IClientRepository.Clients => throw new NotImplementedException();

//IEnumerable<Client> Clients()
//{
//    return _context.Clients;
//}