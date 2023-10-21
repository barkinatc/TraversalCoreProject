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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Add(t);      }

        public bool TAny(Expression<Func<Destination, bool>> exp)
        {
            return _destinationDal.Any(exp);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public void TDestroy(Destination t)
        {
            _destinationDal.Destroy(t);
        }

        public Destination TFind(int id)
        {
            return _destinationDal.Find(id);
        }

        public Destination TFirstOrDefault(Expression<Func<Destination, bool>> exp)
        {
            return _destinationDal.FirstOrDefault(exp);

        }

        public List<Destination> TGetActives()
        {
            return _destinationDal.GetActives();
        }

        public IQueryable<Destination> TGetAllAsQueryable()
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetFirstDatas(int number)
        {
            return _destinationDal.GetFirstDatas(number);

        }

        public List<Destination> TGetLastDatas(int number)
        {
            return _destinationDal.GetLastDatas(number);

        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetAll();
        }

        public List<Destination> TGetPasives()
        {
            return _destinationDal.GetPassives();

        }

        public List<Destination> TGetUpdatedes()
        {
            return _destinationDal.GetUpdateds();

        }

        public IQueryable<Destination> TInclude(Expression<Func<Destination, object>> includeProperty)
        {
            return _destinationDal.Include(includeProperty);
        }

        public IQueryable<X> TSelect<X>(Expression<Func<Destination, X>> exp)
        {
            return _destinationDal.Select(exp);

        }

        public void TUpdate(Destination t)
        {
             _destinationDal.Update(t);

        }

        public List<Destination> TWhere(Expression<Func<Destination, bool>> exp)
        {
            return _destinationDal.Where(exp);

        }
    }
}
