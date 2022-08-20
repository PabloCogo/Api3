using Api.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        public DbSet<Livros> Livros { get; set; }
        
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
            
    }
}
