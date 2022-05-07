// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Extensions;

    /// <summary>ARM proxy resource.</summary>
    public partial class ProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IProxyResource,
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IProxyResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.Resource();

        /// <summary>ARM resource id of the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Id; }

        /// <summary>Region where the VM is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Name = value ?? null; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ProxyResource" /> instance.</summary>
        public ProxyResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// ARM proxy resource.
    public partial interface IProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResource
    {

    }
    /// ARM proxy resource.
    internal partial interface IProxyResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.Api20180630Preview.IResourceInternal
    {

    }
}