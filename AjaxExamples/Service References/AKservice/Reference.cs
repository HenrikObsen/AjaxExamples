﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjaxExamples.AKservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bil", Namespace="http://schemas.datacontract.org/2004/07/AKrepo")]
    [System.SerializableAttribute()]
    public partial class Bil : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BeskrivelseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProducentIDField;
        
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
        public string Beskrivelse {
            get {
                return this.BeskrivelseField;
            }
            set {
                if ((object.ReferenceEquals(this.BeskrivelseField, value) != true)) {
                    this.BeskrivelseField = value;
                    this.RaisePropertyChanged("Beskrivelse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Pris {
            get {
                return this.PrisField;
            }
            set {
                if ((this.PrisField.Equals(value) != true)) {
                    this.PrisField = value;
                    this.RaisePropertyChanged("Pris");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProducentID {
            get {
                return this.ProducentIDField;
            }
            set {
                if ((this.ProducentIDField.Equals(value) != true)) {
                    this.ProducentIDField = value;
                    this.RaisePropertyChanged("ProducentID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AKservice.IAKservice")]
    public interface IAKservice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/DoWork", ReplyAction="http://tempuri.org/IAKservice/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/DoWork", ReplyAction="http://tempuri.org/IAKservice/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/HentBil", ReplyAction="http://tempuri.org/IAKservice/HentBilResponse")]
        AjaxExamples.AKservice.Bil HentBil();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/HentBil", ReplyAction="http://tempuri.org/IAKservice/HentBilResponse")]
        System.Threading.Tasks.Task<AjaxExamples.AKservice.Bil> HentBilAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/HentAlleBiler", ReplyAction="http://tempuri.org/IAKservice/HentAlleBilerResponse")]
        AjaxExamples.AKservice.Bil[] HentAlleBiler();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/HentAlleBiler", ReplyAction="http://tempuri.org/IAKservice/HentAlleBilerResponse")]
        System.Threading.Tasks.Task<AjaxExamples.AKservice.Bil[]> HentAlleBilerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/OpretBil", ReplyAction="http://tempuri.org/IAKservice/OpretBilResponse")]
        void OpretBil(AjaxExamples.AKservice.Bil b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAKservice/OpretBil", ReplyAction="http://tempuri.org/IAKservice/OpretBilResponse")]
        System.Threading.Tasks.Task OpretBilAsync(AjaxExamples.AKservice.Bil b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAKserviceChannel : AjaxExamples.AKservice.IAKservice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AKserviceClient : System.ServiceModel.ClientBase<AjaxExamples.AKservice.IAKservice>, AjaxExamples.AKservice.IAKservice {
        
        public AKserviceClient() {
        }
        
        public AKserviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AKserviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AKserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AKserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public AjaxExamples.AKservice.Bil HentBil() {
            return base.Channel.HentBil();
        }
        
        public System.Threading.Tasks.Task<AjaxExamples.AKservice.Bil> HentBilAsync() {
            return base.Channel.HentBilAsync();
        }
        
        public AjaxExamples.AKservice.Bil[] HentAlleBiler() {
            return base.Channel.HentAlleBiler();
        }
        
        public System.Threading.Tasks.Task<AjaxExamples.AKservice.Bil[]> HentAlleBilerAsync() {
            return base.Channel.HentAlleBilerAsync();
        }
        
        public void OpretBil(AjaxExamples.AKservice.Bil b) {
            base.Channel.OpretBil(b);
        }
        
        public System.Threading.Tasks.Task OpretBilAsync(AjaxExamples.AKservice.Bil b) {
            return base.Channel.OpretBilAsync(b);
        }
    }
}
