using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;
using LuckySpin.Services;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        //DIJ in 4 STEPS -
        //Step 0) Register the Repository class as a Singleton Service in Program.cs 
        //TODO: Step 1) add an instance variable here of type Repository

        private Repository _repository;

        //TODO: Step 2) Include the DIJ repository to be passed as a parameter to the constructor
        public SpinnerController(Repository repository, Player player)
        {
            //TODO: Step 3) Assign the DIJ repository to the instance variable to use in Controller Actions
            _repository = repository;
        }
        /***
         * Index Action (GET and POST)
         **/
        [HttpGet]
        public IActionResult Index() { return View(); }
        [HttpPost]
        public IActionResult Index(Player player)
        {
            if (!ModelState.IsValid) { return View(player); } //Server-side validation check of user input against Player Model

            //TODO: Add the  player from the [HttpPost] data to the repository
            _repository.AddPlayer(player);

            //TODO: Instead of returning a View, return a Redirect to Spin Action to perform a Spin 
            return RedirectToAction("Spin", player);
        }
        /***
         * Spin Action (GET only)
         **/
        [HttpGet]
        public IActionResult Spin(Player player)
        {
            // TODO: Create a new Spin instance and add it to the repository
            Spin s = new Spin();
            _repository.AddSpin(s);

            // TODO: Pass the latest Spin to the Spin View
            return View("Spin", s);
        }
        /***
         * ListSpins Action (GET only)
         **/
        [HttpGet]
        public IActionResult LuckList()
        {
            //TODO: Pass the repository to the LuckList View
            return RedirectToAction("LuckList", _repository);
        }

    }
}

