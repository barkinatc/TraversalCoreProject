
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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;
        
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TAdd(AppUser t)
        {
            _appUserDal.Add(t);
        }

        public bool TAny(Expression<Func<AppUser, bool>> exp)
        {
            return _appUserDal.Any(exp);
        }

        public void TDelete(AppUser t)
        {
            _appUserDal.Delete(t);

        }

        public void TDestroy(AppUser t)
        {
            _appUserDal.Destroy(t);

        }

        public AppUser TFind(int id)
        {
            return _appUserDal.Find(id);

        }

        public AppUser TFirstOrDefault(Expression<Func<AppUser, bool>> exp)
        {
            return _appUserDal.FirstOrDefault(exp);

        }

        public List<AppUser> TGetActives()
        {
          return  _appUserDal.GetActives();

        }

        public IQueryable<AppUser> TGetAllAsQueryable()
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetFirstDatas(int number)
        {
            return _appUserDal.GetFirstDatas(number);

        }

        public List<AppUser> TGetLastDatas(int number)
        {
            return _appUserDal.GetLastDatas(number);

        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetAll();

        }

        public List<AppUser> TGetPasives()
        {
            return _appUserDal.GetPassives();

        }

        public List<AppUser> TGetUpdatedes()
        {
           return _appUserDal.GetUpdateds();

        }

        public IQueryable<AppUser> TInclude(Expression<Func<AppUser, object>> includeProperty)
        {
            return _appUserDal.Include(includeProperty);

        }

        public IQueryable<X> TSelect<X>(Expression<Func<AppUser, X>> exp)
        {
            return _appUserDal.Select(exp);

        }

        public void TUpdate(AppUser t)
        {
            _appUserDal.Update(t);
        }

        public List<AppUser> TWhere(Expression<Func<AppUser, bool>> exp)
        {
            return _appUserDal.Where(exp);

        }
    }
}
