// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>Defines the parameters for the route configuration override action.</summary>
    [System.ComponentModel.TypeConverter(typeof(RouteConfigurationOverrideActionParametersTypeConverter))]
    public partial class RouteConfigurationOverrideActionParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RouteConfigurationOverrideActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RouteConfigurationOverrideActionParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RouteConfigurationOverrideActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RouteConfigurationOverrideActionParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RouteConfigurationOverrideActionParameters" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="RouteConfigurationOverrideActionParameters" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RouteConfigurationOverrideActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RouteConfigurationOverrideActionParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OriginGroupOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverride = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupOverride) content.GetValueForProperty("OriginGroupOverride",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverride, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.OriginGroupOverrideTypeConverter.ConvertFrom);
            }
            if (content.Contains("CacheConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICacheConfiguration) content.GetValueForProperty("CacheConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.CacheConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("TypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).TypeName = (string) content.GetValueForProperty("TypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).TypeName, global::System.Convert.ToString);
            }
            if (content.Contains("OriginGroupOverrideForwardingProtocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideForwardingProtocol = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol?) content.GetValueForProperty("OriginGroupOverrideForwardingProtocol",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideForwardingProtocol, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol.CreateFrom);
            }
            if (content.Contains("CacheConfigurationQueryParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryParameter = (string) content.GetValueForProperty("CacheConfigurationQueryParameter",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryParameter, global::System.Convert.ToString);
            }
            if (content.Contains("CacheConfigurationCacheDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheDuration = (string) content.GetValueForProperty("CacheConfigurationCacheDuration",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheDuration, global::System.Convert.ToString);
            }
            if (content.Contains("OriginGroupOverrideOriginGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideOriginGroup = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("OriginGroupOverrideOriginGroup",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideOriginGroup, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CacheConfigurationQueryStringCachingBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryStringCachingBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleQueryStringCachingBehavior?) content.GetValueForProperty("CacheConfigurationQueryStringCachingBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryStringCachingBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleQueryStringCachingBehavior.CreateFrom);
            }
            if (content.Contains("CacheConfigurationIsCompressionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationIsCompressionEnabled = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleIsCompressionEnabled?) content.GetValueForProperty("CacheConfigurationIsCompressionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationIsCompressionEnabled, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleIsCompressionEnabled.CreateFrom);
            }
            if (content.Contains("CacheConfigurationCacheBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleCacheBehavior?) content.GetValueForProperty("CacheConfigurationCacheBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleCacheBehavior.CreateFrom);
            }
            if (content.Contains("OriginGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupId = (string) content.GetValueForProperty("OriginGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RouteConfigurationOverrideActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RouteConfigurationOverrideActionParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OriginGroupOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverride = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginGroupOverride) content.GetValueForProperty("OriginGroupOverride",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverride, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.OriginGroupOverrideTypeConverter.ConvertFrom);
            }
            if (content.Contains("CacheConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICacheConfiguration) content.GetValueForProperty("CacheConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.CacheConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("TypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).TypeName = (string) content.GetValueForProperty("TypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).TypeName, global::System.Convert.ToString);
            }
            if (content.Contains("OriginGroupOverrideForwardingProtocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideForwardingProtocol = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol?) content.GetValueForProperty("OriginGroupOverrideForwardingProtocol",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideForwardingProtocol, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol.CreateFrom);
            }
            if (content.Contains("CacheConfigurationQueryParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryParameter = (string) content.GetValueForProperty("CacheConfigurationQueryParameter",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryParameter, global::System.Convert.ToString);
            }
            if (content.Contains("CacheConfigurationCacheDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheDuration = (string) content.GetValueForProperty("CacheConfigurationCacheDuration",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheDuration, global::System.Convert.ToString);
            }
            if (content.Contains("OriginGroupOverrideOriginGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideOriginGroup = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("OriginGroupOverrideOriginGroup",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupOverrideOriginGroup, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CacheConfigurationQueryStringCachingBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryStringCachingBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleQueryStringCachingBehavior?) content.GetValueForProperty("CacheConfigurationQueryStringCachingBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationQueryStringCachingBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleQueryStringCachingBehavior.CreateFrom);
            }
            if (content.Contains("CacheConfigurationIsCompressionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationIsCompressionEnabled = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleIsCompressionEnabled?) content.GetValueForProperty("CacheConfigurationIsCompressionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationIsCompressionEnabled, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleIsCompressionEnabled.CreateFrom);
            }
            if (content.Contains("CacheConfigurationCacheBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleCacheBehavior?) content.GetValueForProperty("CacheConfigurationCacheBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).CacheConfigurationCacheBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleCacheBehavior.CreateFrom);
            }
            if (content.Contains("OriginGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupId = (string) content.GetValueForProperty("OriginGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRouteConfigurationOverrideActionParametersInternal)this).OriginGroupId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Defines the parameters for the route configuration override action.
    [System.ComponentModel.TypeConverter(typeof(RouteConfigurationOverrideActionParametersTypeConverter))]
    public partial interface IRouteConfigurationOverrideActionParameters

    {

    }
}