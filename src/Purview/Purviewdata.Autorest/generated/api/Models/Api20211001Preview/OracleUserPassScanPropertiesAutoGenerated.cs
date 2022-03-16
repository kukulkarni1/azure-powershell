// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class OracleUserPassScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanProperties __oracleUserPassScanProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.OracleUserPassScanProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).Collection = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CollectionLastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CollectionReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CollectionReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CollectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CollectionType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IConnectedVia ConnectedVia { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ConnectedVia; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ConnectedVia = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ConnectedViaReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ConnectedViaReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ConnectedViaReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string DriverLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).DriverLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).DriverLocation = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).LastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string MaximumMemoryAllowedInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)__oracleUserPassScanProperties).MaximumMemoryAllowedInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)__oracleUserPassScanProperties).MaximumMemoryAllowedInGb = value ?? null; }

        /// <summary>Internal Acessors for CollectionLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CollectionLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CollectionLastModifiedAt = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).CreatedAt = value; }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).LastModifiedAt = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string MitiCache { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)__oracleUserPassScanProperties).MitiCache; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)__oracleUserPassScanProperties).MitiCache = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Password { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).Password = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ScanRulesetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ScanRulesetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ScanRulesetName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType? ScanRulesetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ScanRulesetType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).ScanRulesetType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType)""); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Schema { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).Schema; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).Schema = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Username { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).Username; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal)__oracleUserPassScanProperties).Username = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public int? Worker { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).Worker; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)__oracleUserPassScanProperties).Worker = value ?? default(int); }

        /// <summary>
        /// Creates an new <see cref="OracleUserPassScanPropertiesAutoGenerated" /> instance.
        /// </summary>
        public OracleUserPassScanPropertiesAutoGenerated()
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
            await eventListener.AssertNotNull(nameof(__oracleUserPassScanProperties), __oracleUserPassScanProperties);
            await eventListener.AssertObjectIsValid(nameof(__oracleUserPassScanProperties), __oracleUserPassScanProperties);
        }
    }
    public partial interface IOracleUserPassScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanProperties
    {

    }
    internal partial interface IOracleUserPassScanPropertiesAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IOracleUserPassScanPropertiesInternal
    {

    }
}