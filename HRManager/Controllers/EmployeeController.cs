using HRManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRManager.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly UserManager<HRManagerUser> _userManager;

        public EmployeeController(UserManager<HRManagerUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            HRManagerUser? user = await _userManager.GetUserAsync(User);

            HrManagerUserViewModel model = new HrManagerUserViewModel
            {
                UserName = user!.UserName!,
                DepartmentName = user.Department?.Name ?? ""
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDepartment(HrManagerUserViewModel model)
        {
            HRManagerUser? user = await _userManager.GetUserAsync(User);

            Department? department = new Department
            {
                Name = model.DepartmentName
            };

            user.Department = department;

            await _userManager.UpdateAsync(user);

            return RedirectToAction("Index");
        }
    }
}