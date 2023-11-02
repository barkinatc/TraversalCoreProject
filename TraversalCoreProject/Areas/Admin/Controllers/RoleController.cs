using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class RoleController : Controller
    {

        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult ListRoles()
        {

            List<AdminAppRoleVM> values = _roleManager.Roles.Select(x => new AdminAppRoleVM
            {
                ID = x.Id,
                Name = x.Name
            }).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> AddRole(AdminAppRoleVM p)
        {
            AppRole appRole = new AppRole();
            appRole.Name = p.Name;
            var result =  await _roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return Redirect("/admin/Role/ListRoles");
            }

            return View();
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var role = _roleManager.Roles.Where(x => x.Id == id).Select(x => new AdminAppRoleVM
            {
                ID = x.Id,
                Name = x.Name
            }).FirstOrDefault();
            return View(role);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(AdminAppRoleVM p)
        {
            AppRole toBeUpdated =  _roleManager.Roles.FirstOrDefault(x => x.Id == p.ID);
            toBeUpdated.Name = p.Name;
            await _roleManager.UpdateAsync(toBeUpdated);
            return Redirect("/admin/Role/ListRoles");

        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            if (value!=null)
            {
await _roleManager.DeleteAsync(value);

            return Redirect("/admin/Role/ListRoles");
            }
            return View();

            

        }
    }
}
