using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAboutComponent : ViewComponent
    {
        //SubAboutManager subAboutManager = new SubAboutManager(new EFSubAboutDal());
        private readonly ISubAboutService _subAboutService;

        public _SubAboutComponent(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            List<SubAboutVM> values = _subAboutService.TGetList().Select(x => new SubAboutVM
            {
                ID = x.ID,
                Title = x.Title,
                Description = x.Description
            }).ToList();
            //List< SubAbout> values = subAboutManager.TGetList();
            return View(values);
        }
    }
}
