using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5_HW1.Models;

namespace MVC5_HW1.Controllers
{
    public class MainCustomerController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: MainCustomer
        public ActionResult Index()
        {
            return View(db.客戶聯絡人與銀行帳戶數量.ToList());
        }
    }
}
