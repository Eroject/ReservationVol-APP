using Reservation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;


public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
    {
    }

    public DbSet<Vol> Vols { get; set; }
    public DbSet<Gestionnaire> Gestionnaires { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Reservations> Reservations { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
      

        // Ajout des vols avec des dates fixes
        modelBuilder.Entity<Vol>().HasData(
            new Vol { Id = 1, Destination = "Paris", Depart = "Casablanca", DateArrivee = new DateTime(2024, 6, 15), Prix = 1500, NombrePlacesMax = 200, PlacesDisponibles = 50 },
            new Vol { Id = 2, Destination = "New York", Depart = "Marrakech", DateArrivee = new DateTime(2024, 7, 10), Prix = 3500, NombrePlacesMax = 300, PlacesDisponibles = 100 },
            new Vol { Id = 3, Destination = "Dubai", Depart = "Rabat", DateArrivee = new DateTime(2024, 8, 5), Prix = 2500, NombrePlacesMax = 250, PlacesDisponibles = 150 },
            new Vol { Id = 4, Destination = "Tokyo", Depart = "Casablanca", DateArrivee = new DateTime(2024, 9, 15), Prix = 4500, NombrePlacesMax = 150, PlacesDisponibles = 80 },
            new Vol { Id = 5, Destination = "London", Depart = "Marrakech", DateArrivee = new DateTime(2024, 12, 1), Prix = 2000, NombrePlacesMax = 180, PlacesDisponibles = 60 }
        );

      
    }
}
