using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
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
      private readonly  IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult ListAnnouncements()
        {

            List<AdminAnnouncementVM> values = _announcementService.TGetList().Select(x=> new AdminAnnouncementVM 
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
        public IActionResult AddAnnouncement(string x)
        {
            return View();
        }
    }
}
