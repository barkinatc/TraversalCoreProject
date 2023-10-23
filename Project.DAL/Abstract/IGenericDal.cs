using Project.ENTITIES.Concrete;
using Project.ENTITIES.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
   public interface IGenericDal<T> where T: IEntity
    {
        List<T> GetAll();
       

        List<T> GetActives();

        List<T> GetPassives();

        List<T> GetUpdateds();

        //Modif Commands 

        void Add(T item);

       

        void Update(T item);

        

        void Delete(T item);

       

        void Destroy(T item);
        


        //Linq

        List<T> Where(Expression<Func<T, bool>> exp);
        

        bool Any(Expression<Func<T, bool>> exp);

        T FirstOrDefault(Expression<Func<T, bool>> exp);

        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);
        IQueryable<T> Include(Expression<Func<T, object>> includeProperty);

        //Find Command

        T Find(int id);

        //Last Data

        List<T> GetLastDatas(int number);

        //FirstData

        List<T> GetFirstDatas(int number);

    }
}
