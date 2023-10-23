using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentListComponent : ViewComponent
    {
        private readonly ICommentService _commentService;
        public _CommentListComponent(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke(int id)
        {

            var value = _commentService.TGetDestinationByID(id);
            List<CommentVM> comments = value.Select(x => new CommentVM
            {
                ID = x.ID,
                CommentContent = x.CommentContent,
                CommentReply = x.CommentReply,
                CommentUser = x.CommentUser,
                CreatedDate = x.CreatedDate.ToString(),
                ModifedDate = x.ModifiedDate.ToString()
            }).ToList();
            return View(comments);
        }
    }
}
