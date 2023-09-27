using Microsoft.AspNetCore.Mvc;
using Project.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using Context c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "200";

            return View();
        }
    }
}
