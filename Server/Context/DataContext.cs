using Microsoft.EntityFrameworkCore;

namespace BlazorWASMPractice.Server.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Bank> banks { get; set; }
    }
}
