using emerketo.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace emerketo.Helpers.Factories;

public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<AppUser>
{
    private readonly UserManager<AppUser> _userManager;

    public CustomClaimsPrincipalFactory(UserManager<AppUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    {
        _userManager = userManager;
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
    {
        var claimsIdentity = await base.GenerateClaimsAsync(user);
        var appUser = await _userManager.Users.Include(u => u.Addresses).FirstOrDefaultAsync(u => u.Id == user.Id);

        claimsIdentity.AddClaim(new Claim("DisplayName", $"{appUser!.FirstName} {appUser.LastName}"));

        var roles = await _userManager.GetRolesAsync(user);
        foreach (var role in roles)
        {
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, role));
        }
        return claimsIdentity;
    }
}
