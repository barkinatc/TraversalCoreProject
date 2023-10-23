using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _TestimonialComponent:ViewComponent
    {
        //TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDal());
    private readonly    ITestimonialService _testimonialService;

        public _TestimonialComponent(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetList().Select(x=> new TestimonialVM 
            {
            ID =x.ID,
            Client =x.Client,
            ClientImage =x.ClientImage,
            Comment =x.Comment
            }).ToList();
            return View(values);
        }
    }
}
