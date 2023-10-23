using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeatureComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // FeatureManager featuresManager = new FeatureManager(new EFFeatureDal());
            //var values = featuresManager.TGetList();
            // ViewBag.image1 = featuresManager.TFind();
            return View();
        }
    }
}
