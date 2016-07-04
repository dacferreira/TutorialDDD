using System;
using System.Collections.Generic;

namespace Tutorial_DDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }
        /// <summary>
        /// Regra de Négocio: Cliente deve ter pelo menos 5 anos de cadastro.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
