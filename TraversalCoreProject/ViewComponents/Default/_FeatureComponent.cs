using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.VM.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeatureComponent : ViewComponent
    {
       private readonly IFeatureService _featureService;
        public _FeatureComponent(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IViewComponentResult Invoke()
        {
            List<FeaturesVM> values = _featureService.TGetList().Select(x => new FeaturesVM
            {
                Post1Name = x.Post1Name,
                Post1Description = x.Post1Description,
                Post1Image = x.Post1Image

            }).ToList();
            return View(values);
        }
    }
}
