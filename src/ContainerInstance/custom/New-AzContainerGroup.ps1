
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
Create or update container groups with specified configurations.
.Description
Create or update container groups with specified configurations. For property Volume, we support mounting Azure File share as a volume or specifying git repository as volume directory. The empty directory volume and secret volume are not supported yet.
.Link
https://docs.microsoft.com/powershell/module/az.containerinstance/new-azcontainergroup
#>
function New-AzContainerGroup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroup])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ContainerGroupName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Path')]
    [System.String]
    # The name of the container group.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainer[]]
    # The containers within the container group.
    # To construct, see NOTES section for CONTAINER properties and create a hash table.
    ${Container},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.OperatingSystemTypes])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.DefaultInfo(Description='Sets OSType equal Linux by default.', Script='"Linux"')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.OperatingSystemTypes]
    # The operating system type required by the containers in the container group.
    ${OSType},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String[]]
    # The DNS servers for the container group.
    ${DnsConfigNameServer},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The DNS options for the container group.
    ${DnsConfigOption},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The DNS search domains for hostname lookup in the container group.
    ${DnsConfigSearchDomain},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The encryption key name.
    ${EncryptionPropertyKeyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The encryption key version.
    ${EncryptionPropertyKeyVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The keyvault base url.
    ${EncryptionPropertyVaultBaseUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The Dns name label for the IP.
    ${IPAddressDnsNameLabel},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The IP exposed to the public internet.
    ${IPAddressIP},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IPort[]]
    # The list of ports exposed on the container group.
    # To construct, see NOTES section for IPADDRESSPORT properties and create a hash table.
    ${IPAddressPort},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ContainerGroupIPAddressType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ContainerGroupIPAddressType]
    # Specifies if the IP is exposed to the public internet or private VNET.
    ${IPAddressType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ResourceIdentityType]
    # The type of identity used for the container group.
    # The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities.
    # The type 'None' will remove any identities from the container group.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroupIdentityUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The list of user identities associated with the container group.
    # The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    ${IdentityUserAssignedIdentity},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IImageRegistryCredential[]]
    # The image registry credentials by which the container group is created from.
    # To construct, see NOTES section for IMAGEREGISTRYCREDENTIAL properties and create a hash table.
    ${ImageRegistryCredential},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IInitContainerDefinition[]]
    # The init containers for a container group.
    # To construct, see NOTES section for INITCONTAINER properties and create a hash table.
    ${InitContainer},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The resource location.
    ${Location},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.LogAnalyticsLogType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.LogAnalyticsLogType]
    # The log type to be used.
    ${LogAnalyticLogType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.ILogAnalyticsMetadata]))]
    [System.Collections.Hashtable]
    # Metadata for log analytics.
    ${LogAnalyticMetadata},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The workspace id for log analytics
    ${LogAnalyticWorkspaceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The workspace key for log analytics
    ${LogAnalyticWorkspaceKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String]
    # The workspace resource id for log analytics
    ${LogAnalyticWorkspaceResourceId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ContainerGroupRestartPolicy])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ContainerGroupRestartPolicy]
    # Restart policy for all containers within the container group.
    # - `Always` Always restart- `OnFailure` Restart on failure- `Never` Never restart
    ${RestartPolicy},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ContainerGroupSku])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.ContainerGroupSku]
    # The SKU for a container group.
    ${Sku},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroupSubnetId[]]
    # The subnet resource IDs for a container group.
    # To construct, see NOTES section for SUBNETID properties and create a hash table.
    ${SubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IResourceTags]))]
    [System.Collections.Hashtable]
    # The resource tags.
    ${Tag},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IVolume[]]
    # The list of volumes that can be mounted by containers in this container group.
    # To construct, see NOTES section for VOLUME properties and create a hash table.
    ${Volume},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Body')]
    [System.String[]]
    # The zones for the container group.
    ${Zone},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)
process {
    try {

      if($PSBoundParameters.ContainsKey("IPAddressType") -and !$PSBoundParameters.ContainsKey("IPAddressPort"))
      {
        $null = $PSBoundParameters.Add("IPAddressPort", $Container.Port)
      }
      


      Az.ContainerInstance.internal\New-AzContainerGroup @PSBoundParameters
    } catch {
        throw
    }
}

}
