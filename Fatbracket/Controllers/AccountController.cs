using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fatbracket.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            try
            {

                return View();
            }
            catch
            {

            }
            finally
            {

            }
            return View();
        }
    }
}