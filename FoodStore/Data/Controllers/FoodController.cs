using FoodStore.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStore.Data.Mocks;
using Microsoft.AspNetCore.Mvc;
using FoodStore.Data.ViewModel;

namespace FoodStore.Data.Controllers
{

    // The controller is added so the routing can easily find the controller without configuration 
    public class FoodController : Controller
    {

        // These parameters are used so the dependency injection
        private readonly ICategoryRepository _categoryRepository;
        private readonly IFoodRepository _foodRepository;

        // The constructor is used in order to inject the services so this way  the dependancy injection proves an instance that goes in the startup of the aplication 
        public FoodController(ICategoryRepository categoryRepository, IFoodRepository foodRepository)
        {
            _categoryRepository = new MockCategoryRepository();
            _foodRepository = foodRepository;
        }

        // First action to return the list of foods 
        public ViewResult FoodList()
        {
            // Tod display temp data from controller to view use the view bag 
            ViewBag.Name = "Checks if dotnet is valid";
            //var foods = _foodRepository.Drinks;
            // The list method is modified to use the view modell instead 
            FoodListViewModel model = new FoodListViewModel();
            model.Foods = _foodRepository.Foods;
            model.CurrentFoodCategory = "FoodCategory";
            return View(model);
        }
    }
}
