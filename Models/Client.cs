namespace Reservation.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public int Age { get; set; }
        public List<Reservations> Reservations { get; set; } = new();
    }
}
