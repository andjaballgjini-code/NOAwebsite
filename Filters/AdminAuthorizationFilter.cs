using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using NOA_Library.Models;  // Adjust with your correct namespace

namespace NOA_Library.Filters
{
    public class AdminAuthorizationFilter : IAsyncAuthorizationFilter
    {
        private readonly UserManager<Users> _userManager;

        public AdminAuthorizationFilter(UserManager<Users> userManager)
        {
            _userManager = userManager;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var user = await _userManager.GetUserAsync(context.HttpContext.User);
            if (user == null || !await _userManager.IsInRoleAsync(user, "Admin"))
            {
                // If the user is not an admin, redirect to the home page or another page
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
