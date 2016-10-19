using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MyTestApplication.Models;
using System.Web.Security;

namespace MyTestApplication.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //
        // GET: /Account/Login
        // Get Login data to display.
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        // POST Login data to database
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                using (var context = new AuthenticationLibrary.Model.OrganizationEntities())
                {
                    int UserID = context.Users
                        .Where(u => u.UserName == model.UserName
                            && u.Password == model.Password)
                            //&& u.role.permission.Level > 0)
                        .Select(u => u.UserId)
                        .FirstOrDefault();
                    string sql = UserID.ToString();

                    if (UserID > 0)
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The User Name or Password is incorrect.");
                    }
                }
            }
            return View(model);
        }

        //
        // POST: /Account/LogOff
        //[ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}
