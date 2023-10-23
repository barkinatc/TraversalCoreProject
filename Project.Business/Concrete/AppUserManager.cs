
using Microsoft.AspNetCore.Identity;
using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Project.Business.Concrete
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserService
    {
        IAppUserDal _appUserDal;
        private readonly UserManager<AppUser> _userManager;

        public AppUserManager(IAppUserDal appUserDal, UserManager<AppUser> userManager) : base(appUserDal)
        {
            _appUserDal = appUserDal;
            _userManager = userManager;
        }


        public async Task<AppUser> GetCurrentUserAsync(ClaimsPrincipal userClaims)
        {
            var user = await _userManager.GetUserAsync(userClaims);
            return user;
        }
    }
}
