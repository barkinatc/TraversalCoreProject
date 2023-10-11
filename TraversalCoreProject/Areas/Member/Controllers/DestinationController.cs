using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Concrete;
using Project.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        

        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        public IActionResult ListDestinations()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
