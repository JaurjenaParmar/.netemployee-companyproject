using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestList.Models;
using TestList.repo;

namespace TestList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            department dept = new department();
            deptCRUD dp = new deptCRUD();
            dept.dept_list = dp.getDepartments();
            return View(dept);
        }
        [HttpPost]
        public ActionResult Index(department dept)
        {
            deptCRUD dp = new deptCRUD();
            dept.dept_list = dp.getDepartments();
            return View(dept);
        }
        
        public ActionResult detail(int id)
        {
            department dept = new department();
            deptCRUD dp = new deptCRUD();
            dp.getStatus(id);
            dept.dept_list = dp.getDepartments();
            return RedirectToAction("Index","Home",dept);
        }


    }
}