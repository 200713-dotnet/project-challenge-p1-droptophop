using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
    public class UserController : Controller
    {
        public PizzaStoreDbContext _db;



        public UserController(PizzaStoreDbContext _dbContext)
        {
            _db = _dbContext;
        }

        public IActionResult Login(StoreViewModel sModel)
        {
            if(sModel.isAdmin)
            {
                return View("Store", sModel);
            }

            ViewBag.Location = sModel.Location;
            return View("Login");
        }
    }
}