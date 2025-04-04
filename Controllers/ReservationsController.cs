﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Reservation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

[Authorize(Roles = "Client")]
public class ReservationsController : Controller
{
    private readonly ApplicationDbContext _db;

    public ReservationsController(ApplicationDbContext db)
    {
        _db = db;
    }


    // Recherche des réservations par ClientId
    public ActionResult IndexByClient(string clientId) // Correction : ClientId est string
    {
        var reservations = _db.Reservations
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
        var reservations = _db.Reservations
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
        var reservation = _db.Reservations.Find(id);
        if (reservation == null)
        {
            return NotFound();
        }

        reservation.Etat = nouvelEtat;
        _db.SaveChanges();

        return RedirectToAction("IndexByClient", new { clientId = reservation.ClientId });
    }

    /*
    
    public ActionResult Reserver(int volId, string clientId)
    {
        var reservation = new Reservations
        {
            ClientId = clientId,
            VolId = volId,
            DateReservation = DateTime.Now,
            Etat = EtatReservation.faite
        };

        _db.Reservations.Add(reservation);
        _db.SaveChanges();

        TempData["Message"] = "Réservation effectuée avec succès!";
        return RedirectToAction("Index", "Vol");
    }*/
    public ActionResult Reserver(int volId)
    {
        string clientId = "ad637f92-9836-45e2-bcc4-e20a73c8bc3c"; // Id du client fixe

        var reservation = new Reservations
        {
            ClientId = clientId,
            VolId = volId,
            DateReservation = DateTime.Now,
            Etat = EtatReservation.faite
        };

        _db.Reservations.Add(reservation);
        _db.SaveChanges();

        TempData["Message"] = "Réservation effectuée avec succès!";
        return RedirectToAction("Index", "Vol");
    }
}

