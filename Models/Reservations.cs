namespace Reservation.Models

{  
    public class Reservations
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int VolId { get; set; }
        public Vol Vol { get; set; }
        public EtatReservation Etat { get; set; } // État de la réservation
        public DateTime DateReservation { get; set; }
    }
    public enum EtatReservation
    {
        EnAttente,
        Confirmee,
        Annulee
    }
}
