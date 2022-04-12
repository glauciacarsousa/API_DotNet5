using ApiGlauciaEstagio.Models;
using Microsoft.EntityFrameworkCore;




namespace ApiGlauciaEstagio.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> cliente { get; set; }
        
        
    }
}