using FoodStore.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStore.Data.Mocks;
using Microsoft.AspNetCore.Mvc;
using FoodStore.Data.ViewModel;

namespace FoodStore.Controllers
{

    // The controller is added so the routing can easily find the controller without configuration 
    public class DrinkController : Controller
    {

        // These parameters are used so the dependency injection
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        // The constructor is used in order to inject the services so this way  the dependancy injection proves an instance that goes in the startup of the aplication 
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = new MockCategoryRepository();
            _drinkRepository = new MockDrinkRepository();
        }

        // First action to return the list of drinks, the view result is used to call a view named list
        public ViewResult DrinkList()
        {
            // Tod display temp data from controller to view use the view bag 
            ViewBag.Name = "Checks if dotnet is valid";
            //var drinks = _drinkRepository.Drinks;
            // The list method is modified to use the view modell instead 
            DrinkListViewModel model = new DrinkListViewModel();
            model.Drinks = _drinkRepository.Drinks;
            model.CurrentDrinkCategory = "DrinkCategory";
            return View(model);
        }
    }
}
