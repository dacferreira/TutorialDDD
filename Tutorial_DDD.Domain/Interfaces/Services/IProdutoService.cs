using System.Collections.Generic;
using Tutorial_DDD.Domain.Entities;

namespace Tutorial_DDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
