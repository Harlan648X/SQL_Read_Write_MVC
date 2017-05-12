using SQL_Read_Write_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQL_Read_Write_MVC.DAL;

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
            record.DayTime = DateTime.UtcNow;
            dal.Write2DB(record);
            //return View("Result", dal.ReadDB());
            return RedirectToAction("Result", "Home", new { input = record.Input }); 
        }

        public ActionResult Result(string input)
        {
            SqlDAL dal = new SqlDAL();
            RecordModel result = new RecordModel();
            result = dal.ReadDB();
            result.IsSecretWord = dal.IsSecretWord(input);
            result.WordGuessed = input;
            return View("Result", result);
        }

    }
}