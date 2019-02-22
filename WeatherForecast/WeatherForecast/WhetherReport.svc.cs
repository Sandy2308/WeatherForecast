using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Collections.Generic;
using System.Web;
using System.Web.Hosting;

namespace WeatherForecast
{
    public class WeatherReport : IWeatherReport
    {
        public WeatherData GetCityTemprature(string city)
        {
            string url = HostingEnvironment.MapPath("~/App_Data/City.xml");
            XElement xe = XElement.Load(url);
            var query = from xElem in xe.Elements("City")
                        where xElem.Element("Name").Value == city
                        select new WeatherData
                        {
                            City = (string)xElem.Element("Name"),
                            State = (string)xElem.Element("State"),
                            MaxTemprature = Convert.ToDouble(xElem.Element("MaxTemp").Value),
                            MinTemprature = Convert.ToDouble(xElem.Element("MinTemp").Value),
                        };

            WeatherData wd = query.First();
            return wd;
        }
    }
}
