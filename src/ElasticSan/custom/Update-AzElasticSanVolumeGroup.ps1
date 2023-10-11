
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Update an VolumeGroup.
.Description
Update an VolumeGroup.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ELASTICSANINPUTOBJECT <IElasticSanIdentity>: Identity Parameter
  [ElasticSanName <String>]: The name of the ElasticSan.
  [Id <String>]: Resource identity path
  [PrivateEndpointConnectionName <String>]: The name of the Private Endpoint connection.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SnapshotName <String>]: The name of the volume snapshot within the given volume group.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VolumeGroupName <String>]: The name of the VolumeGroup.
  [VolumeName <String>]: The name of the Volume.

INPUTOBJECT <IElasticSanIdentity>: Identity Parameter
  [ElasticSanName <String>]: The name of the ElasticSan.
  [Id <String>]: Resource identity path
  [PrivateEndpointConnectionName <String>]: The name of the Private Endpoint connection.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SnapshotName <String>]: The name of the volume snapshot within the given volume group.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VolumeGroupName <String>]: The name of the VolumeGroup.
  [VolumeName <String>]: The name of the Volume.

NETWORKACLSVIRTUALNETWORKRULE <IVirtualNetworkRule[]>: The list of virtual network rules.
  VirtualNetworkResourceId <String>: Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
  [Action <String>]: The action of virtual network rule.
.Link
https://learn.microsoft.com/powershell/module/az.elasticsan/update-azelasticsanvolumegroup
#>
function Update-AzElasticSanVolumeGroup {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroup])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
        [System.String]
        # The name of the ElasticSan.
        ${ElasticSanName},
    
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaIdentityElasticSanExpanded', Mandatory)]
        [Alias('VolumeGroupName')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
        [System.String]
        # The name of the VolumeGroup.
        ${Name},
    
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},
    
        [Parameter(ParameterSetName='UpdateExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},
    
        [Parameter(ParameterSetName='UpdateViaIdentityElasticSanExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanIdentity]
        # Identity Parameter
        # To construct, see NOTES section for ELASTICSANINPUTOBJECT properties and create a hash table.
        ${ElasticSanInputObject},
    
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PSArgumentCompleterAttribute("EncryptionAtRestWithPlatformKey", "EncryptionAtRestWithCustomerManagedKey")]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # Type of encryption
        ${Encryption},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # Resource identifier of the UserAssigned identity to be associated with server-side encryption on the volume group.
        ${EncryptionUserAssignedIdentity},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned")]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # The identity type.
        ${IdentityType},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # Gets or sets a list of key value pairs that describe the set of User Assigned identities that will be used with this volume group.
        # The key is the ARM resource identifier of the identity.
        ${IdentityUserAssignedIdentityId},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # The name of KeyVault key.
        ${KeyName},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # The Uri of KeyVault.
        ${KeyVaultUri},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # The version of KeyVault key.
        ${KeyVersion},
    
        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVirtualNetworkRule[]]
        # The list of virtual network rules.
        # To construct, see NOTES section for NETWORKACLSVIRTUALNETWORKRULE properties and create a hash table.
        ${NetworkAclsVirtualNetworkRule},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PSArgumentCompleterAttribute("Iscsi", "None")]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
        [System.String]
        # Type of storage target
        ${ProtocolType},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        if ($PSBoundParameters.ContainsKey('IdentityUserAssignedIdentityId')) {
            $userIdentityObject = [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.UserAssignedIdentity]::New()
            # $userAssignedIdentityId = $IdentityUserAssignedIdentityId
            $PSBoundParameters.IdentityUserAssignedIdentity = @{$IdentityUserAssignedIdentityId=$userIdentityObject}   
            
            $volumeGroupProperties = $null
            switch ($PSCmdlet.ParameterSetName) {
                "UpdateViaIdentityElasticSanExpanded" {
                    $elasticSanId = $ElasticSanInputObject.Id
                    $volumeGroupProperties = $ElasticSanInputObject | Az.ElasticSan\Get-AzElasticSanVolumeGroup -Name $Name
                    $PSBoundParameters.ElasticSanInputObject.Id = $elasticSanId
                    break
                }
                "UpdateViaIdentityExpanded" {
                    $volumeGroupProperties = $InputObject | Az.ElasticSan\Get-AzElasticSanVolumeGroup
                    break
                }
                Default {
                    $volumeGroupProperties = AZ.ElasticSan\Get-AzElasticSanVolumeGroup -Nam $Name -ResourceGroupName $ResourceGroupName -ElasticSanName $ElasticSanName
                    break 
                }
            }

            if ($volumeGroupProperties.IdentityUserAssignedIdentity -ne $null) {
                $volumeGroupProperties.IdentityUserAssignedIdentity.Keys | ForEach-Object {
                    if ($_ -ne $IdentityUserAssignedIdentityId) {
                        # $PSBoundParameters.IdentityUserAssignedIdentity.Add($_, $userIdentityObject)
                        $PSBoundParameters.IdentityUserAssignedIdentity.Add($_, $null)
                    }
                }
            }
            $null = $PSBoundParameters.Remove('IdentityUserAssignedIdentityId')
        }
        Az.ElasticSan.internal\Update-AzElasticSanVolumeGroup @PSBoundParameters
    }
}
    