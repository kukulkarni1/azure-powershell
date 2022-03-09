
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
Create a in-memory object for NetworkInterfaceIPConfiguration
.Description
Create a in-memory object for NetworkInterfaceIPConfiguration

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterfaceIPConfiguration
.Link
https://docs.microsoft.com/powershell/module/az.ConnectedNetwork/new-AzConnectedNetworkInterfaceIPConfigurationObject
#>
function New-AzConnectedNetworkInterfaceIPConfigurationObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterfaceIPConfiguration')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The list of DNS servers IP addresses.")]
        [string[]]
        $DnsServer,
        [Parameter(HelpMessage="The value of the gateway.")]
        [string]
        $Gateway,
        [Parameter(HelpMessage="The value of the IP address.")]
        [string]
        $IPAddress,
        [Parameter(HelpMessage="IP address allocation method.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.IPAllocationMethod]
        $IPAllocationMethod,
        [Parameter(HelpMessage="IP address version.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.IPVersion]
        $IPVersion,
        [Parameter(HelpMessage="The value of the subnet.")]
        [string]
        $Subnet
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterfaceIPConfiguration]::New()

        $Object.DnsServer = $DnsServer
        $Object.Gateway = $Gateway
        $Object.IPAddress = $IPAddress
        $Object.IPAllocationMethod = $IPAllocationMethod
        $Object.IPVersion = $IPVersion
        $Object.Subnet = $Subnet
        return $Object
    }
}

