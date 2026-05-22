using Microsoft.EntityFrameworkCore;

namespace API_CRUD_Repo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
