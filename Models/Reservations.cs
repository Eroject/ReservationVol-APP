using System.ComponentModel.DataAnnotations.Schema;

namespace Reservation.Models

{  
    public class Reservations
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")] 
        public Client Client { get; set; }

        
        public int VolId { get; set; }
        [ForeignKey("VolId")] 
        public Vol Vol { get; set; }

       
        public EtatReservation Etat { get; set; }
        public DateTime DateReservation { get; set; }
    }
    public enum EtatReservation
    {
        faite,
        Confirmee,
        Annulee
    }
}
