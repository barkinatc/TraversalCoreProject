using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ContactMeController : Controller
    {

        private readonly IContactMeService _contactMeService;

        public ContactMeController(IContactMeService contactMeService)
        {
            _contactMeService = contactMeService;
        }

        public IActionResult ListContactMe()
        {
            //List<AdminContactMeVM> values = _contactMeService.TGetList()
            return View();
        }
    }
}
