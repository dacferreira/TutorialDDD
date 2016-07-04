using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_DDD.Domain.Entities;
using Tutorial_DDD.Domain.Interfaces.Repositories;
using Tutorial_DDD.Domain.Interfaces.Services;

namespace Tutorial_DDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepositor;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            
        }

        //todo video em 2 horas e dois minutos 
        //https://www.youtube.com/watch?v=i9Il79a2uBU
        //http://eduardopires.net.br/2014/10/tutorial-asp-net-mvc-5-ddd-ef-automapper-ioc-dicas-e-truques/
    }
}
