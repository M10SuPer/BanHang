using BH.Areas.Admin.Models;
using BH.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KetNoiCsdl.DAO;
using System.Web.Mvc;

namespace BH.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Login(model.UserName, MaHoaMd5.MD5Hash(model.PassWord));
                if (res)
                {
                    var user=dao.GetByID(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng.");
                }

            }
            return View("Index");
        }
    }
}