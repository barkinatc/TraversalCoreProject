using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.ENTITIES.Concrete;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller

    {
      private readonly  IAbout2Service _about2Service;

        public MessageController(IAbout2Service about2Service)
        {
            _about2Service = about2Service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(About2 p)
        {
            About2 about2 = new About2();
            about2.Title1 = p.Title1;
            _about2Service.TAdd(about2);
            return View();
        }

    }
}
