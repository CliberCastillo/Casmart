//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServiceBus
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bus", Namespace="http://schemas.datacontract.org/2004/07/WCFAgenciaBuses.Entities")]
    public partial class Bus : object
    {
        
        private string EstadoBusField;
        
        private string IdBusField;
        
        private string NroPlacaField;
        
        private int NumeroAsientoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstadoBus
        {
            get
            {
                return this.EstadoBusField;
            }
            set
            {
                this.EstadoBusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdBus
        {
            get
            {
                return this.IdBusField;
            }
            set
            {
                this.IdBusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroPlaca
        {
            get
            {
                return this.NroPlacaField;
            }
            set
            {
                this.NroPlacaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroAsiento
        {
            get
            {
                return this.NumeroAsientoField;
            }
            set
            {
                this.NumeroAsientoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Empleado", Namespace="http://schemas.datacontract.org/2004/07/WCFAgenciaBuses.Entities")]
    public partial class Empleado : object
    {
        
        private string ApellidoMaternoField;
        
        private string ApellidoPaternoField;
        
        private string CorreoField;
        
        private string DNIField;
        
        private string IdAreaField;
        
        private string IdCargoField;
        
        private string IdEmpleadoField;
        
        private string NombreCargoField;
        
        private string NombresField;
        
        private string TelefonoField;
        
        private string TipoDocumentoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoMaterno
        {
            get
            {
                return this.ApellidoMaternoField;
            }
            set
            {
                this.ApellidoMaternoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno
        {
            get
            {
                return this.ApellidoPaternoField;
            }
            set
            {
                this.ApellidoPaternoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo
        {
            get
            {
                return this.CorreoField;
            }
            set
            {
                this.CorreoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI
        {
            get
            {
                return this.DNIField;
            }
            set
            {
                this.DNIField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdArea
        {
            get
            {
                return this.IdAreaField;
            }
            set
            {
                this.IdAreaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCargo
        {
            get
            {
                return this.IdCargoField;
            }
            set
            {
                this.IdCargoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdEmpleado
        {
            get
            {
                return this.IdEmpleadoField;
            }
            set
            {
                this.IdEmpleadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCargo
        {
            get
            {
                return this.NombreCargoField;
            }
            set
            {
                this.NombreCargoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres
        {
            get
            {
                return this.NombresField;
            }
            set
            {
                this.NombresField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono
        {
            get
            {
                return this.TelefonoField;
            }
            set
            {
                this.TelefonoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDocumento
        {
            get
            {
                return this.TipoDocumentoField;
            }
            set
            {
                this.TipoDocumentoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Distrito", Namespace="http://schemas.datacontract.org/2004/07/WCFAgenciaBuses.Entities")]
    public partial class Distrito : object
    {
        
        private string CpostalField;
        
        private string IdProvinciaField;
        
        private string NombreField;
        
        private string NombreProvinciaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cpostal
        {
            get
            {
                return this.CpostalField;
            }
            set
            {
                this.CpostalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdProvincia
        {
            get
            {
                return this.IdProvinciaField;
            }
            set
            {
                this.IdProvinciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProvincia
        {
            get
            {
                return this.NombreProvinciaField;
            }
            set
            {
                this.NombreProvinciaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cargo", Namespace="http://schemas.datacontract.org/2004/07/WCFAgenciaBuses.Entities")]
    public partial class Cargo : object
    {
        
        private string IdField;
        
        private string IdAreaField;
        
        private string NombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdArea
        {
            get
            {
                return this.IdAreaField;
            }
            set
            {
                this.IdAreaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MisCompras", Namespace="http://schemas.datacontract.org/2004/07/WCFAgenciaBuses.Entities")]
    public partial class MisCompras : object
    {
        
        private string AgenciaDestinoField;
        
        private string AgenciaOrigenField;
        
        private string ApellidoMaternoField;
        
        private string ApellidoPaternoField;
        
        private System.DateTime HoraViajeField;
        
        private string NombresField;
        
        private string NroPlacaField;
        
        private string NumeroDocumentoField;
        
        private int PrecioViajeField;
        
        private string TelefonoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgenciaDestino
        {
            get
            {
                return this.AgenciaDestinoField;
            }
            set
            {
                this.AgenciaDestinoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgenciaOrigen
        {
            get
            {
                return this.AgenciaOrigenField;
            }
            set
            {
                this.AgenciaOrigenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoMaterno
        {
            get
            {
                return this.ApellidoMaternoField;
            }
            set
            {
                this.ApellidoMaternoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno
        {
            get
            {
                return this.ApellidoPaternoField;
            }
            set
            {
                this.ApellidoPaternoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime HoraViaje
        {
            get
            {
                return this.HoraViajeField;
            }
            set
            {
                this.HoraViajeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres
        {
            get
            {
                return this.NombresField;
            }
            set
            {
                this.NombresField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroPlaca
        {
            get
            {
                return this.NroPlacaField;
            }
            set
            {
                this.NroPlacaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroDocumento
        {
            get
            {
                return this.NumeroDocumentoField;
            }
            set
            {
                this.NumeroDocumentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PrecioViaje
        {
            get
            {
                return this.PrecioViajeField;
            }
            set
            {
                this.PrecioViajeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono
        {
            get
            {
                return this.TelefonoField;
            }
            set
            {
                this.TelefonoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBus.IServiceBus")]
    public interface IServiceBus
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/ListaBuses", ReplyAction="http://tempuri.org/IServiceBus/ListaBusesResponse")]
        System.Threading.Tasks.Task<ServiceBus.Bus[]> ListaBusesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/InsertarBus", ReplyAction="http://tempuri.org/IServiceBus/InsertarBusResponse")]
        System.Threading.Tasks.Task<int> InsertarBusAsync(ServiceBus.Bus bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/ListaEmpleado", ReplyAction="http://tempuri.org/IServiceBus/ListaEmpleadoResponse")]
        System.Threading.Tasks.Task<ServiceBus.Empleado[]> ListaEmpleadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/InsertarEmpleado", ReplyAction="http://tempuri.org/IServiceBus/InsertarEmpleadoResponse")]
        System.Threading.Tasks.Task<int> InsertarEmpleadoAsync(ServiceBus.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/ListaDistrito", ReplyAction="http://tempuri.org/IServiceBus/ListaDistritoResponse")]
        System.Threading.Tasks.Task<ServiceBus.Distrito[]> ListaDistritoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/InsertarDistrito", ReplyAction="http://tempuri.org/IServiceBus/InsertarDistritoResponse")]
        System.Threading.Tasks.Task<int> InsertarDistritoAsync(ServiceBus.Distrito distrito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/ListaCargo", ReplyAction="http://tempuri.org/IServiceBus/ListaCargoResponse")]
        System.Threading.Tasks.Task<ServiceBus.Cargo[]> ListaCargoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/InsertarCargo", ReplyAction="http://tempuri.org/IServiceBus/InsertarCargoResponse")]
        System.Threading.Tasks.Task<int> InsertarCargoAsync(ServiceBus.Cargo cargo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBus/MisCompras", ReplyAction="http://tempuri.org/IServiceBus/MisComprasResponse")]
        System.Threading.Tasks.Task<ServiceBus.MisCompras[]> MisComprasAsync(string DNI);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IServiceBusChannel : ServiceBus.IServiceBus, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ServiceBusClient : System.ServiceModel.ClientBase<ServiceBus.IServiceBus>, ServiceBus.IServiceBus
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceBusClient() : 
                base(ServiceBusClient.GetDefaultBinding(), ServiceBusClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceBus.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceBusClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceBusClient.GetBindingForEndpoint(endpointConfiguration), ServiceBusClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceBusClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceBusClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceBusClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceBusClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceBusClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceBus.Bus[]> ListaBusesAsync()
        {
            return base.Channel.ListaBusesAsync();
        }
        
        public System.Threading.Tasks.Task<int> InsertarBusAsync(ServiceBus.Bus bus)
        {
            return base.Channel.InsertarBusAsync(bus);
        }
        
        public System.Threading.Tasks.Task<ServiceBus.Empleado[]> ListaEmpleadoAsync()
        {
            return base.Channel.ListaEmpleadoAsync();
        }
        
        public System.Threading.Tasks.Task<int> InsertarEmpleadoAsync(ServiceBus.Empleado empleado)
        {
            return base.Channel.InsertarEmpleadoAsync(empleado);
        }
        
        public System.Threading.Tasks.Task<ServiceBus.Distrito[]> ListaDistritoAsync()
        {
            return base.Channel.ListaDistritoAsync();
        }
        
        public System.Threading.Tasks.Task<int> InsertarDistritoAsync(ServiceBus.Distrito distrito)
        {
            return base.Channel.InsertarDistritoAsync(distrito);
        }
        
        public System.Threading.Tasks.Task<ServiceBus.Cargo[]> ListaCargoAsync()
        {
            return base.Channel.ListaCargoAsync();
        }
        
        public System.Threading.Tasks.Task<int> InsertarCargoAsync(ServiceBus.Cargo cargo)
        {
            return base.Channel.InsertarCargoAsync(cargo);
        }
        
        public System.Threading.Tasks.Task<ServiceBus.MisCompras[]> MisComprasAsync(string DNI)
        {
            return base.Channel.MisComprasAsync(DNI);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceBus))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceBus))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59500/ServiceBus.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceBusClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceBus);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceBusClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceBus);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceBus,
        }
    }
}
