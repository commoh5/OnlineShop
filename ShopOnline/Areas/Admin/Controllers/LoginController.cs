using Models.DAO;
using ShopOnline.Areas.Admin.Models;
using ShopOnline.Common;
using System.Web.Mvc;

namespace ShopOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.userName, Encryptor.MD5Hash(model.passWord));
                if (result == 1)
                {
                    var user = dao.GetByID(model.userName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đã bị khóa");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Sai mật khẩu");
                }
            }
            return View("Index");
        }
    }
}