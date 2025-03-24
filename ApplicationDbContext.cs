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

        // Ajout des gestionnaires (aucune valeur dynamique)
        modelBuilder.Entity<Gestionnaire>().HasData(
            new Gestionnaire { Id = 1, Nom = "Ali", Code = "GEST123", AnneeRecrutement = 2018 },
            new Gestionnaire { Id = 2, Nom = "Nadia", Code = "GEST456", AnneeRecrutement = 2020 },
            new Gestionnaire { Id = 3, Nom = "Yassine", Code = "GEST789", AnneeRecrutement = 2021 },
            new Gestionnaire { Id = 4, Nom = "Omar", Code = "GEST999", AnneeRecrutement = 2019 },
            new Gestionnaire { Id = 5, Nom = "Sofia", Code = "GEST222", AnneeRecrutement = 2022 }
        );

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
