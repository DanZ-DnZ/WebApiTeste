using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTeste.Models;

namespace WebApiTeste.Services
{
    public interface IClientService
    {
        void Add<ClientModel>(ClientModel client);

        List<ClientModel> GetClients();

        void Delete<ClientModel>(ClientModel client);

        void Update<ClientModel>(ClientModel client);
    }
}
