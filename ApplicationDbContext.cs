using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Gestionnaire>().HasData(
        new Gestionnaire { Id = 1, Nom = "Ali", Code = "GEST123", AnneeRecrutement = 2018 },
        new Gestionnaire { Id = 2, Nom = "Nadia", Code = "GEST456", AnneeRecrutement = 2020 },
        new Gestionnaire { Id = 3, Nom = "Yassine", Code = "GEST789", AnneeRecrutement = 2021 },
        new Gestionnaire { Id = 4, Nom = "Omar", Code = "GEST999", AnneeRecrutement = 2019 },
        new Gestionnaire { Id = 5, Nom = "Sofia", Code = "GEST222", AnneeRecrutement = 2022 }
    );

        // Ajout des vols
        modelBuilder.Entity<Vol>().HasData(
            new Vol { Id = 1, Destination = "Paris", Depart = "Casablanca", DateArrivee = new DateTime(2024, 6, 15), Prix = 1500, NombrePlacesMax = 200, PlacesDisponibles = 50 },
            new Vol { Id = 2, Destination = "New York", Depart = "Marrakech", DateArrivee = new DateTime(2024, 7, 10), Prix = 3500, NombrePlacesMax = 300, PlacesDisponibles = 100 },
            new Vol { Id = 3, Destination = "Dubai", Depart = "Rabat", DateArrivee = new DateTime(2024, 8, 5), Prix = 2500, NombrePlacesMax = 250, PlacesDisponibles = 150 },
            new Vol { Id = 4, Destination = "Tokyo", Depart = "Casablanca", DateArrivee = new DateTime(2024, 9, 15), Prix = 4500, NombrePlacesMax = 150, PlacesDisponibles = 80 },
            new Vol { Id = 5, Destination = "London", Depart = "Marrakech", DateArrivee = new DateTime(2024, 12, 1), Prix = 2000, NombrePlacesMax = 180, PlacesDisponibles = 60 }
        );

        // Ajout des clients (ajouter plus de clients avec des données statiques)
        modelBuilder.Entity<Client>().HasData(
            new Client { Id = 1, Nom = "ClientNom1", Prenom = "ClientPrenom1", CIN = "CIN1", Age = 30 },
            new Client { Id = 2, Nom = "ClientNom2", Prenom = "ClientPrenom2", CIN = "CIN2", Age = 32 },
            new Client { Id = 3, Nom = "ClientNom3", Prenom = "ClientPrenom3", CIN = "CIN3", Age = 28 },
            new Client { Id = 4, Nom = "ClientNom4", Prenom = "ClientPrenom4", CIN = "CIN4", Age = 45 }
        // Ajoutez plus de clients statiquement si nécessaire
        );

        // Ajout des réservations avec des valeurs fixes pour éviter la dynamique
        modelBuilder.Entity<Reservations>().HasData(
            new Reservations { Id = 1, ClientId = 1, VolId = 1, Etat = EtatReservation.Confirmee, DateReservation = new DateTime(2024, 5, 20) },
            new Reservations { Id = 2, ClientId = 2, VolId = 2, Etat = EtatReservation.faite, DateReservation = new DateTime(2024, 5, 25) },
            new Reservations { Id = 3, ClientId = 3, VolId = 3, Etat = EtatReservation.Confirmee, DateReservation = new DateTime(2024, 6, 10) },
            new Reservations { Id = 4, ClientId = 4, VolId = 4, Etat = EtatReservation.faite, DateReservation = new DateTime(2024, 6, 12) },
            new Reservations { Id = 5, ClientId = 4, VolId = 3, Etat = EtatReservation.faite, DateReservation = new DateTime(2024, 6, 12) },
            new Reservations { Id = 6, ClientId = 4, VolId = 2, Etat = EtatReservation.faite, DateReservation = new DateTime(2024, 6, 12) },
            new Reservations { Id = 7, ClientId = 4, VolId = 1, Etat = EtatReservation.faite, DateReservation = new DateTime(2024, 6, 12) },
            new Reservations { Id = 8, ClientId = 4, VolId = 4, Etat = EtatReservation.faite, DateReservation = new DateTime(2024, 6, 12) }
        );
    }
}
