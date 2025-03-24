using Reservation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;




namespace Reservation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class GestionnaireController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;


        public GestionnaireController(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            List<Gestionnaire> gestionnaireList = _db.Gestionnaires.ToList();
            return View(gestionnaireList);
        }


        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(Gestionnaire obj)
        {
            if (obj.Nom == "test")
            {
                ModelState.AddModelError("Nom", "Test est une valeur invalide");
            }

            if (ModelState.IsValid)
            {
                _db.Gestionnaires.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Gestionnaire? obj = _db.Gestionnaires.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Gestionnaire obj)
        {
            if (ModelState.IsValid)
            {
                _db.Gestionnaires.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Edit", obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Gestionnaire? obj = _db.Gestionnaires.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Gestionnaire? obj = _db.Gestionnaires.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Gestionnaires.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
