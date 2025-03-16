using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reservation.Models
{
    public class Vol
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Destination du vol")]
        [Required(ErrorMessage = "Veuillez entrer la destination du vol")]
        public string Destination { get; set; }

        [DisplayName("Départ du vol")]
        [Required(ErrorMessage = "Veuillez entrer le départ du vol")]
        public string Depart { get; set; }

        [DisplayName("Date d'arrivée")]
        [Required(ErrorMessage = "Veuillez entrer la date d'arrivée")]
        public DateTime DateArrivee { get; set; }

        [DisplayName("Prix du vol")]
        [Required(ErrorMessage = "Veuillez entrer le prix du vol")]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix doit être un nombre positif")]
        public int Prix { get; set; }

        [DisplayName("Nombre de places maximum")]
        [Required(ErrorMessage = "Veuillez entrer le nombre de places maximum")]
        [Range(1, int.MaxValue, ErrorMessage = "Le nombre de places doit être supérieur à 0")]
        public int NombrePlacesMax { get; set; }

        [DisplayName("Places disponibles")]
        [Required(ErrorMessage = "Veuillez entrer le nombre de places disponibles")]
        [Range(0, int.MaxValue, ErrorMessage = "Le nombre de places disponibles ne peut pas être négatif")]
        public int PlacesDisponibles { get; set; }

        public List<Reservations> Reservations { get; set; } = new();
    }
}
