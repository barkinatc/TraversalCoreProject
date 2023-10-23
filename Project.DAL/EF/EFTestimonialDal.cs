using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EFTestimonialDal(Context db) : base(db)
        {

        }
    }
}
