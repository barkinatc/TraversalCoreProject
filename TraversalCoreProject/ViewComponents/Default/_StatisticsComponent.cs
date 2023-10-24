using Microsoft.AspNetCore.Mvc;
using Project.DAL.Context;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using MyContext c = new MyContext();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "200";

            return View();
        }
    }
}
