using Microsoft.AspNetCore.Mvc;
using Project.Business.Concrete;
using Project.DAL.EF;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
            
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            commentManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
