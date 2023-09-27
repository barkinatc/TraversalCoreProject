using Microsoft.AspNetCore.Mvc;
using Project.Business.Concrete;
using Project.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinationsPartial:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());


        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values  );
        }
    }
}
