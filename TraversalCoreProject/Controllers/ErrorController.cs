using Microsoft.AspNetCore.Mvc;

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
