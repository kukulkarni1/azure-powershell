
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
Create an in-memory object for AdlsGen2CredentialScan.
.Description
Create an in-memory object for AdlsGen2CredentialScan.
.Example
PS C:\> New-AzPurviewAdlsGen2CredentialScanObject -Kind 'AdlsGen2Credential' -CollectionReferenceName 'parv-brs-2' -CollectionType 'CollectionReference' -CredentialReferenceName 'datascantestdataparv-accountkey' -CredentialType 'AccountKey' -ScanRulesetName 'AdlsGen2'  -ScanRulesetType 'System'

CollectionLastModifiedAt  :
CollectionReferenceName   : parv-brs-2
CollectionType            : CollectionReference
ConnectedViaReferenceName :
CreatedAt                 :
CredentialReferenceName   : datascantestdataparv-accountkey
CredentialType            : AccountKey
Id                        :
Kind                      : AdlsGen2Credential
LastModifiedAt            :
Name                      :
Result                    :
ScanRulesetName           : AdlsGen2
ScanRulesetType           : System
Worker                    :

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AdlsGen2CredentialScan
.Link
https://docs.microsoft.com/powershell/module/az.Purview/new-AzPurviewAdlsGen2CredentialScanObject
#>
function New-AzPurviewAdlsGen2CredentialScanObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AdlsGen2CredentialScan])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType]
    ${Kind},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${CollectionReferenceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${CollectionType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${ConnectedViaReferenceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${CredentialReferenceName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType]
    ${CredentialType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${ScanRulesetName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType]
    ${ScanRulesetType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.Int32]
    ${Worker}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.Purviewdata.custom\New-AzPurviewAdlsGen2CredentialScanObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
