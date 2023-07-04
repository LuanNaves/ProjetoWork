using Microsoft.EntityFrameworkCore;
using ProjetoFinalAtos.Models;

namespace ProjetoFinalAtos.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Models.ServiceProviders> ServiceProviders { get; set; }
        public DbSet<ServiceCategories> ServiceCategories { get; set; }
        public DbSet<Services> Services { get; set; }

    }
}