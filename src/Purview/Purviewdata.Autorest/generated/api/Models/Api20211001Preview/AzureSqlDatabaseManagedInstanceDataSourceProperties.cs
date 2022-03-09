// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class AzureSqlDatabaseManagedInstanceDataSourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstanceDataSourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstanceDataSourcePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstanceProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstanceProperties __azureSqlDatabaseManagedInstanceProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzureSqlDatabaseManagedInstanceProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).Collection = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CollectionLastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CollectionReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CollectionReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CollectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CollectionType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).LastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).Location = value ?? null; }

        /// <summary>Internal Acessors for CollectionLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal.CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CollectionLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CollectionLastModifiedAt = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).CreatedAt = value; }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).LastModifiedAt = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).ResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).ResourceGroup = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).ResourceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ServerEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstancePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).ServerEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstancePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).ServerEndpoint = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureDataSourcePropertiesInternal)__azureSqlDatabaseManagedInstanceProperties).SubscriptionId = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="AzureSqlDatabaseManagedInstanceDataSourceProperties" /> instance.
        /// </summary>
        public AzureSqlDatabaseManagedInstanceDataSourceProperties()
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
            await eventListener.AssertNotNull(nameof(__azureSqlDatabaseManagedInstanceProperties), __azureSqlDatabaseManagedInstanceProperties);
            await eventListener.AssertObjectIsValid(nameof(__azureSqlDatabaseManagedInstanceProperties), __azureSqlDatabaseManagedInstanceProperties);
        }
    }
    public partial interface IAzureSqlDatabaseManagedInstanceDataSourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstanceProperties
    {

    }
    internal partial interface IAzureSqlDatabaseManagedInstanceDataSourcePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAzureSqlDatabaseManagedInstancePropertiesInternal
    {

    }
}