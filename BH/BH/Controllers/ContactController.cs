using KetNoiCsdl.DAO;
using KetNoiCsdl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BH.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    //    protected void SetAlert(string message, string type)
    //    {
    //        TempData["AlertMessage"] = message;
    //        if (type == "success")
    //        {
    //            TempData["AlertType"] = "alert-success";
    //        }
    //        else if (type == "warning")
    //        {
    //            TempData["AlertType"] = "alert-warning";
    //        }
    //        else if (type == "error")
    //        {
    //            TempData["AlertType"] = "alert-danger";
    //        }
    //    }
    //    [HttpPost]
    //    public ActionResult Create(Contact contact)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var dao = new ContactDao();
    //            long id = dao.Insert(contact);
    //            if (id > 0)
    //            {
    //                SetAlert("Gửi đi thành công", "success");
    //            }
    //            else
    //            {
    //                SetAlert("Chưa được gửi", "error");
    //            }
    //        } return View("Index");
    //    }
    }
}