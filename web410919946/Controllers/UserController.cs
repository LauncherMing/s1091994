using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410919946.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(String name,String account,String password)
        {//IsNullOrWhiteSpace() need using Microsoft.Ajax.Utilities
            if (name.IsNullOrWhiteSpace())//if (name == null || name == "")
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (account.IsNullOrWhiteSpace())//if (account == null || account == "")
            {
                ViewBag.AccountMessage = "請輸入帳號";
            }
            if (password.IsNullOrWhiteSpace())//if (password == null || password == "")
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }
            if (!name.IsNullOrWhiteSpace() && !account.IsNullOrWhiteSpace() && !password.IsNullOrWhiteSpace())
            //if (!(name == null || name == "") && !(account == null || account == "") && !(password == null || password == ""))
            {
                ViewBag.Message = "註冊成功";
            }
            return View();
        }
    }
}