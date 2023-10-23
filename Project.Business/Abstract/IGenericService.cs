using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.Business.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TDestroy(T t);

        void TUpdate(T t);
        List<T> TGetList();

        List<T> TGetActives();

        List<T> TGetPasives();

        List<T> TGetUpdatedes();



        List<T> TWhere(Expression<Func<T, bool>> exp);

        bool TAny(Expression<Func<T, bool>> exp);

        T TFirstOrDefault(Expression<Func<T, bool>> exp);

        IQueryable<X> TSelect<X>(Expression<Func<T, X>> exp);
        IQueryable<T> TInclude(Expression<Func<T, object>> includeProperty);

        //Find Command

        T TFind(int id);

        //Last Data

        List<T> TGetLastDatas(int number);

        //FirstData

        List<T> TGetFirstDatas(int number);



    }
}
