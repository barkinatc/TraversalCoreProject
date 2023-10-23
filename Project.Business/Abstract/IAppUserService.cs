using Project.ENTITIES.Concrete;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Project.Business.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> GetCurrentUserAsync(ClaimsPrincipal userClaims);
    }
}
