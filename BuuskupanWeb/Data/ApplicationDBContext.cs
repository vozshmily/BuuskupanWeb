using BuuskupanWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BuuskupanWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}