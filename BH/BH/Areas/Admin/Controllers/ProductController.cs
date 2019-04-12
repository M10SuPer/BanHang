using BH.Common;
using KetNoiCsdl.DAO;
using KetNoiCsdl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace BH.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index(int page = 1, int pageSize = 1)
        {   
            var dao = new UserDao(); var model = dao.ListAllPaging1(page, pageSize);
            return View(model); }

        public ActionResult CreateSP()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSP(Product pro)
        {
            try
            {
                var dao = new UserDao();
                long id = dao.Insert(pro);
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index","Product");
                }
                return View(pro);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit1(int id)
        {
            var pro = new UserDao().ViewDetail(id);
            return View(pro);
        }
        // POST: Admin/Product/Edit1/5
        [HttpPost]
        public ActionResult Edit1(Product pro)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Update1(pro);
                if (res)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật không thành công.");
                }
            }
            return View("Index");
        }
        [HttpDelete]
        public ActionResult Delete1(int id)
        {
            var pro = new UserDao().Delete1(id);
            return RedirectToAction("Index");
        }

    }
}