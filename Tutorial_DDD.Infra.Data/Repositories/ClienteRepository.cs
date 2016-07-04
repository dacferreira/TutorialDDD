using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_DDD.Domain.Entities;
using Tutorial_DDD.Domain.Interfaces.Repositories;

namespace Tutorial_DDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
