using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data;

namespace Web.Controllers
{
    public class GroupController : Controller
    {
        private ApplicationDbContext _applicationDbContext;

        public GroupController(ApplicationDbContext applicationDbContext) 
        {
           _applicationDbContext = applicationDbContext;
        }



        public IActionResult Index()
        {
            List<YC.Model.Group> groups = _applicationDbContext.Groups.ToList();





            return View(groups);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}