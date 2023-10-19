using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentListComponent:ViewComponent
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
                ID =x.ID,
                CommentContent= x.CommentContent,
                CommentReply = x.CommentReply,
                CommentUser = x.CommentUser,
                CreatedDate = x.CreatedDate.ToString(),
                ModifedDate =x.ModifiedDate.ToString()
            }).ToList();
            return View(comments);
        }
    }
}
