using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult ListComments()
        {
            AdminCommentPageListVM listVM = new AdminCommentPageListVM();
            var commentList = _commentService.TGetCommentsWithDestinations();
            List<AdminCommentVM> comments = commentList.Where(x => x.Status != Project.ENTITIES.Enums.DataStatus.Deleted).Select(x => new AdminCommentVM
          {
              ID = x.ID,

              DestinationID = x.DestinationID,
              DestinationName = x.Destination.City,
              CommentContent = x.CommentContent,
              CommentUser = x.CommentUser,
              CreatedDate = x.CreatedDate.ToString(),
              Status = x.Status.ToString(),
              CommentReply =x.CommentReply


          }).ToList();
            listVM.Comments = comments;
            return View(listVM);
        }
        public IActionResult DeleteComment(int id)
        {
            var comment = _commentService.TFind(id);
            if (comment!=null)
            {
                _commentService.TDestroy(comment);
                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";

                return Redirect("/Admin/Comment/ListComments");


            }
            ModelState.AddModelError("Hata", "Islem basarisiz olmustur.");

            return Redirect("/Admin/Comment/ListComments");


        }
        [HttpGet]
        public IActionResult ReplyComment(int id)
        {
           // var comment = _commentService.TFind(id);

            return View();
        }
        [HttpPost]
        public IActionResult ReplyComment(AdminCommentVM p)
        {
            Comment toBeUpdated = _commentService.TFind(p.ID);
            if (toBeUpdated !=null)
            {
                toBeUpdated.CommentReply = p.CommentReply;
                _commentService.TUpdate(toBeUpdated);
                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";

                return Redirect("/Admin/Comment/ListComments");
            }
            ModelState.AddModelError("Hata", "Islem basarisiz olmustur.");

            return Redirect("/Admin/Comment/ListComments");
        }
    }
}
