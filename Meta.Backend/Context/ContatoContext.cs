using Meta.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Meta.Backend.Context
{
    public class ContatoContext : DbContext
    {
        
        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
