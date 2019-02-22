using System.Runtime.Serialization;
using System.ServiceModel;

namespace WeatherForecast
{
    [ServiceContract]
    public interface IWeatherReport
    {
        [OperationContract]
        WeatherData GetCityTemprature(string city);
    }

    [DataContract]
    public class WeatherData
    {
        string _state = "";
        string _city = "";
        double _maxTemp = 0.0;
        double _minTemp = 0.0;

        [DataMember]
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        [DataMember]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        [DataMember]
        public double MaxTemprature
        {
            get { return _maxTemp; }
            set { _maxTemp = value; }
        }

        [DataMember]
        public double MinTemprature
        {
            get { return _minTemp; }
            set { _minTemp = value; }
        }
    }
}
