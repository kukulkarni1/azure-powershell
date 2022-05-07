// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Extensions;

    /// <summary>Guest configuration assignment properties.</summary>
    public partial class GuestConfigurationAssignmentProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IGuestConfigurationAssignmentProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IGuestConfigurationAssignmentProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IGuestConfigurationAssignmentProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json ? new GuestConfigurationAssignmentProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject into a new instance of <see cref="GuestConfigurationAssignmentProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GuestConfigurationAssignmentProperties(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_guestConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject>("guestConfiguration"), out var __jsonGuestConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.GuestConfigurationNavigation.FromJson(__jsonGuestConfiguration) : GuestConfiguration;}
            {_latestAssignmentReport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject>("latestAssignmentReport"), out var __jsonLatestAssignmentReport) ? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.AssignmentReport.FromJson(__jsonLatestAssignmentReport) : LatestAssignmentReport;}
            {_targetResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("targetResourceId"), out var __jsonTargetResourceId) ? (string)__jsonTargetResourceId : (string)TargetResourceId;}
            {_complianceStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("complianceStatus"), out var __jsonComplianceStatus) ? (string)__jsonComplianceStatus : (string)ComplianceStatus;}
            {_lastComplianceStatusChecked = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("lastComplianceStatusChecked"), out var __jsonLastComplianceStatusChecked) ? global::System.DateTime.TryParse((string)__jsonLastComplianceStatusChecked, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastComplianceStatusCheckedValue) ? __jsonLastComplianceStatusCheckedValue : LastComplianceStatusChecked : LastComplianceStatusChecked;}
            {_latestReportId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("latestReportId"), out var __jsonLatestReportId) ? (string)__jsonLatestReportId : (string)LatestReportId;}
            {_parameterHash = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("parameterHash"), out var __jsonParameterHash) ? (string)__jsonParameterHash : (string)ParameterHash;}
            {_context = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("context"), out var __jsonContext) ? (string)__jsonContext : (string)Context;}
            {_assignmentHash = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("assignmentHash"), out var __jsonAssignmentHash) ? (string)__jsonAssignmentHash : (string)AssignmentHash;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_resourceType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("resourceType"), out var __jsonResourceType) ? (string)__jsonResourceType : (string)ResourceType;}
            {_vmssVMList = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonArray>("vmssVMList"), out var __jsonVmssVMList) ? If( __jsonVmssVMList as Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVmssvmInfo[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.IVmssvmInfo) (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20220125.VmssvmInfo.FromJson(__u) )) ))() : null : VmssVMList;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GuestConfigurationAssignmentProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GuestConfigurationAssignmentProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._guestConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) this._guestConfiguration.ToJson(null,serializationMode) : null, "guestConfiguration" ,container.Add );
            AddIf( null != this._latestAssignmentReport ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) this._latestAssignmentReport.ToJson(null,serializationMode) : null, "latestAssignmentReport" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._targetResourceId.ToString()) : null, "targetResourceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._complianceStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._complianceStatus.ToString()) : null, "complianceStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastComplianceStatusChecked ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._lastComplianceStatusChecked?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastComplianceStatusChecked" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._latestReportId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._latestReportId.ToString()) : null, "latestReportId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._parameterHash)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._parameterHash.ToString()) : null, "parameterHash" ,container.Add );
            }
            AddIf( null != (((object)this._context)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._context.ToString()) : null, "context" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._assignmentHash)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._assignmentHash.ToString()) : null, "assignmentHash" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._resourceType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._resourceType.ToString()) : null, "resourceType" ,container.Add );
            }
            if (null != this._vmssVMList)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.XNodeArray();
                foreach( var __x in this._vmssVMList )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("vmssVMList",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}