using Microsoft.AspNetCore.Mvc;
using Project.Business.Concrete;
using Project.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentListComponent:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var value = commentManager.TGetDestinationByID(id);
            return View(value);
        }
    }
}
