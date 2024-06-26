// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Extensions;

    /// <summary>Gets or sets the Resource tags.</summary>
    public partial class VirtualMachineResourceSettingsTags :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IVirtualMachineResourceSettingsTags,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IVirtualMachineResourceSettingsTagsInternal
    {

        /// <summary>Creates an new <see cref="VirtualMachineResourceSettingsTags" /> instance.</summary>
        public VirtualMachineResourceSettingsTags()
        {

        }
    }
    /// Gets or sets the Resource tags.
    public partial interface IVirtualMachineResourceSettingsTags :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IAssociativeArray<string>
    {

    }
    /// Gets or sets the Resource tags.
    internal partial interface IVirtualMachineResourceSettingsTagsInternal

    {

    }
}