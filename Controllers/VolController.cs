using Reservation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;





namespace Reservation.Controllers


{
    
    public class VolController : Controller
    {
        private readonly ApplicationDbContext _db;

        
        public VolController(ApplicationDbContext db)
        {
            _db = db;
        }



        [Authorize (Roles = "Admin")]
        public IActionResult Index1()
        {
            List<Vol> volList = _db.Vols.ToList();
            return View(volList);
        }


        [Authorize(Roles = "Client")]
        public IActionResult Index2()
        {
            List<Vol> volList = _db.Vols.ToList();
            return View(volList);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]      
        public IActionResult Create(Vol obj)
        {
            if (obj.Depart== "test1")
            {
                ModelState.AddModelError("Depart", "Test est une valeur invalide");
            }

            if (ModelState.IsValid)
            {
                _db.Vols.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index1");
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Vol? obj = _db.Vols.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Vol obj)
        {
            if (ModelState.IsValid)
            {
                _db.Vols.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index1");
            }

            return View("Edit", obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Vol? obj = _db.Vols.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Vol? obj = _db.Vols.FirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Vols.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index1");
        }
        public ActionResult Index()
        {
            var vols = _db.Vols.ToList();
            return View(vols);
        }
    }

}
