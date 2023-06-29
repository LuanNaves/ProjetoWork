using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Models;

namespace ProjetoFinalAtos.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
            
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Models.ServiceProvider> ServiceProviders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCategories> ServicesCategories { get; set; }

    }
}