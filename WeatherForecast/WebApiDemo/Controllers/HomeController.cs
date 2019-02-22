using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiDemo.Models;
using WebApiDemo.ServiceReference1;


namespace WebApiDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<SelectListItem>
            {
             new SelectListItem{ Text="15 Seconds", Value = "15" },
             new SelectListItem{ Text="30 Seconds", Value = "30" },
             new SelectListItem{ Text="45 Seconds", Value = "45" },
             new SelectListItem{ Text="60 Seconds", Value = "60", Selected = true },
            };
            ViewBag.IntervalDropDown = list;

            WeatherReportClient obj = new WeatherReportClient();
            string city = "Surat";
            WeatherData result = new WeatherData();
            result = obj.GetCityTemprature(city);
            ViewBag.state = result.State;
            ViewBag.city = result.City;
            ViewBag.MaxTemprature = result.MaxTemprature;
            ViewBag.MinTemprature = result.MinTemprature;
            return View("Index");
        }

        //[HttpPost]
        public ActionResult IntervalCall()
        {
            WeatherReportClient obj = new WeatherReportClient();
            string city = "Bhopal";
            WeatherData result = new WeatherData();
            result = obj.GetCityTemprature(city);
            ViewBag.state = result.State;
            ViewBag.city = result.City;
            ViewBag.MaxTemprature = result.MaxTemprature;
            ViewBag.MinTemprature = result.MinTemprature;
            return View("IntervalData");
        }
    }
}
