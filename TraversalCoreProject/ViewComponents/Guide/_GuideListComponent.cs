using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.ViewComponents.Guide
{
    public class _GuideListComponent : ViewComponent
    {
        // GuideManager guideManager = new GuideManager(new EFGuideDal());
        private readonly IGuideService _guideService;

        public _GuideListComponent(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {

            List<GuideVM> guides = _guideService.TGetList().Select(x => new GuideVM
            {

                ID = x.ID,
                Name = x.Name,
                Status = x.Status.ToString(),
                CreatedDate = x.CreatedDate.ToString(),
                Description = x.Description

            }).ToList();
            return View(guides);
        }
    }
}
