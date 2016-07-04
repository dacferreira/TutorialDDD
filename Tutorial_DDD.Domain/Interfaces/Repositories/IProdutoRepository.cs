using System.Collections.Generic;
using Tutorial_DDD.Domain.Entities;

namespace Tutorial_DDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
