﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laba7forms.WS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dictionary", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Dictionary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string surnameField;
        
        private int numberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.surnameField, value) != true)) {
                    this.surnameField = value;
                    this.RaisePropertyChanged("surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем GetAllResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        laba7forms.WS.GetAllResponse GetAll(laba7forms.WS.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<laba7forms.WS.GetAllResponse> GetAllAsync(laba7forms.WS.GetAllRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем GetDictResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDict", ReplyAction="*")]
        laba7forms.WS.GetDictResponse GetDict(laba7forms.WS.GetDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDict", ReplyAction="*")]
        System.Threading.Tasks.Task<laba7forms.WS.GetDictResponse> GetDictAsync(laba7forms.WS.GetDictRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем surname из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddDict", ReplyAction="*")]
        laba7forms.WS.AddDictResponse AddDict(laba7forms.WS.AddDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddDict", ReplyAction="*")]
        System.Threading.Tasks.Task<laba7forms.WS.AddDictResponse> AddDictAsync(laba7forms.WS.AddDictRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем surname из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdDict", ReplyAction="*")]
        laba7forms.WS.UpdDictResponse UpdDict(laba7forms.WS.UpdDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdDict", ReplyAction="*")]
        System.Threading.Tasks.Task<laba7forms.WS.UpdDictResponse> UpdDictAsync(laba7forms.WS.UpdDictRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем DelDictResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DelDict", ReplyAction="*")]
        laba7forms.WS.DelDictResponse DelDict(laba7forms.WS.DelDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DelDict", ReplyAction="*")]
        System.Threading.Tasks.Task<laba7forms.WS.DelDictResponse> DelDictAsync(laba7forms.WS.DelDictRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(laba7forms.WS.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(laba7forms.WS.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(string GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDict", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.GetDictRequestBody Body;
        
        public GetDictRequest() {
        }
        
        public GetDictRequest(laba7forms.WS.GetDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetDictRequestBody {
        
        public GetDictRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.GetDictResponseBody Body;
        
        public GetDictResponse() {
        }
        
        public GetDictResponse(laba7forms.WS.GetDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public laba7forms.WS.Dictionary[] GetDictResult;
        
        public GetDictResponseBody() {
        }
        
        public GetDictResponseBody(laba7forms.WS.Dictionary[] GetDictResult) {
            this.GetDictResult = GetDictResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDict", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.AddDictRequestBody Body;
        
        public AddDictRequest() {
        }
        
        public AddDictRequest(laba7forms.WS.AddDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddDictRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string surname;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int number;
        
        public AddDictRequestBody() {
        }
        
        public AddDictRequestBody(string surname, int number) {
            this.surname = surname;
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.AddDictResponseBody Body;
        
        public AddDictResponse() {
        }
        
        public AddDictResponse(laba7forms.WS.AddDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddDictResult;
        
        public AddDictResponseBody() {
        }
        
        public AddDictResponseBody(string AddDictResult) {
            this.AddDictResult = AddDictResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdDict", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.UpdDictRequestBody Body;
        
        public UpdDictRequest() {
        }
        
        public UpdDictRequest(laba7forms.WS.UpdDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdDictRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string surname;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int number;
        
        public UpdDictRequestBody() {
        }
        
        public UpdDictRequestBody(int id, string surname, int number) {
            this.id = id;
            this.surname = surname;
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.UpdDictResponseBody Body;
        
        public UpdDictResponse() {
        }
        
        public UpdDictResponse(laba7forms.WS.UpdDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdDictResult;
        
        public UpdDictResponseBody() {
        }
        
        public UpdDictResponseBody(string UpdDictResult) {
            this.UpdDictResult = UpdDictResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelDict", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.DelDictRequestBody Body;
        
        public DelDictRequest() {
        }
        
        public DelDictRequest(laba7forms.WS.DelDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DelDictRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public DelDictRequestBody() {
        }
        
        public DelDictRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public laba7forms.WS.DelDictResponseBody Body;
        
        public DelDictResponse() {
        }
        
        public DelDictResponse(laba7forms.WS.DelDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DelDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DelDictResult;
        
        public DelDictResponseBody() {
        }
        
        public DelDictResponseBody(string DelDictResult) {
            this.DelDictResult = DelDictResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : laba7forms.WS.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<laba7forms.WS.WebServiceSoap>, laba7forms.WS.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        laba7forms.WS.GetAllResponse laba7forms.WS.WebServiceSoap.GetAll(laba7forms.WS.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public string GetAll() {
            laba7forms.WS.GetAllRequest inValue = new laba7forms.WS.GetAllRequest();
            inValue.Body = new laba7forms.WS.GetAllRequestBody();
            laba7forms.WS.GetAllResponse retVal = ((laba7forms.WS.WebServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<laba7forms.WS.GetAllResponse> laba7forms.WS.WebServiceSoap.GetAllAsync(laba7forms.WS.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<laba7forms.WS.GetAllResponse> GetAllAsync() {
            laba7forms.WS.GetAllRequest inValue = new laba7forms.WS.GetAllRequest();
            inValue.Body = new laba7forms.WS.GetAllRequestBody();
            return ((laba7forms.WS.WebServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        laba7forms.WS.GetDictResponse laba7forms.WS.WebServiceSoap.GetDict(laba7forms.WS.GetDictRequest request) {
            return base.Channel.GetDict(request);
        }
        
        public laba7forms.WS.Dictionary[] GetDict() {
            laba7forms.WS.GetDictRequest inValue = new laba7forms.WS.GetDictRequest();
            inValue.Body = new laba7forms.WS.GetDictRequestBody();
            laba7forms.WS.GetDictResponse retVal = ((laba7forms.WS.WebServiceSoap)(this)).GetDict(inValue);
            return retVal.Body.GetDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<laba7forms.WS.GetDictResponse> laba7forms.WS.WebServiceSoap.GetDictAsync(laba7forms.WS.GetDictRequest request) {
            return base.Channel.GetDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<laba7forms.WS.GetDictResponse> GetDictAsync() {
            laba7forms.WS.GetDictRequest inValue = new laba7forms.WS.GetDictRequest();
            inValue.Body = new laba7forms.WS.GetDictRequestBody();
            return ((laba7forms.WS.WebServiceSoap)(this)).GetDictAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        laba7forms.WS.AddDictResponse laba7forms.WS.WebServiceSoap.AddDict(laba7forms.WS.AddDictRequest request) {
            return base.Channel.AddDict(request);
        }
        
        public string AddDict(string surname, int number) {
            laba7forms.WS.AddDictRequest inValue = new laba7forms.WS.AddDictRequest();
            inValue.Body = new laba7forms.WS.AddDictRequestBody();
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            laba7forms.WS.AddDictResponse retVal = ((laba7forms.WS.WebServiceSoap)(this)).AddDict(inValue);
            return retVal.Body.AddDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<laba7forms.WS.AddDictResponse> laba7forms.WS.WebServiceSoap.AddDictAsync(laba7forms.WS.AddDictRequest request) {
            return base.Channel.AddDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<laba7forms.WS.AddDictResponse> AddDictAsync(string surname, int number) {
            laba7forms.WS.AddDictRequest inValue = new laba7forms.WS.AddDictRequest();
            inValue.Body = new laba7forms.WS.AddDictRequestBody();
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            return ((laba7forms.WS.WebServiceSoap)(this)).AddDictAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        laba7forms.WS.UpdDictResponse laba7forms.WS.WebServiceSoap.UpdDict(laba7forms.WS.UpdDictRequest request) {
            return base.Channel.UpdDict(request);
        }
        
        public string UpdDict(int id, string surname, int number) {
            laba7forms.WS.UpdDictRequest inValue = new laba7forms.WS.UpdDictRequest();
            inValue.Body = new laba7forms.WS.UpdDictRequestBody();
            inValue.Body.id = id;
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            laba7forms.WS.UpdDictResponse retVal = ((laba7forms.WS.WebServiceSoap)(this)).UpdDict(inValue);
            return retVal.Body.UpdDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<laba7forms.WS.UpdDictResponse> laba7forms.WS.WebServiceSoap.UpdDictAsync(laba7forms.WS.UpdDictRequest request) {
            return base.Channel.UpdDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<laba7forms.WS.UpdDictResponse> UpdDictAsync(int id, string surname, int number) {
            laba7forms.WS.UpdDictRequest inValue = new laba7forms.WS.UpdDictRequest();
            inValue.Body = new laba7forms.WS.UpdDictRequestBody();
            inValue.Body.id = id;
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            return ((laba7forms.WS.WebServiceSoap)(this)).UpdDictAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        laba7forms.WS.DelDictResponse laba7forms.WS.WebServiceSoap.DelDict(laba7forms.WS.DelDictRequest request) {
            return base.Channel.DelDict(request);
        }
        
        public string DelDict(int id) {
            laba7forms.WS.DelDictRequest inValue = new laba7forms.WS.DelDictRequest();
            inValue.Body = new laba7forms.WS.DelDictRequestBody();
            inValue.Body.id = id;
            laba7forms.WS.DelDictResponse retVal = ((laba7forms.WS.WebServiceSoap)(this)).DelDict(inValue);
            return retVal.Body.DelDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<laba7forms.WS.DelDictResponse> laba7forms.WS.WebServiceSoap.DelDictAsync(laba7forms.WS.DelDictRequest request) {
            return base.Channel.DelDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<laba7forms.WS.DelDictResponse> DelDictAsync(int id) {
            laba7forms.WS.DelDictRequest inValue = new laba7forms.WS.DelDictRequest();
            inValue.Body = new laba7forms.WS.DelDictRequestBody();
            inValue.Body.id = id;
            return ((laba7forms.WS.WebServiceSoap)(this)).DelDictAsync(inValue);
        }
    }
}
