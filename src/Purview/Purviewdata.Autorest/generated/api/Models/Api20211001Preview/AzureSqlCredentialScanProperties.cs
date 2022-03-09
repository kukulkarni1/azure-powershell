// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class AzureSqlCredentialScanProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlCredentialScanProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlCredentialScanPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanProperties __azureSqlScanProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzureSqlScanProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).Collection = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CollectionLastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CollectionReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CollectionReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CollectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CollectionType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IConnectedVia ConnectedVia { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ConnectedVia; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ConnectedVia = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ConnectedViaReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ConnectedViaReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ConnectedViaReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CreatedAt; }

        /// <summary>Backing field for <see cref="Credential" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference _credential;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference Credential { get => (this._credential = this._credential ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CredentialReference()); set => this._credential = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string CredentialReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)Credential).ReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)Credential).ReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType? CredentialType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)Credential).CredentialType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)Credential).CredentialType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType)""); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string DatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanPropertiesInternal)__azureSqlScanProperties).DatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanPropertiesInternal)__azureSqlScanProperties).DatabaseName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).LastModifiedAt; }

        /// <summary>Internal Acessors for Credential</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlCredentialScanPropertiesInternal.Credential { get => (this._credential = this._credential ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CredentialReference()); set { {_credential = value;} } }

        /// <summary>Internal Acessors for CollectionLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CollectionLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CollectionLastModifiedAt = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).CreatedAt = value; }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).LastModifiedAt = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ScanRulesetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ScanRulesetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ScanRulesetName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType? ScanRulesetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ScanRulesetType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).ScanRulesetType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType)""); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ServerEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanPropertiesInternal)__azureSqlScanProperties).ServerEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanPropertiesInternal)__azureSqlScanProperties).ServerEndpoint = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public int? Worker { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).Worker; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__azureSqlScanProperties).Worker = value ?? default(int); }

        /// <summary>Creates an new <see cref="AzureSqlCredentialScanProperties" /> instance.</summary>
        public AzureSqlCredentialScanProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureSqlScanProperties), __azureSqlScanProperties);
            await eventListener.AssertObjectIsValid(nameof(__azureSqlScanProperties), __azureSqlScanProperties);
        }
    }
    public partial interface IAzureSqlCredentialScanProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanProperties
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"referenceName",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialReferenceName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"credentialType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType? CredentialType { get; set; }

    }
    internal partial interface IAzureSqlCredentialScanPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlScanPropertiesInternal
    {
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference Credential { get; set; }

        string CredentialReferenceName { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType? CredentialType { get; set; }

    }
}