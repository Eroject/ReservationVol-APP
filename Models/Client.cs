using Microsoft.AspNetCore.Identity;
using Reservation.Models;
using System.ComponentModel.DataAnnotations;

public class Client : IdentityUser
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string CIN { get; set; }
    public int Age { get; set; }

    public virtual List<Reservations> Reservations { get; set; } = new();

}
