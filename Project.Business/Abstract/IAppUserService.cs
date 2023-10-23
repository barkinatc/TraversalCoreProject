﻿using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> GetCurrentUserAsync(ClaimsPrincipal userClaims);
    }
}
