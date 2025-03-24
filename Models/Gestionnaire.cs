using System.ComponentModel.DataAnnotations;

namespace Reservation.Models
{
    public class Gestionnaire
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Code { get; set; }
        public int AnneeRecrutement { get; set; }
    }
}
