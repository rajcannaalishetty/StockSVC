﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockQuoteConsume.StockServiceConsume {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StockServiceConsume.IStockService")]
    public interface IStockService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockService/GetQuote", ReplyAction="http://tempuri.org/IStockService/GetQuoteResponse")]
        string GetQuote(string codename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockService/GetQuote", ReplyAction="http://tempuri.org/IStockService/GetQuoteResponse")]
        System.Threading.Tasks.Task<string> GetQuoteAsync(string codename);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockServiceChannel : StockQuoteConsume.StockServiceConsume.IStockService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockServiceClient : System.ServiceModel.ClientBase<StockQuoteConsume.StockServiceConsume.IStockService>, StockQuoteConsume.StockServiceConsume.IStockService {
        
        public StockServiceClient() {
        }
        
        public StockServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetQuote(string codename) {
            return base.Channel.GetQuote(codename);
        }
        
        public System.Threading.Tasks.Task<string> GetQuoteAsync(string codename) {
            return base.Channel.GetQuoteAsync(codename);
        }
    }
}
