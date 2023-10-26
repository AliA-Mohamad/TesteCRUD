using Microsoft.EntityFrameworkCore;
using TesteCRUD.Models;

namespace TesteCRUD.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

    public DbSet<ReservasModel> Reservas { get; set; }
}
