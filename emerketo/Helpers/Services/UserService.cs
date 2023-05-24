using emerketo.Contexts;
using emerketo.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace emerketo.Helpers.Services;

public class UserService
{
    private readonly IdentityContext _context;
    private readonly UserManager<AppUser> _userManager;

    public UserService(IdentityContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<AppUser> GetUserAsync(Expression<Func<AppUser, bool>> predicate)
    {
        var appUser = await _userManager.Users.Include(x => x.Addresses).FirstOrDefaultAsync(predicate);
        return appUser!;
    }
    public async Task<IEnumerable<AppUser>> GetAllAsync()
    {
        return await _userManager.Users.Include(x => x.Addresses).ToListAsync();
    }


    public async Task<IEnumerable<(AppUser, IList<string>)>> GetAllWhitRolesAsync()
    {
        var users = await _userManager.Users.Include(u => u.Addresses).ToListAsync();

        var result = new List<(AppUser, IList<string>)>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            result.Add((user, roles));
        }

        return result;
    }


}
