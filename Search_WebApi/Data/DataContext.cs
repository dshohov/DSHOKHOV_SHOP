using Microsoft.EntityFrameworkCore;
using Search_WebApi.Models;

namespace Search_WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
