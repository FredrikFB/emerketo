using emerketo.Helpers._Services;
using emerketo.Models.Identity;
using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace emerketo.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthService _authService;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(AuthService authService, SignInManager<AppUser> signInManager)
        {
            _authService = authService;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserSignUpViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _authService.SignUpAsync(viewModel))
                    return RedirectToAction("SignIn");

                ModelState.AddModelError("", "A user with the same email already exists");
            }

            return View();
        }

        public IActionResult SignIn(string ReturnUrl = null!)
        {
            var model = new UserLoginViewModel();
            if (ReturnUrl != null)
                model.ReturnUrl = ReturnUrl;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _authService.SignInAsync(model))
                    return RedirectToAction("Index");

                ModelState.AddModelError("", "Incorrect email or password");
            }

            return View();
        }

        [Authorize]
        public new async Task<IActionResult> SignOut()
        {
            if(_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();

            return LocalRedirect("/");
        }
    }
}
