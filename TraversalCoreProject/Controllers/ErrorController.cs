using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}
