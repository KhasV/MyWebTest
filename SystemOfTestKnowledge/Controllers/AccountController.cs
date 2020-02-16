using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebTest.Models;
using MyWebTest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace MyWebTest.Controllers
{
    public class AccountController: Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly Email.IEmailService _emailService;
        private readonly ILogger _logger;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, 
            Email.IEmailService emailService, ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            _logger.LogInformation("------------che kavo----------");
            if (ModelState.IsValid)
            {
                User user = new User { Email = model.Email, UserName = model.Email, Age = model.Age, Name = model.Name,};
                var usedCheck = await _userManager.FindByNameAsync(model.Email);
                if (usedCheck != null)
                {
                    _logger.LogWarning("повторение email");
                    ModelState.AddModelError("", "ОШИБКА! Такой email адрес уже зарегистрирован.");
                    return View(model);
                }
                var result = await _userManager.CreateAsync(user, model.Password);
                //posilaem vsyakie shtuki na pochtu
                if (result.Succeeded)
                {
                    _logger.LogInformation("------------oppa----------");
                    await _userManager.AddToRoleAsync(user, "user");
                    _logger.LogInformation("------------oppa1----------");
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var code = Guid.NewGuid().ToString();
                    user.Token = code;
                    await _userManager.UpdateAsync(user);
                    _logger.LogInformation("------------oppa2----------");
                    var callbackUrl = Url.Action(
                        "ConfirmEmail",
                        "Account",
                        new { userId = user.Id, code = code },
                        protocol: HttpContext.Request.Scheme);
                    _logger.LogInformation("------------oppa3----------");
                    //EmailService emailService = new EmailService();
                    await _emailService.SendEmailAsync(model.Email, "Confirm your account", "Чтобы активированть ваш аккаунт, перейдите по данной ссылке " +
                        $": <a href='{callbackUrl}'>MyWebTest</a>");
                    _logger.LogInformation("------------oppa4----------");
                    //await _signInManager.SignInAsync(user, false);
                    //return RedirectToAction("Index", "Home");
                    return Content("Чтобы активировать ваш аккаунт, перейдите по ссылке, что уже отправлена на email адрес, который вы указали при регистрации.");
                }
                else
                {
                    _logger.LogWarning("хз");
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                }

            }
            _logger.LogWarning("------------not valid----------");
            return View(model);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberPassw, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl) && await _userManager.IsEmailConfirmedAsync(user))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            if (await _userManager.IsEmailConfirmedAsync(user))
            {
                return View("Error");
            }
            //var result = await _userManager.ConfirmEmailAsync(user, code);
            //if (result.Succeeded)
            if(user.Token == code)
            {
                //return RedirectToAction("Index", "Home");
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }
            else
                return View("Error");
        }
    }
}
