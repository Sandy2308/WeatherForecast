﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiDemo.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeatherData", Namespace="http://schemas.datacontract.org/2004/07/WeatherForecast")]
    [System.SerializableAttribute()]
    public partial class WeatherData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MaxTempratureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MinTempratureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MaxTemprature {
            get {
                return this.MaxTempratureField;
            }
            set {
                if ((this.MaxTempratureField.Equals(value) != true)) {
                    this.MaxTempratureField = value;
                    this.RaisePropertyChanged("MaxTemprature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MinTemprature {
            get {
                return this.MinTempratureField;
            }
            set {
                if ((this.MinTempratureField.Equals(value) != true)) {
                    this.MinTempratureField = value;
                    this.RaisePropertyChanged("MinTemprature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWeatherReport")]
    public interface IWeatherReport {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherReport/GetCityTemprature", ReplyAction="http://tempuri.org/IWeatherReport/GetCityTempratureResponse")]
        WebApiDemo.ServiceReference1.WeatherData GetCityTemprature(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherReport/GetCityTemprature", ReplyAction="http://tempuri.org/IWeatherReport/GetCityTempratureResponse")]
        System.Threading.Tasks.Task<WebApiDemo.ServiceReference1.WeatherData> GetCityTempratureAsync(string city);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherReportChannel : WebApiDemo.ServiceReference1.IWeatherReport, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherReportClient : System.ServiceModel.ClientBase<WebApiDemo.ServiceReference1.IWeatherReport>, WebApiDemo.ServiceReference1.IWeatherReport {
        
        public WeatherReportClient() {
        }
        
        public WeatherReportClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherReportClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherReportClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherReportClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApiDemo.ServiceReference1.WeatherData GetCityTemprature(string city) {
            return base.Channel.GetCityTemprature(city);
        }
        
        public System.Threading.Tasks.Task<WebApiDemo.ServiceReference1.WeatherData> GetCityTempratureAsync(string city) {
            return base.Channel.GetCityTempratureAsync(city);
        }
    }
}
