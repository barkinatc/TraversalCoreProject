using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.Business.Concrete
{
    public class BaseManager<T> : IGenericService<T> where T : class, IEntity
    {
        private readonly IGenericDal<T> _genericDal;
        public BaseManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }
        public void TAdd(T t)
        {
            _genericDal.Add(t);
        }

        public bool TAny(Expression<Func<T, bool>> exp)
        {
            return _genericDal.Any(exp);
        }

        public void TDelete(T t)
        {
            _genericDal.Delete(t);
        }

        public void TDestroy(T t)
        {
            _genericDal.Destroy(t);
        }

        public T TFind(int id)
        {
            return _genericDal.Find(id);
        }

        public T TFirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _genericDal.FirstOrDefault(exp);

        }

        public List<T> TGetActives()
        {
            return _genericDal.GetActives();

        }

        public List<T> TGetFirstDatas(int number)
        {
            return _genericDal.GetFirstDatas(number);

        }

        public List<T> TGetLastDatas(int number)
        {
            return _genericDal.GetLastDatas(number);

        }

        public List<T> TGetList()
        {
            return _genericDal.GetAll();

        }

        public List<T> TGetPasives()
        {
            return _genericDal.GetPassives();

        }

        public List<T> TGetUpdatedes()
        {
            return _genericDal.GetUpdateds();

        }

        public IQueryable<T> TInclude(Expression<Func<T, object>> includeProperty)
        {
            return _genericDal.Include(includeProperty);

        }

        public IQueryable<X> TSelect<X>(Expression<Func<T, X>> exp)
        {
            return _genericDal.Select(exp);

        }

        public void TUpdate(T t)
        {
            _genericDal.Update(t);

        }

        public List<T> TWhere(Expression<Func<T, bool>> exp)
        {
            return _genericDal.Where(exp);

        }
    }
}
