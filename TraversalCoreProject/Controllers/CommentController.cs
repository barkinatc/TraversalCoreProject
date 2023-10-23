using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.ENTITIES.Concrete;
using System.Threading.Tasks;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        //CommentManager commentManager = new CommentManager(new EFCommentDal());
        private readonly ICommentService _commentService;
        private readonly IAppUserService _userService;

        public CommentController(ICommentService commentService, IAppUserService userService)
        {
            _commentService = commentService;
            _userService = userService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {



            return PartialView();

        }
        [HttpPost]
        public async Task<IActionResult> AddComment(AddCommentPartialVM p)
        {
            var user = await _userService.GetCurrentUserAsync(User);

            Comment comment = new Comment();
            comment.AppUserID = user.Id;
            comment.CommentContent = p.CommentContent;
            comment.CommentUser = $"{user.Name} {user.Surname}";
            comment.DestinationID = p.DestinationID;

            //commentManager.TAdd(p);
            _commentService.TAdd(comment);
            return RedirectToAction("Index", "Destination");
        }
    }
}
