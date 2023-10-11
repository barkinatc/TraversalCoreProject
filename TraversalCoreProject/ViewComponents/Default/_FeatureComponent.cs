using Microsoft.AspNetCore.Mvc;
using Project.Business.Concrete;
using Project.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeatureComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FeatureManager featuresManager = new FeatureManager(new EFFeatureDal());
            //var values = featuresManager.TGetList();
           // ViewBag.image1 = featuresManager.TFind();
            return View();
        }
    }
}
