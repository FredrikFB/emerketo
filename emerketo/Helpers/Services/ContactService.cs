using emerketo.Contexts;
using emerketo.Models.Entities;
using emerketo.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace emerketo.Helpers.Services;

public class ContactService
{
    private readonly IdentityContext _identityContext;

    public ContactService(IdentityContext identityContext)
    {
        _identityContext = identityContext;
    }

    public async Task<bool> CreateAsync(ContactFormViewModel viewModel)
    {
        try
        {
            ContactFormEntity entity = viewModel;

            _identityContext.Add(entity);
            await _identityContext.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
