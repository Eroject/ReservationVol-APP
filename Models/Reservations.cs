using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservation.Models
{
    public class Reservations
    {
        [Key]
        public int Id { get; set; }

        // Clé étrangère vers Client
        [Required]
        [ForeignKey("ClientId")]
        public string ClientId { get; set; }
        public virtual Client Client { get; set; }

        // Clé étrangère vers Vol
        [Required]
        [ForeignKey("VolId")]
        public int VolId { get; set; }
        public virtual Vol Vol { get; set; }

        [Required]
        public EtatReservation Etat { get; set; }

        [Required]
        public DateTime DateReservation { get; set; }
    }

    public enum EtatReservation
    {
        faite,
        Confirmee,
        Annulee
    }
}
