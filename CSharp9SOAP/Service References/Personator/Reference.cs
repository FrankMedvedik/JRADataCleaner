﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JRADataCleanUI.Personator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:MelissaDataPersonator", ConfigurationName="Personator.ServicemdContactVerifySOAP")]
    public interface ServicemdContactVerifySOAP {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:MelissaDataPersonator/ServicemdContactVerifySOAP/doContactVerify", ReplyAction="urn:MelissaDataPersonator/ServicemdContactVerifySOAP/doContactVerifyResponse")]
        JRAMelissaWrapper.Personator.Response doContactVerify(JRAMelissaWrapper.Personator.Request Request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicemdContactVerifySOAPChannel : JRADataCleanUI.Personator.ServicemdContactVerifySOAP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicemdContactVerifySOAPClient : System.ServiceModel.ClientBase<JRADataCleanUI.Personator.ServicemdContactVerifySOAP>, JRADataCleanUI.Personator.ServicemdContactVerifySOAP {
        
        public ServicemdContactVerifySOAPClient() {
        }
        
        public ServicemdContactVerifySOAPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicemdContactVerifySOAPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicemdContactVerifySOAPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicemdContactVerifySOAPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public JRAMelissaWrapper.Personator.Response doContactVerify(JRAMelissaWrapper.Personator.Request Request) {
            return base.Channel.doContactVerify(Request);
        }
    }
}
