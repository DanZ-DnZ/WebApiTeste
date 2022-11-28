using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTeste.Data;
using WebApiTeste.Models;

namespace WebApiTeste.Services
{
    public class ClientService : IClientService
    {
        private readonly DataContext _context;

        public ClientService(DataContext context)
        {
            _context = context;
        }

        public void Update<ClientModel>(ClientModel client)
        {
            _context.Update(client);
        }

        public void Add<ClientModel>(ClientModel client)
        {
            _context.Add(client);
        }

        public void Delete<ClientModel>(ClientModel client)
        {
            _context.Remove(client);
        }


        public List<ClientModel> GetClients()
        {
            var clients = _context.FindAsync<ClientModel>("");

            return new List<ClientModel>();
        }

    }
}
