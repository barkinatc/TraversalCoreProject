using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class TestimonialManager : BaseManager<Testimonial>, ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal) : base(testimonialDal)
        {
            _testimonialDal = testimonialDal;

        }


    }
}
