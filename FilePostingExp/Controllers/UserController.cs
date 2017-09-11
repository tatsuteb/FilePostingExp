using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using FilePostingExp.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilePostingExp.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Input username and add thumbnail file.
        /// </summary>
        /// <returns>The registration.</returns>
        public IActionResult Registration()
        {
            return View();
        }


        /// <summary>
        /// Confirm user information.
        /// </summary>
        /// <returns>The confirm.</returns>
        /// <param name="model">Model.</param>
        [HttpPost]
        public IActionResult Confirm(UserRegistrationViewModel model)
        {
            return View(model);
        }


        /// <summary>
        /// Regist user information to db and redirect to Home/Index.
        /// </summary>
        /// <param name="model">Model.</param>
        [HttpPost]
        public IActionResult ExecRegistration(UserRegistrationViewModel model)
        {
            // TODO: Regist data to db.

            //Response.Redirect("/User/RegistrationComplete");
            return RedirectToAction("RegistrationComplete", model);
        }


        public IActionResult RegistrationComplete(UserRegistrationViewModel model)
        {
            return View(model);
        }
    }
}
