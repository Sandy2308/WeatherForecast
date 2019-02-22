using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Collections.Generic;
using System.Web;

namespace WeatherForecast
{
    public class WeatherReport : IWeatherReport
    {
        public WeatherData GetCityTemprature(string city)
        {
            XElement xe = XElement.Load(@".\WeatherForecast\City.xml");
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
