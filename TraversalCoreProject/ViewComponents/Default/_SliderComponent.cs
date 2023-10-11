using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SliderComponent : ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();
        }   
    }
}
