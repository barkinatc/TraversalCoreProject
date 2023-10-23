using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.ENTITIES.Concrete;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult ListGuides()
        {
            List<AdminGuideVM> guides = _guideService.TGetList().Select(x => new AdminGuideVM
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                Status = x.Status.ToString()
            }).ToList();
            return View(guides);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {



            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(AdminGuideVM p)
        {
            if (ModelState.IsValid)
            {
                Guide guide = new Guide
                {
                    Name = p.Name,
                    Description = p.Description
                };




                _guideService.TAdd(guide);


                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";
                return Redirect("/Admin/Guide/ListGuides");
            }
            ModelState.AddModelError("Hata", "Islem basarisiz olmustur.");

            return View();
        }
        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            var guide = _guideService.TWhere(x => x.ID == id).Select(x => new AdminGuideVM
            {
                ID = x.ID,
                Status = x.Status.ToString(),
                Description = x.Description,
                Name = x.Name


            }).FirstOrDefault();
            return View(guide);
        }
        [HttpPost]
        public IActionResult UpdateGuide(AdminGuideVM guideVM)
        {

            Guide toBeUpdated = _guideService.TFind(guideVM.ID);
            if (toBeUpdated != null)
            {
                toBeUpdated.ID = guideVM.ID;

                toBeUpdated.Description = guideVM.Description;
                toBeUpdated.Name = guideVM.Name;

                _guideService.TUpdate(toBeUpdated);
                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";

                return Redirect("/Admin/Guide/ListGuides");
            }
            ModelState.AddModelError("Hata", "Islem basarisiz olmustur.");

            return View();


        }
        public IActionResult ActiveGuide(int id)
        {
            _guideService.ActiveGuide(id);

            return Redirect("/Admin/Guide/ListGuides");

        }
        public IActionResult DeleteGuide(int id)
        {
            //_guideService.TDelete(_guideService.TFind(id));
            var user = _guideService.TFind(id);
            _guideService.TDelete(user);

            if (user != null)
            {
                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";
                return Redirect("/Admin/Guide/ListGuides");


            }
            ModelState.AddModelError("Hata", "Islem basarisiz olmustur.");

            return Redirect("/Admin/Guide/ListGuides");
        }
    }
}
