﻿using emerketo.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace emerketo.Models.Identity;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? CompanyName { get; set; }
    public string? ImageUrl { get; set; }

    public ICollection<UserAddressEntity> Addresses { get; set; } = new HashSet<UserAddressEntity>();
}
