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
            List<AdminContactMeVM> values = _contactMeService.TGetList().Where(x=>x.Status != Project.ENTITIES.Enums.DataStatus.Deleted).Select(x => new AdminContactMeVM
            {

                ID = x.ID,
                Name = x.Name,
                Subject = x.Subject,
                Mail = x.Mail,
                Status = x.Status.ToString(),
                CreatedDate = x.CreatedDate.ToString(),
                MessageBody = x.MessageBody
            }).ToList();

            return View(values);
        }
        public IActionResult ListDeletedMessages()
        {
            List<AdminContactMeVM> values = _contactMeService.TGetList().Where(x => x.Status == Project.ENTITIES.Enums.DataStatus.Deleted).Select(x => new AdminContactMeVM
            {

                ID = x.ID,
                Name = x.Name,
                Subject = x.Subject,
                Mail = x.Mail,
                Status = x.Status.ToString(),
                CreatedDate = x.CreatedDate.ToString(),
                MessageBody = x.MessageBody
            }).ToList();

            return View(values);
        }
        public IActionResult MessageInfo(int id)
        {
            var message = _contactMeService.TFind(id);

            AdminContactMeVM viewModel = new AdminContactMeVM
            {
                ID = message.ID,
                Name = message.Name,
                Subject = message.Subject,
                Mail = message.Mail,
                Status = message.Status.ToString(),
                CreatedDate = message.CreatedDate.ToString(),
                MessageBody = message.MessageBody
            };

            return View(viewModel);
        }
        public IActionResult DeleteContactMessage(int id)
        {
            _contactMeService.TDelete(_contactMeService.TFind(id));

            return Redirect("/Admin/ContactMe/ListContactMe");
        }
    }
}
