// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the origin.</summary>
    public partial class OriginUpdatePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginUpdatePropertiesParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IOriginUpdatePropertiesParametersInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Origin is enabled for load balancing or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Backing field for <see cref="HttpPort" /> property.</summary>
        private int? _httpPort;

        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? HttpPort { get => this._httpPort; set => this._httpPort = value; }

        /// <summary>Backing field for <see cref="HttpsPort" /> property.</summary>
        private int? _httpsPort;

        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? HttpsPort { get => this._httpsPort; set => this._httpsPort = value; }

        /// <summary>Backing field for <see cref="OriginHostHeader" /> property.</summary>
        private string _originHostHeader;

        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string OriginHostHeader { get => this._originHostHeader; set => this._originHostHeader = value; }

        /// <summary>Backing field for <see cref="Priority" /> property.</summary>
        private int? _priority;

        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? Priority { get => this._priority; set => this._priority = value; }

        /// <summary>Backing field for <see cref="PrivateLinkAlias" /> property.</summary>
        private string _privateLinkAlias;

        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string PrivateLinkAlias { get => this._privateLinkAlias; set => this._privateLinkAlias = value; }

        /// <summary>Backing field for <see cref="PrivateLinkApprovalMessage" /> property.</summary>
        private string _privateLinkApprovalMessage;

        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string PrivateLinkApprovalMessage { get => this._privateLinkApprovalMessage; set => this._privateLinkApprovalMessage = value; }

        /// <summary>Backing field for <see cref="PrivateLinkLocation" /> property.</summary>
        private string _privateLinkLocation;

        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string PrivateLinkLocation { get => this._privateLinkLocation; set => this._privateLinkLocation = value; }

        /// <summary>Backing field for <see cref="PrivateLinkResourceId" /> property.</summary>
        private string _privateLinkResourceId;

        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string PrivateLinkResourceId { get => this._privateLinkResourceId; set => this._privateLinkResourceId = value; }

        /// <summary>Backing field for <see cref="Weight" /> property.</summary>
        private int? _weight;

        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? Weight { get => this._weight; set => this._weight = value; }

        /// <summary>Creates an new <see cref="OriginUpdatePropertiesParameters" /> instance.</summary>
        public OriginUpdatePropertiesParameters()
        {

        }
    }
    /// The JSON object that contains the properties of the origin.
    public partial interface IOriginUpdatePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Origin is enabled for load balancing or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Origin is enabled for load balancing or not",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the HTTP port. Must be between 1 and 65535.",
        SerializedName = @"httpPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the HTTPS port. Must be between 1 and 65535.",
        SerializedName = @"httpsPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpsPort { get; set; }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint",
        SerializedName = @"originHostHeader",
        PossibleTypes = new [] { typeof(string) })]
        string OriginHostHeader { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int? Priority { get; set; }
        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'",
        SerializedName = @"privateLinkAlias",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkAlias { get; set; }
        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A custom message to be included in the approval request to connect to the Private Link.",
        SerializedName = @"privateLinkApprovalMessage",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkApprovalMessage { get; set; }
        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated",
        SerializedName = @"privateLinkLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'",
        SerializedName = @"privateLinkResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceId { get; set; }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Weight of the origin in given origin group for load balancing. Must be between 1 and 1000",
        SerializedName = @"weight",
        PossibleTypes = new [] { typeof(int) })]
        int? Weight { get; set; }

    }
    /// The JSON object that contains the properties of the origin.
    internal partial interface IOriginUpdatePropertiesParametersInternal

    {
        /// <summary>Origin is enabled for load balancing or not</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        int? HttpsPort { get; set; }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        string OriginHostHeader { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        int? Priority { get; set; }
        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        string PrivateLinkAlias { get; set; }
        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        string PrivateLinkApprovalMessage { get; set; }
        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        string PrivateLinkResourceId { get; set; }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        int? Weight { get; set; }

    }
}