using emerketo.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace emerketo.Models.ViewModels;

public class ContactFormViewModel
{
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "You must provide a name")]
    public string Name { get; set; } = null!;

    [Display(Name = "E-mail")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "You must provide an e-mail address")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must provide a valid e-mail address")]
    public string Email { get; set; } = null!;

    [Display(Name = "Phonenumber")]
    public string Phone { get; set; } = null!;

    public string? Company { get; set; }

    [Display(Name = "Message")]
    public string Message { get; set; } = null!;

    [Display(Name = "Save my name, email in this browser for the next time I comment.")]
    [Required(ErrorMessage = "You must agree to the terms and conditions")]
    public bool RememberMe { get; set; } = false;


    public static implicit operator ContactFormEntity(ContactFormViewModel viewModel)
    {
        return new ContactFormEntity
        {
            Name = viewModel.Name,
            Email = viewModel.Email,
            PhoneNumber = viewModel.Phone,
            Company = viewModel.Company,
            Message = viewModel.Message,
        };
    }
}
