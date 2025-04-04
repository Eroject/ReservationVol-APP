﻿using Reservation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;




namespace Reservation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ClientController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;


        public ClientController(ApplicationDbContext db , UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            List<Client> clientList = _db.Clients.ToList();
            return View(clientList);
        }


        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(Client obj)
        {
            if (obj.Nom == "test")
            {
                ModelState.AddModelError("Nom", "Test est une valeur invalide");
            }

            if (ModelState.IsValid)
            {
                _db.Clients.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Edit(string? id)
        {
            if (id == null || id == "0")
            {
                return NotFound();
            }

            Client? obj = _db.Clients.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Edit", obj);
        }

        public IActionResult Delete(string? id)
        {
            if (id == null || id == "0")
            {
                return NotFound();
            }

            Client? obj = _db.Clients.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(string? id)
        {
            Client? obj = _db.Clients.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Clients.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
