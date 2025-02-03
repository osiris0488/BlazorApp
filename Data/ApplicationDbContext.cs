
using Microsoft.EntityFrameworkCore;
using BlazorApp.Models;
using BlazorApp.Services;
using BlazorApp.Models.BlazorApp.Models;
namespace MiBlazorApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cita> Citas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Barbero> Barberos { get; set; }
    }
}