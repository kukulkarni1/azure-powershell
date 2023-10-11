// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Json;
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>
    /// Gets or sets a list of key value pairs that describe the set of User Assigned identities that will be used with this volume
    /// group. The key is the ARM resource identifier of the identity.
    /// </summary>
    public partial class IdentityUserAssignedIdentities
    {
        partial void AfterToJson(ref JsonObject container)
        {
            if (this.__additionalProperties != null)
            {
                foreach (var key in this.__additionalProperties)
                {
                    if (key.Value == null)
                    {
                        container.Add(key.Key, Runtime.Json.XNull.Instance);
                    }
                }
            }
        }
    }
}