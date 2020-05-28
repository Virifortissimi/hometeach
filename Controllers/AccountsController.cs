using System;
using System.Threading.Tasks;
using eagle_hometeach.src.Entities;
using eagle_hometeach.src.Models.RequestModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eagle_hometeach.src.Controllers
{
    [Controller]
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountsController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt. Email or Password is wrong");
                    return View();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                ViewBag.Message = "Please input an email or password";
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateUserRequestModels model)
        {
            try
            {
                ViewBag.Message = "User already Registered";

                ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    user = new ApplicationUser();
                    user.UserName = model.Email;
                    user.Email = model.Email;

                    IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                    ViewBag.Message = "User was Created";

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid user details. Add at least One Uppercase, Lowercase, Special Character and Number!");
                    }

                    //return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
