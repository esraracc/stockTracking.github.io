using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StockTrackingApp.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StockTrackingApp.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                // generate token
                // email
                ModelState.AddModelError("", "No account has been created with this username before.");
                return View(model);
            }
            else
            {
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

                if (result.Succeeded)
                {
                    if (await _userManager.IsInRoleAsync(user, "Admin"))
                    {
                        return Redirect("/home/index");
                    }
                }
            }

            ModelState.AddModelError("", "The entered username or password is incorrect.");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.FirstName + "-" + Guid.NewGuid().ToString().Substring(0, 4),
                Email = model.Email,
                EmailConfirmed = true,
                PhoneNumber = model.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("Login", "Account", new
                {
                    userId = user.Id,
                    token = code
                });

                await _userManager.AddToRoleAsync(user, "Company");

                return RedirectToAction("login");
            }
            else
            {
                if (_userManager.Users.Select(x => x.UserName).Contains(user.UserName))
                {
                    ModelState.AddModelError("", "This username has been used before.");
                }

                if (_userManager.Users.Select(x => x.Email).Contains(model.Email))
                {
                    ModelState.AddModelError("", "An account has already been created with this email.");
                }

                ModelState.AddModelError("", "Your password must contain uppercase letters, lowercase letters and numbers.");
                ModelState.AddModelError("", "An unknown error occurred. Please try again.");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                // generate token
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var url = Url.Action("ResetPassword", "Account", new
                {
                    userId = user.Id,
                    token = HttpUtility.HtmlEncode(code)
                });
                // email

                TempData["info"] = "Password reset link has been sent.";
                return RedirectToAction("ForgotPassword");
            }
            else
            {
                TempData["info"] = "Email not found.";
            }
            return RedirectToAction("ForgotPassword");

        }

        [HttpGet]
        public async Task<IActionResult> ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var user = await _userManager.FindByIdAsync(userId);
            var model = new ResetPasswordModel { Email = user.Email, Token = token };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

                    if (result.Succeeded)
                    {
                        ModelState.AddModelError("", "Your password has been reset. You can login");
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Your password must contain at least 5 characters, uppercase and lowercase letters.");
                    }

                    ModelState.TryAddModelError("", "An unknown error occurred. Please try again.");

                    return View(model);
                }
                return View(model);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
