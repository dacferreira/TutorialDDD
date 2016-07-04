using System;
using System.Collections.Generic;
using System.Linq;
using Tutorial_DDD.Domain.Entities;
using Tutorial_DDD.Domain.Interfaces.Repositories;

namespace Tutorial_DDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome.Equals(nome));                    
        }
    }
}
