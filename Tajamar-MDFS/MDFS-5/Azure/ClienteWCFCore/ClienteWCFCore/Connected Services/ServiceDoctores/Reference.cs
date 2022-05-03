﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceDoctores
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/ServiceDoctoresSql.Models")]
    public partial class Doctor : object
    {
        
        private string ApellidoField;
        
        private string EspecialidadField;
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido
        {
            get
            {
                return this.ApellidoField;
            }
            set
            {
                this.ApellidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Especialidad
        {
            get
            {
                return this.EspecialidadField;
            }
            set
            {
                this.EspecialidadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDoctores.IServiceDoctores")]
    public interface IServiceDoctores
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDoctores/GetDoctores", ReplyAction="http://tempuri.org/IServiceDoctores/GetDoctoresResponse")]
        System.Threading.Tasks.Task<ServiceDoctores.Doctor[]> GetDoctoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDoctores/BuscarDoctor", ReplyAction="http://tempuri.org/IServiceDoctores/BuscarDoctorResponse")]
        System.Threading.Tasks.Task<ServiceDoctores.Doctor> BuscarDoctorAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IServiceDoctoresChannel : ServiceDoctores.IServiceDoctores, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ServiceDoctoresClient : System.ServiceModel.ClientBase<ServiceDoctores.IServiceDoctores>, ServiceDoctores.IServiceDoctores
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceDoctoresClient() : 
                base(ServiceDoctoresClient.GetDefaultBinding(), ServiceDoctoresClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceDoctores.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceDoctoresClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceDoctoresClient.GetBindingForEndpoint(endpointConfiguration), ServiceDoctoresClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceDoctoresClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceDoctoresClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceDoctoresClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceDoctoresClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceDoctoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceDoctores.Doctor[]> GetDoctoresAsync()
        {
            return base.Channel.GetDoctoresAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceDoctores.Doctor> BuscarDoctorAsync(int Id)
        {
            return base.Channel.BuscarDoctorAsync(Id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceDoctores))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceDoctores))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfservicedoctoresrcdlt.azurewebsites.net/ServiceDoctores.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceDoctoresClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceDoctores);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceDoctoresClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceDoctores);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceDoctores,
        }
    }
}
