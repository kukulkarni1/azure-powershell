// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PowerShell;

    /// <summary>Class representing a read write database.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReadWriteDatabaseTypeConverter))]
    public partial class ReadWriteDatabase
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.ReadWriteDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReadWriteDatabase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.ReadWriteDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReadWriteDatabase(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReadWriteDatabase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.ReadWriteDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReadWriteDatabase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.ReadWriteDatabasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind.CreateFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Statistics"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Statistics = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseStatistics) content.GetValueForProperty("Statistics",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Statistics, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.DatabaseStatisticsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeletePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).SoftDeletePeriod = (global::System.TimeSpan?) content.GetValueForProperty("SoftDeletePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).SoftDeletePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("HotCachePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).HotCachePeriod = (global::System.TimeSpan?) content.GetValueForProperty("HotCachePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).HotCachePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("IsFollowed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).IsFollowed = (bool?) content.GetValueForProperty("IsFollowed",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).IsFollowed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("StatisticsSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).StatisticsSize = (float?) content.GetValueForProperty("StatisticsSize",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).StatisticsSize, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.ReadWriteDatabase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReadWriteDatabase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.ReadWriteDatabasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Kind.CreateFrom);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Statistics"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Statistics = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IDatabaseStatistics) content.GetValueForProperty("Statistics",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).Statistics, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.DatabaseStatisticsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SoftDeletePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).SoftDeletePeriod = (global::System.TimeSpan?) content.GetValueForProperty("SoftDeletePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).SoftDeletePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("HotCachePeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).HotCachePeriod = (global::System.TimeSpan?) content.GetValueForProperty("HotCachePeriod",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).HotCachePeriod, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("IsFollowed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).IsFollowed = (bool?) content.GetValueForProperty("IsFollowed",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).IsFollowed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("StatisticsSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).StatisticsSize = (float?) content.GetValueForProperty("StatisticsSize",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20220201.IReadWriteDatabaseInternal)this).StatisticsSize, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class representing a read write database.
    [System.ComponentModel.TypeConverter(typeof(ReadWriteDatabaseTypeConverter))]
    public partial interface IReadWriteDatabase

    {

    }
}