using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StockTrackingApp.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackingApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public ProfileController(UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var model = new UserDetailsModel()
            {
                Users = (List<User>)await _userManager.GetUsersInRoleAsync("Admin"),
                User = await _userManager.GetUserAsync(User)
            };
            return View(model);
        }

        #region Kullanıcı Ekleme,Güncelleme ve Silme

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var model = new UserDetailsModel()
            {
                Users = (List<User>)await _userManager.GetUsersInRoleAsync("Admin"),
                User = await _userManager.GetUserAsync(User)
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserDetailsModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.FirstName + Guid.NewGuid().ToString().Substring(0, 4),
                    Email = model.Email,
                    EmailConfirmed = true,
                    PhoneNumber = model.PhoneNumber,
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
                    await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("Index");
                }
                else
                {
                    if (_userManager.Users.Select(x => x.UserName).Contains(user.UserName))
                    {
                        ModelState.AddModelError("error", "Bu kullanıcı adı daha önce kullanıldı.");
                    }

                    if (_userManager.Users.Select(x => x.Email).Contains(model.Email))
                    {
                        ModelState.AddModelError("error", "Bu mail ile daha önce hesap oluşturuldu.");
                    }

                    ModelState.AddModelError("error", "Şifreniz büyük harf, küçük harf ve sayı içermelidir.");
                    ModelState.AddModelError("error", "Bilinmeyen bir hata oldu. Lütfen tekrar deneyiniz.");
                }
            }
            model.Users = (List<User>)await _userManager.GetUsersInRoleAsync("Admin");
            model.User = await _userManager.GetUserAsync(User);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(string UserId)
        {
            if (UserId != null)
            {
                var entity = await _userManager.FindByIdAsync(UserId);

                if (entity != null)
                {
                    var model = new UserDetailsModel()
                    {
                        Users = (List<User>)await _userManager.GetUsersInRoleAsync("Admin"),
                        User = await _userManager.GetUserAsync(User),
                        UpdateUser = entity
                    };
                    return View(model);
                }

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserDetailsModel model)
        {
            model.User = await _userManager.GetUserAsync(User);
            model.Users = (List<User>)await _userManager.GetUsersInRoleAsync("Admin");
            if (model.UpdateUser != null)
            {
                var user = await _userManager.FindByIdAsync(model.UpdateUser.Id);

                user.FirstName = model.UpdateUser.FirstName;
                user.LastName = model.UpdateUser.LastName;
                user.UserName = model.UpdateUser.UserName;
                user.Email = model.UpdateUser.Email;
                user.EmailConfirmed = true;
                user.PhoneNumber = model.UpdateUser.PhoneNumber;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("Index");
                }
                else
                {
                    var list = new List<User>();
                    foreach (var item in model.Users)
                    {
                        if (item.Id != model.UpdateUser.Id)
                        {
                            list.Add(item);
                        }
                    }
                    if (list.Select(x => x.UserName).Contains(model.UpdateUser.UserName))
                    {
                        ModelState.AddModelError("", "Bu kullanıcı adı daha önce kullanıldı.");
                    }

                    if (list.Select(x => x.Email).Contains(model.UpdateUser.Email))
                    {
                        ModelState.AddModelError("", "Bu mail ile daha önce hesap oluşturuldu.");
                    }

                    //ModelState.AddModelError("", "Şifreniz büyük harf, küçük harf ve sayı içermelidir.");
                    ModelState.AddModelError("", "Bilinmeyen bir hata oldu. Lütfen tekrar deneyiniz.");
                }
            }


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            if (userId == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByIdAsync(userId);

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        #endregion

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var model = new UserDetailsModel()
            {
                User = await _userManager.GetUserAsync(User)
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Profile(UserDetailsModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                user.UserName = model.User.UserName;
                user.FirstName = model.User.FirstName;
                user.LastName = model.User.LastName;
                user.Email = model.User.Email;
                user.EmailConfirmed = true;
                user.PhoneNumber = model.User.PhoneNumber;

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                var result1 = await _userManager.ResetPasswordAsync(user, token, model.Password);

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded && result1.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    var list = new List<User>();
                    foreach (var item in model.Users)
                    {
                        if (item.Id != model.User.Id)
                        {
                            list.Add(item);
                        }
                    }
                    if (list.Select(x => x.UserName).Contains(model.User.UserName))
                    {
                        ModelState.AddModelError("", "Bu kullanıcı adı daha önce kullanıldı.");
                    }

                    if (list.Select(x => x.Email).Contains(model.User.Email))
                    {
                        ModelState.AddModelError("", "Bu mail ile daha önce hesap oluşturuldu.");
                    }

                    ModelState.AddModelError("", "Şifreniz büyük harf, küçük harf ve sayı içermelidir.");
                    ModelState.AddModelError("", "Bilinmeyen bir hata oldu. Lütfen tekrar deneyiniz.");
                }
            }
            model.Users = (List<User>)await _userManager.GetUsersInRoleAsync("Admin");
            model.User = await _userManager.GetUserAsync(User);
            return View(model);
        }
    }
}
