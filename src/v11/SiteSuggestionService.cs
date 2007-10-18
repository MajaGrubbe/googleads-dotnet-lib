﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.2407.
// 
namespace com.google.api.adwords.v11 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SiteSuggestionServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v11")]
    public class SiteSuggestionService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public useragent useragentValue;
        
        public password passwordValue;
        
        public email emailValue;
        
        public clientEmail clientEmailValue;
        
        public clientCustomerId clientCustomerIdValue;
        
        public developerToken developerTokenValue;
        
        public applicationToken applicationTokenValue;
        
        public responseTime responseTimeValue;
        
        public operations operationsValue;
        
        public units unitsValue;
        
        public requestId requestIdValue;
        
        /// <remarks/>
        public SiteSuggestionService() {
            this.Url = "https://adwords.google.com/api/adwords/v11/SiteSuggestionService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v11", ResponseNamespace="https://adwords.google.com/api/adwords/v11", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getSitesByCategoryNameReturn")]
        public SiteSuggestion[] getSitesByCategoryName(string categoryName, LanguageGeoTargeting targeting) {
            object[] results = this.Invoke("getSitesByCategoryName", new object[] {
                        categoryName,
                        targeting});
            return ((SiteSuggestion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetSitesByCategoryName(string categoryName, LanguageGeoTargeting targeting, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getSitesByCategoryName", new object[] {
                        categoryName,
                        targeting}, callback, asyncState);
        }
        
        /// <remarks/>
        public SiteSuggestion[] EndgetSitesByCategoryName(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SiteSuggestion[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v11", ResponseNamespace="https://adwords.google.com/api/adwords/v11", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getSitesByDemographicsReturn")]
        public SiteSuggestion[] getSitesByDemographics(DemographicsTarget demo, LanguageGeoTargeting targeting) {
            object[] results = this.Invoke("getSitesByDemographics", new object[] {
                        demo,
                        targeting});
            return ((SiteSuggestion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetSitesByDemographics(DemographicsTarget demo, LanguageGeoTargeting targeting, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getSitesByDemographics", new object[] {
                        demo,
                        targeting}, callback, asyncState);
        }
        
        /// <remarks/>
        public SiteSuggestion[] EndgetSitesByDemographics(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SiteSuggestion[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v11", ResponseNamespace="https://adwords.google.com/api/adwords/v11", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getSitesByTopicsReturn")]
        public SiteSuggestion[] getSitesByTopics([System.Xml.Serialization.XmlElementAttribute("topics")] string[] topics, LanguageGeoTargeting targeting) {
            object[] results = this.Invoke("getSitesByTopics", new object[] {
                        topics,
                        targeting});
            return ((SiteSuggestion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetSitesByTopics(string[] topics, LanguageGeoTargeting targeting, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getSitesByTopics", new object[] {
                        topics,
                        targeting}, callback, asyncState);
        }
        
        /// <remarks/>
        public SiteSuggestion[] EndgetSitesByTopics(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SiteSuggestion[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v11", ResponseNamespace="https://adwords.google.com/api/adwords/v11", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getSitesByUrlsReturn")]
        public SiteSuggestion[] getSitesByUrls([System.Xml.Serialization.XmlElementAttribute("urls")] string[] urls, LanguageGeoTargeting targeting) {
            object[] results = this.Invoke("getSitesByUrls", new object[] {
                        urls,
                        targeting});
            return ((SiteSuggestion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetSitesByUrls(string[] urls, LanguageGeoTargeting targeting, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getSitesByUrls", new object[] {
                        urls,
                        targeting}, callback, asyncState);
        }
        
        /// <remarks/>
        public SiteSuggestion[] EndgetSitesByUrls(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SiteSuggestion[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public class LanguageGeoTargeting {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countries")]
        public string[] countries;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("languages")]
        public string[] languages;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metros")]
        public string[] metros;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("regions")]
        public string[] regions;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public class DemographicsTarget {
        
        /// <remarks/>
        public ChildrenTarget childrenTarget;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool childrenTargetSpecified;
        
        /// <remarks/>
        public EthnicityTarget ethnicityTarget;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ethnicityTargetSpecified;
        
        /// <remarks/>
        public GenderTarget genderTarget;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderTargetSpecified;
        
        /// <remarks/>
        public AgeRange maxAgeRange;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxAgeRangeSpecified;
        
        /// <remarks/>
        public HouseholdIncomeRange maxHouseholdIncomeRange;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxHouseholdIncomeRangeSpecified;
        
        /// <remarks/>
        public AgeRange minAgeRange;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minAgeRangeSpecified;
        
        /// <remarks/>
        public HouseholdIncomeRange minHouseholdIncomeRange;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minHouseholdIncomeRangeSpecified;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public enum ChildrenTarget {
        
        /// <remarks/>
        NoPreference,
        
        /// <remarks/>
        HouseholdsWithChildrenOnly,
        
        /// <remarks/>
        HouseholdsWithoutChildrenOnly,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public enum EthnicityTarget {
        
        /// <remarks/>
        NoPreference,
        
        /// <remarks/>
        CaucasianOnly,
        
        /// <remarks/>
        AfricanAmericanOnly,
        
        /// <remarks/>
        AsianOnly,
        
        /// <remarks/>
        HispanicOnly,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public enum GenderTarget {
        
        /// <remarks/>
        NoPreference,
        
        /// <remarks/>
        FemaleOnly,
        
        /// <remarks/>
        MaleOnly,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public enum AgeRange {
        
        /// <remarks/>
        Range0To17,
        
        /// <remarks/>
        Range18To24,
        
        /// <remarks/>
        Range25To34,
        
        /// <remarks/>
        Range35To44,
        
        /// <remarks/>
        Range45To54,
        
        /// <remarks/>
        Range55To64,
        
        /// <remarks/>
        Range65Plus,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public enum HouseholdIncomeRange {
        
        /// <remarks/>
        Range0To14999,
        
        /// <remarks/>
        Range15000To24999,
        
        /// <remarks/>
        Range25000To39999,
        
        /// <remarks/>
        Range40000To59999,
        
        /// <remarks/>
        Range60000To74999,
        
        /// <remarks/>
        Range75000To99999,
        
        /// <remarks/>
        Range100000PLUS,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v11")]
    public class SiteSuggestion {
        
        /// <remarks/>
        public bool acceptsImageAds;
        
        /// <remarks/>
        public bool acceptsTextAds;
        
        /// <remarks/>
        public bool acceptsVideoAds;
        
        /// <remarks/>
        public int pageViews;
        
        /// <remarks/>
        public string url;
    }
}
