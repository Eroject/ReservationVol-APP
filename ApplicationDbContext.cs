using Microsoft.EntityFrameworkCore;
using Reservation.Models;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Vol> Vols { get; set; }
    public DbSet<Gestionnaire> Gestionnaires { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Reservations> Reservations { get; set; }

}
