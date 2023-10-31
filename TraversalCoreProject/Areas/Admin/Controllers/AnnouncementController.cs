
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.ENTITIES.Concrete;
using Project.VM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
       private readonly IAnnouncementService _announcementService;
       

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
            
        }

        public IActionResult ListAnnouncements()
        {

            List<AdminAnnouncementVM> values = _announcementService.TGetList().Where(x=>x.Status != Project.ENTITIES.Enums.DataStatus.Deleted).Select(x=> new AdminAnnouncementVM 
            {
            ID =x.ID,
            Title =x.Title,
            Content =x.Content,
             CreateDate = x.CreatedDate.ToString("dd.MM.yyyy")

            }).ToList();
            
            return View(values);
        }
         
        [HttpGet]

        public   IActionResult AddAnnouncement()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AdminAnnouncementVM p)
        {
            Announcement announcement = new Announcement
            {
                Content =p.Content,
                Title =p.Title
            };
            _announcementService.TAdd(announcement); 
            return Redirect("Admin/Announcement/ListAnnouncements");
        }

        [HttpGet]

        public IActionResult UpdateAnnouncement(int id)
        {
            AdminAnnouncementVM annoncement = _announcementService.TWhere(x => x.ID == id).Select(x => new AdminAnnouncementVM
            {
                ID = x.ID,
                Content = x.Content,
                Title = x.Title
            }).FirstOrDefault();

            return View(annoncement);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AdminAnnouncementVM p)
        {
            Announcement toBeUpdated = _announcementService.TFind(p.ID);
            toBeUpdated.Title = p.Title;
            toBeUpdated.Content = p.Content;

            _announcementService.TUpdate(toBeUpdated);
                
            return Redirect("/Admin/Announcement/ListAnnouncements");

        }
        public IActionResult DeleteAnnouncement(int id)
        {
            _announcementService.TDelete(_announcementService.TFind(id));
            return Redirect("/Admin/Announcement/ListAnnouncements");

        }
        //public IActionResult AnnouncementDetail(int id)
        //{

        //    return View();
        //}

    }
}
