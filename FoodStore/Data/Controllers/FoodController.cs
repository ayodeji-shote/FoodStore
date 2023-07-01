using FoodStore.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStore.Data.Mocks;
using Microsoft.AspNetCore.Mvc;

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
        public ViewResult List()
        {
            var foods = _foodRepository.Foods;
            return View(foods);
        }
    }
}
