using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Reservation.Models;
using Microsoft.AspNetCore.Authorization;

[Authorize(Roles = "Client")]
public class ReservationsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReservationsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Recherche des réservations par ClientId
    public ActionResult IndexByClient(string clientId) // Correction : ClientId est string
    {
        var reservations = _context.Reservations
            .Where(r => r.ClientId == clientId)
            .Include(r => r.Vol) // Inclure le vol associé
            .Include(r => r.Client) // Inclure le client associé
            .ToList();

        if (reservations == null || reservations.Count == 0)
        {
            TempData["Error"] = "Aucune réservation trouvée pour le client.";
            return View();
        }

        return View(reservations);
    }

    // Recherche des réservations par état
    public ActionResult IndexByEtat(EtatReservation etat)
    {
        var reservations = _context.Reservations
            .Where(r => r.Etat == etat)
            .Include(r => r.Client) // Inclure le client
            .Include(r => r.Vol) // Inclure le vol
            .ToList();

        if (reservations == null || reservations.Count == 0)
        {
            TempData["Error"] = $"Aucune réservation trouvée avec l'état {etat}.";
            return View();
        }

        return View(reservations);
    }

    [HttpPost]
    public ActionResult UpdateEtat(int id, EtatReservation nouvelEtat)
    {
        var reservation = _context.Reservations.Find(id);
        if (reservation == null)
        {
            return NotFound();
        }

        reservation.Etat = nouvelEtat;
        _context.SaveChanges();

        return RedirectToAction("IndexByClient", new { clientId = reservation.ClientId });
    }
}
