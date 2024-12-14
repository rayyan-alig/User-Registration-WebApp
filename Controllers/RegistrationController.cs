using Microsoft.AspNetCore.Mvc;
using RegistrationWeb.Data;
using RegistrationWeb.Models;
using System;

namespace RegistrationWeb.Controllers
{
	public class RegistrationController : Controller
	{
		private readonly ApplicationDBContext _db;


		public RegistrationController(ApplicationDBContext db)
		{
			_db = db;

		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Personal()     // get
		{
			return View();
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Personal(Personal obj)    //post
        {
            if (ModelState.IsValid)
            {
                _db.Personaltable.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "You personal details are saved go to next step";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Retry";
            return View("Personal");

        }

        public IActionResult Education()     // get
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Education(Edu obj)    //post
        {
            if (ModelState.IsValid)
            {
                _db.Edutable.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "You educational details are saved go to next step";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Retry";
            return View("Education");

        }

        public IActionResult PrevEmp()     // get
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PrevEmp(PrevEmp obj)    //post
        {
            if (ModelState.IsValid)
            {
                _db.PrevEmptable.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Your Previous Employer details are saved go to next step";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Retry";
            return View("PrevEmp");

        }

        public IActionResult Assessment()     // get
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Assessment(PersAss obj)    //post
        {
            if (ModelState.IsValid)
            {
                _db.PersAsstable.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Your Personal Assessment details are saved go to next step";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Retry";
            return View("Assessment");

        }

        public IActionResult Declaration()     // get
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Declaration(Declaration obj)    //post
        {
            if (ModelState.IsValid)
            {
                _db.Declarationtable.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Your Registration is done successfully, now you can close this window";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Retry";
            return View("Declaration");

        }
    }
}
