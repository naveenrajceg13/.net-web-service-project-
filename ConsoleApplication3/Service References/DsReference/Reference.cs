﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication3.DsReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ds", ConfigurationName="DsReference.dsint")]
    public interface dsint {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        byte[] getvideo(string String_1);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        System.Threading.Tasks.Task<byte[]> getvideoAsync(string String_1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface dsintChannel : ConsoleApplication3.DsReference.dsint, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class dsintClient : System.ServiceModel.ClientBase<ConsoleApplication3.DsReference.dsint>, ConsoleApplication3.DsReference.dsint {
        
        public dsintClient() {
        }
        
        public dsintClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public dsintClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public dsintClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public dsintClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] getvideo(string String_1) {
            return base.Channel.getvideo(String_1);
        }
        
        public System.Threading.Tasks.Task<byte[]> getvideoAsync(string String_1) {
            return base.Channel.getvideoAsync(String_1);
        }
    }
}
