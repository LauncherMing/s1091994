using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web410919946.ViewModel;

namespace web410919946.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }
        [HttpPost]
        public ActionResult SignUp(SignUpData data)
        {//IsNullOrWhiteSpace() need using Microsoft.Ajax.Utilities
            /*if (data.Name.IsNullOrWhiteSpace())//if (name == null || name == "")
            {
                data.NameMessage = "請輸入姓名";
            }
            if (data.Account.IsNullOrWhiteSpace())//if (account == null || account == "")
            {
                data.AccountMessage = "請輸入帳號";
            }
            if (data.Password.IsNullOrWhiteSpace())//if (password == null || password == "")
            {
                data.PasswordMessage = "請輸入密碼";
            }*/
            if (ModelState.IsValid)
            //if (!(name == null || name == "") && !(account == null || account == "") && !(password == null || password == ""))
            {
                ViewBag.Message = "註冊成功";
            }
            return View(data);
        }
    }
}