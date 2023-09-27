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
    public class ContactManager :IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact t)
        {
            _contactDal.Add(t);
        }

        public bool TAny(Expression<Func<Contact, bool>> exp)
        {
            return _contactDal.Any(exp);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public void TDestroy(Contact t)
        {
            _contactDal.Destroy(t);

        }

        public Contact TFind(int id)
        {
            return _contactDal.Find(id);
        }

        public Contact TFirstOrDefault(Expression<Func<Contact, bool>> exp)
        {
            return _contactDal.FirstOrDefault(exp);

        }

        public List<Contact> TGetActives()
        {
            return _contactDal.GetActives();

        }

        public List<Contact> TGetFirstDatas(int number)
        {
            return _contactDal.GetFirstDatas(number);
        }

        public List<Contact> TGetLastDatas(int number)
        {
            return _contactDal.GetLastDatas(number);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetAll();
        }

        public List<Contact> TGetPasives()
        {
            return _contactDal.GetPassives();
        }

        public List<Contact> TGetUpdatedes()
        {
            return _contactDal.GetUpdateds();
        }

        public IQueryable<X> TSelect<X>(Expression<Func<Contact, X>> exp)
        {
            return _contactDal.Select(exp);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }

        public List<Contact> TWhere(Expression<Func<Contact, bool>> exp)
        {
          return  _contactDal.Where(exp);
        }
    }
}
