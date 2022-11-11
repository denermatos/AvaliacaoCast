using Microsoft.EntityFrameworkCore;
using ProjetoConta.Api.Models;

namespace ProjetoConta.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }

        public DbSet<Conta> Conta { get; set; } 
    }
}
