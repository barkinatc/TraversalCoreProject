using Microsoft.EntityFrameworkCore;
using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.ENTITIES.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Project.DAL.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, IEntity
    {


        protected MyContext _db;
        public GenericRepository(MyContext db)
        {
            _db = db;
        }


        public void Add(T item)
        {
            using var c = new MyContext();
            //_db.Add(item);
            //_db.SaveChanges();

            c.Add(item);
            c.SaveChanges();
        }





        public bool Any(Expression<Func<T, bool>> exp)
        {
            using var c = new MyContext();

            return c.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            using var c = new MyContext();

            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            c.Update(item);
            c.SaveChanges();

        }



        public void Destroy(T item)
        {
            using var c = new MyContext();

            c.Remove(item);
            c.SaveChanges();
        }


        public T Find(int id)
        {
            using var c = new MyContext();

            return c.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            using var c = new MyContext();
            return c.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {

            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);

        }

        public List<T> GetAll()
        {
            using var c = new MyContext();
            return c.Set<T>().ToList();
        }



        public List<T> GetFirstDatas(int number)
        {
            using var c = new MyContext();
            return c.Set<T>().OrderBy(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetLastDatas(int number)
        {
            using var c = new MyContext();

            return c.Set<T>().OrderByDescending(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetPassives()
        {

            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetUpdateds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }

        public IQueryable<T> Include(Expression<Func<T, object>> includeProperty)
        {
            using var c = new MyContext();

            return c.Set<T>().Include(includeProperty);

        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            using var c = new MyContext();

            //using var c = new Context();
            return c.Set<T>().Select(exp);

        }

        public void Update(T item)
        {
            using var c = new MyContext();

            item.Status = ENTITIES.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            c.Update(item);
            c.SaveChanges();
        }



        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            using var c = new MyContext();

            //using var c = new Context();
            return c.Set<T>().Where(exp).ToList();
        }
    }
}
