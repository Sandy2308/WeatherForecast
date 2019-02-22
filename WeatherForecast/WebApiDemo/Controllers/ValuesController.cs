using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;
using System.Xml;
using System.Xml.Linq;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class ValuesController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginSucess(LoginDetails loginDetails)
        {
            string url = Server.MapPath("~/App_Data/Users.xml");

            XElement booksFromFile = XElement.Load(url);

            var username = booksFromFile.Descendants("username");
            foreach (var usernames in username)
            {
                if (usernames.FirstNode.ToString() == loginDetails.username)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return new EmptyResult();
        }
    }
}
