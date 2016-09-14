using System;
using System.Globalization;
using System.Web.Mvc;
using ServiceStation.Models.Entity;
using ServiceStation.Models.Service;

namespace ServiceStation.Controllers
{
    [Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        private readonly IAdminService _adminService;

        public HomeController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public ActionResult Index()
        {
            return View(_adminService.Load());
        }

        public ActionResult LoadCar()
        {
            return View(_adminService.LoadCar());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        // GET: Client
        public ActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClient(string date, Client addClient)
        {
           if (ModelState.IsValid)
            {
                _adminService.Add(addClient);
                return RedirectToAction("Index");
            }
            return View(addClient);
        }
        [HttpGet]
        // GET: Client
        public ActionResult AddCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCar(Car addCar)
        {
            if (ModelState.IsValid)
            {
                _adminService.Add(addCar);
                return RedirectToAction("LoadCar");
            }
            return View(addCar);
        }
        [HttpGet]
        public ActionResult DeleteClient(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var model = _adminService.Get(id.Value);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeleteClient(int id)
        {
            _adminService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteCar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("LoadCar");
            }

            var model = _adminService.GetCar(id.Value);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeleteCar(int id)
        {
            _adminService.DeleteCar(id);
            return RedirectToAction("LoadCar");
        }
        [HttpGet]
        public ActionResult EditClient(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var model = _adminService.Get(id.Value);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditClient(Client editClient)
        {
            if (ModelState.IsValid)
            {
                _adminService.Edit(editClient);
                return RedirectToAction("Index");
            }

            return View("Index");
        }
        [HttpGet]
        public ActionResult EditCar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("LoadCar");
            }

            var model = _adminService.GetCar(id.Value);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditCar(Car editCar)
        {
            if (ModelState.IsValid)
            {
                _adminService.EditCar(editCar);
                return RedirectToAction("LoadCar");
            }

            return View("LoadCar");
        }

    }
}