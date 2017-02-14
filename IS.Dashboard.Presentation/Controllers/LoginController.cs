using System.Web.Mvc;
using IS.Dashboard.Business.Login;
using IS.Dashboard.Model;

namespace IS.Dashboard.Presentation.Web.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        public JsonResult DoLogin(string userEmail, string password)
        {
            var ab = new AuthenticationBusiness();
            User user = ab.AuthenticateUser(userEmail, password);

            if (!Equals(user, null))
            {
                return Json(new { @MSG = "success", @SUCCESS = true, @DATA = user, @url = "/Home/Index" });
            }

            return Json(new { @MSG = "error", @SUCCESS = false, @DATA = "", @url = string.Empty }); ;
        }
    }
}
