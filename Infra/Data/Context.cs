using Microsoft.EntityFrameworkCore;
using teste_dapper.Entidades;

namespace teste_dapper.Infra.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base (options){}
        public DbSet<Cidades> Cidades {get;set;}
        public DbSet<Estados> Estados {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}