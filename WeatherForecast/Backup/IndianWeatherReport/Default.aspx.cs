using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndianWeatherReport.WeatherReport;

namespace IndianWeatherReport
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void btnShow_Click(object sender, EventArgs e)
        {
            WeatherReportClient reportClient = new WeatherReportClient();
            WeatherData wd = reportClient.GetCityTemprature(cmbCity.Text);

            lblState.Text = "State : " + wd.State;
            lblCity.Text = "City : " + wd.City;
            lblMax.Text = wd.MaxTemprature.ToString() + " C";
            lblMin.Text = wd.MinTemprature.ToString() + " C";
        }
    }
}
