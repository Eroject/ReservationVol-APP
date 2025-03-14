namespace Reservation.Models
{
    public class Vol
    {
        public int Id { get; set; }
    public string Destination { get; set; }
    public string Depart { get; set; }
    public DateTime DateArrivee { get; set; }
    public decimal Prix { get; set; }
    public int NombrePlacesMax { get; set; }
    public int PlacesDisponibles { get; set; }
    public List<Reservations> Reservations { get; set; } = new();
    }
}
