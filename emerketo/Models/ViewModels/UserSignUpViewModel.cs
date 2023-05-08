using emerketo.Models.Entities;
using emerketo.Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace emerketo.Models.ViewModels;

public class UserSignUpViewModel
{
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "You must provide a first name")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "You must provide a last name")]
    public string LastName { get; set; } = null!;



    [Display(Name = "Street Name")]
    [Required(ErrorMessage = "You must provide a street name")]
    public string StreetName { get; set; } = null!;


    [Display(Name = "Postal Code")]
    [Required(ErrorMessage = "You must provide a postal code")]
    public string PostalCode { get; set; } = null!;


    [Display(Name = "City")]
    [Required(ErrorMessage = "You must provide a city name")]
    public string City { get; set; } = null!;


    [Display(Name = "Mobile(Optional)")]
    public string? Mobile { get; set; }


    [Display(Name = "Company(Optional)")]
    public string? Company { get; set; }


    [Display(Name = "E-mail")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "You must provide an e-mail address")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must provide a valid e-mail address")]
    public string Email { get; set; } = null!;


    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "You must provide a password")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-z0-9]).{8,}$", ErrorMessage = "You must provide a valid password")]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Password must match")]
    [Required(ErrorMessage = "You must confirm your password")]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "Upload Profile Image")]
    [DataType(DataType.Upload)]
    public IFormFile? ImageFile { get; set; }


    [Display(Name = "I have read and accepts the terms and conditions")]
    [Required(ErrorMessage = "You must agree to the terms and conditions")]
    public bool TermsAndConditions { get; set; } = false;

    public static implicit operator AppUser(UserSignUpViewModel model)
    {
        return new AppUser
        {
            UserName = model.Email,
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            PhoneNumber = model.Mobile,
            CompanyName = model.Company
        };
    }

    public static implicit operator AddressEntity(UserSignUpViewModel model)
    {
        return new AddressEntity
        {
            StreetName = model.StreetName,
            PostalCode = model.PostalCode,
            City = model.City,
        };
    }
}
