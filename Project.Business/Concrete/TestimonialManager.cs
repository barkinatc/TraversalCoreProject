using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Concrete
{
   public class TestimonialManager :ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;

        }

        public void TAdd(Testimonial t)
        {
            _testimonialDal.Add(t);
        }

        public bool TAny(Expression<Func<Testimonial, bool>> exp)
        {
            return _testimonialDal.Any(exp);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);

        }

        public void TDestroy(Testimonial t)
        {
            _testimonialDal.Destroy(t);

        }

        public Testimonial TFind(int id)
        {
           return _testimonialDal.Find(id);

        }

        public Testimonial TFirstOrDefault(Expression<Func<Testimonial, bool>> exp)
        {
            return _testimonialDal.FirstOrDefault(exp);

        }

        public List<Testimonial> TGetActives()
        {
            return _testimonialDal.GetActives();

        }

        public List<Testimonial> TGetFirstDatas(int number)
        {
            return _testimonialDal.GetFirstDatas(number);

        }

        public List<Testimonial> TGetLastDatas(int number)
        {
            return _testimonialDal.GetLastDatas(number);

        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetAll();

        }

        public List<Testimonial> TGetPasives()
        {
            return _testimonialDal.GetPassives();

        }

        public List<Testimonial> TGetUpdatedes()
        {
            return _testimonialDal.GetUpdateds();

        }

        public IQueryable<X> TSelect<X>(Expression<Func<Testimonial, X>> exp)
        {
            return _testimonialDal.Select(exp);

        }

        public void TUpdate(Testimonial t)
        {
             _testimonialDal.Update(t);

        }

        public List<Testimonial> TWhere(Expression<Func<Testimonial, bool>> exp)
        {
            return _testimonialDal.Where(exp);

        }
    }
}
