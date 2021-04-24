using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoreMenegment.Models;
using Microsoft.AspNetCore.Authorization;
using StoreMenegment.IStoreService;

namespace StoreMenegment.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IstoreManagmentService _logger;

        public AccountController(UserManager<IdentityUser> userManager,
                                    SignInManager<IdentityUser> signInManager,
                                    IstoreManagmentService logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Register(int LanguageId = 1)
        {
            var language = _logger.GetLanguage().Languages.FirstOrDefault(l => l.LanguageId == LanguageId);

            if (language == null)
            {
                ViewBag.Error = "Language not found";
                return View();
            }
            ViewBag.SelectedLanguage = language.LanguageNume;
            ViewBag.FuterLanguage = LanguageId;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                    //return View();
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(int LanguageId = 1)
        {
            var language = _logger.GetLanguage().Languages.FirstOrDefault(l => l.LanguageId == LanguageId);

            if (language == null)
            {
                ViewBag.Error = "Language not found";
                return View();
            }
            ViewBag.SelectedLanguage = language.LanguageNume;
            ViewBag.FuterLanguage = LanguageId;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                    //return View();
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
