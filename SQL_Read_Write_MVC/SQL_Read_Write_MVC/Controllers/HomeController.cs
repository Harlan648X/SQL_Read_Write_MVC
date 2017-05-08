using SQL_Read_Write_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQL_Read_Write_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRecord(RecordInfo record)
        {
            SqlDAL dal = new SqlDAL();
            record.DayTime = DateTime.Now;
            dal.Write2DB(record);
            //return View("Result", dal.ReadDB());
            return RedirectToAction("Result", "Home"); 
        }

        public ActionResult Result()
        {
            SqlDAL dal = new SqlDAL();
            return View("Result", dal.ReadDB());
        }

    }
}