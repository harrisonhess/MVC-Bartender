using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Bartender.Models;

namespace MVC_Bartender.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDrinkRepo _drinkRepo;

        public HomeController(ILogger<HomeController> logger, IDrinkRepo drinkRepo)
        {
            _logger = logger;
            _drinkRepo = drinkRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            ViewData.Model = _drinkRepo.getDrinks();
            return View();
        }

        [HttpGet]
        public IActionResult DrinkDetails(int id)
        {
            ViewData.Model = _drinkRepo.getDrink(id);
            return View();
        }

        [HttpGet]
        public IActionResult EditDrink(int id)
        {
            ViewData.Model = _drinkRepo.getDrink(id);
            return View();
        }

        [HttpPost]
        public IActionResult SaveDrink(Drink drink)
        {
            _drinkRepo.SaveDrink(drink);
            return RedirectToAction("Menu");
        }

        public IActionResult DeleteDrink(int id)
        {
            _drinkRepo.DeleteDrink(id);
            return RedirectToAction("Menu");
        }

        [HttpPost]
        public IActionResult CreateDrink(Drink drink)
        {
            _drinkRepo.createDrink(drink);
            return RedirectToAction("Menu");
        }

        public IActionResult CreateDrink()
        {
            return View();
        }
    }
}
