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
    public class NewsletterManager:INewsletterService
    {
        INewsletterDal _newsletterDal;
        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }
public void TAdd(Newsletter t)
        {
            _newsletterDal.Add(t);
        }

        public bool TAny(Expression<Func<Newsletter, bool>> exp)
        {
            return _newsletterDal.Any(exp);

        }

        public void TDelete(Newsletter t)
        {
            _newsletterDal.Delete(t);

        }

        public void TDestroy(Newsletter t)
        {
            _newsletterDal.Destroy(t);

        }

        public Newsletter TFind(int id)
        {
            return _newsletterDal.Find(id);
        }

        public Newsletter TFirstOrDefault(Expression<Func<Newsletter, bool>> exp)
        {
            return _newsletterDal.FirstOrDefault(exp);
        }

        public List<Newsletter> TGetActives()
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> TGetFirstDatas(int number)
        {
            return _newsletterDal.GetFirstDatas(number);

        }

        public List<Newsletter> TGetLastDatas(int number)
        {
            return _newsletterDal.GetLastDatas(number);

        }

        public List<Newsletter> TGetList()
        {
            return _newsletterDal.GetAll();

        }

        public List<Newsletter> TGetPasives()
        {
            return _newsletterDal.GetPassives();

        }

        public List<Newsletter> TGetUpdatedes()
        {
            return _newsletterDal.GetUpdateds();

        }

        public IQueryable<X> TSelect<X>(Expression<Func<Newsletter, X>> exp)
        {
            return _newsletterDal.Select(exp);

        }

        public void TUpdate(Newsletter t)
        {
            _newsletterDal.Update(t);

        }

        public List<Newsletter> TWhere(Expression<Func<Newsletter, bool>> exp)
        {
            return _newsletterDal.Where(exp);

        }
    }
}
