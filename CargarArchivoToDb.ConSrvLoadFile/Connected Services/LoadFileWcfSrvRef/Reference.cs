﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CargarArchivoToDb.ConSrvLoadFile.LoadFileWcfSrvRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoadFileWcfSrvRef.ICargarAsignaSrv")]
    public interface ICargarAsignaSrv {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargarAsignaSrv/CargarAsignacion", ReplyAction="http://tempuri.org/ICargarAsignaSrv/CargarAsignacionResponse")]
        void CargarAsignacion(string pData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICargarAsignaSrv/CargarAsignacion", ReplyAction="http://tempuri.org/ICargarAsignaSrv/CargarAsignacionResponse")]
        System.Threading.Tasks.Task CargarAsignacionAsync(string pData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICargarAsignaSrvChannel : CargarArchivoToDb.ConSrvLoadFile.LoadFileWcfSrvRef.ICargarAsignaSrv, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CargarAsignaSrvClient : System.ServiceModel.ClientBase<CargarArchivoToDb.ConSrvLoadFile.LoadFileWcfSrvRef.ICargarAsignaSrv>, CargarArchivoToDb.ConSrvLoadFile.LoadFileWcfSrvRef.ICargarAsignaSrv {
        
        public CargarAsignaSrvClient() {
        }
        
        public CargarAsignaSrvClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CargarAsignaSrvClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CargarAsignaSrvClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CargarAsignaSrvClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CargarAsignacion(string pData) {
            base.Channel.CargarAsignacion(pData);
        }
        
        public System.Threading.Tasks.Task CargarAsignacionAsync(string pData) {
            return base.Channel.CargarAsignacionAsync(pData);
        }
    }
}