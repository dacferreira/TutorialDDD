using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Tutorial_DDD.Domain.Entities;
using Tutorial_DDD.Infra.Data.EntityConfig;

namespace Tutorial_DDD.Infra.Data.Contexto
{
    public class TutorialContexto : DbContext
    {
        public TutorialContexto()
                :base("TutorialDDD")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Para não ficar plurazizando as tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();// para não remover em cascatas, quando tiver uma ligação de um para muitos 1 - N
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Dizendo que toda vez que a propriedade estiver Id no final, considerar ela como chave primária.
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                 .Configure(p => p.IsKey());

            //Tudo que for string estrará no Banco como varchar que ocupa duas vezes menos espaço
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //Configurar o tamanho para 100, para não ficar o tamanho maximo, quando não passar o maxlength na propriedade
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        public override int SaveChanges()
        {
            // dando foreach on estiver com evento de mudança na entidade 
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                
                //uma vez cadastrado, não pode mudar
                if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = false;
            }
            return base.SaveChanges();
        }
    }
}