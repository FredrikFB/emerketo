using emerketo.Contexts;
using emerketo.Models.Entities;
using emerketo.Models.Identity;
using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace emerketo.Helpers._Services;

public class AuthService
{

    private readonly SignInManager<AppUser> _signInManager;
    private readonly UserManager<AppUser> _userManager;
    private readonly IdentityContext _context;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AuthService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IdentityContext context)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _roleManager = roleManager;
        _context = context;
    }

    public async Task<bool> SignUpAsync(UserSignUpViewModel model)
    {
        try
        {
            AppUser appUser = model;

            var roleName = "user";

            if (!await _userManager.Users.AnyAsync())
                roleName = "admin";

            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, roleName);

                var userAddress = new UserAddressEntity { Address = model, UserId = appUser.Id };
                _context.Add(userAddress);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
        catch { return false; }
    }

    public async Task<bool> SignInAsync(UserLoginViewModel model)
    {
        try
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            return result.Succeeded;
        }
        catch { return false; }
    }

    public async Task<bool> SignOutAsync(ClaimsPrincipal user)
    {
        await _signInManager.SignOutAsync();
        return _signInManager.IsSignedIn(user);
    }
}
