using Microsoft.EntityFrameworkCore;

using MySqlWithEntityFramework.EF.Models;

namespace MySqlWithEntityFramework.EF;
public class ApplicationContext : DbContext {
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    public DbSet<Laptop> Laptops { get; set; }
}
