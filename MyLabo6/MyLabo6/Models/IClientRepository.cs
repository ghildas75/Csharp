using System.Collections.Generic;

namespace GGPCSNETLabo6.Models
{
    public interface IClientRepository
    {
        Client create();
        void SaveClient();
        void deleteClient(int clientID);
        void  InsertClient(Client client);
        IEnumerable<Client> Clients { get; }
    }
}
