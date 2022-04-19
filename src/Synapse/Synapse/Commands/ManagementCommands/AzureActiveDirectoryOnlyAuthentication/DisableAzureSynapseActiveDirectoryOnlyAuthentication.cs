﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models;
using Microsoft.Azure.Commands.Synapse.Properties;
using System.Management.Automation;
using Microsoft.Azure.Management.Synapse.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.Synapse
{
    [Cmdlet(VerbsLifecycle.Disable, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.ActiveDirectoryOnlyAuthentication,
        DefaultParameterSetName = DisableByNameParameterSet, SupportsShouldProcess = true)]
    [OutputType(typeof(PSAzureADOnlyAuthentication))]
    public class DisableAzureSynapseActiveDirectoryOnlyAuthentication : SynapseManagementCmdletBase
    {
        private const string DisableByNameParameterSet = "DisableByNameParameterSet";
        private const string DisableByParentObjectParameterSet = "DisableByParentObjectParameterSet";
        private const string DisableByResourceIdParameterSet = "DisableByResourceIdParameterSet";

        [Parameter(ParameterSetName = DisableByNameParameterSet, Mandatory = false, HelpMessage = HelpMessages.ResourceGroupName)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = DisableByNameParameterSet, Mandatory = true, HelpMessage = HelpMessages.WorkspaceName)]
        [ResourceNameCompleter(ResourceTypes.Workspace, nameof(ResourceGroupName))]
        [ValidateNotNullOrEmpty]
        public string WorkspaceName { get; set; }

        [Parameter(ValueFromPipeline = true, ParameterSetName = DisableByParentObjectParameterSet, Mandatory = true, HelpMessage = HelpMessages.WorkspaceObject)]
        [ValidateNotNull]
        public PSSynapseWorkspace WorkspaceObject { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = false, ParameterSetName = DisableByResourceIdParameterSet,
            Mandatory = true, HelpMessage = HelpMessages.WorkspaceResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.WorkspaceObject))
            {
                this.ResourceGroupName = new ResourceIdentifier(this.WorkspaceObject.Id).ResourceGroupName;
                this.WorkspaceName = this.WorkspaceObject.Name;
            }

            if (this.IsParameterBound(c => c.ResourceId))
            {
                var resourceIdentifier = new ResourceIdentifier(this.ResourceId);
                this.ResourceGroupName = resourceIdentifier.ResourceGroupName;
                this.WorkspaceName = resourceIdentifier.ResourceName;
            }

            if (string.IsNullOrEmpty(this.ResourceGroupName))
            {
                this.ResourceGroupName = this.SynapseAnalyticsClient.GetResourceGroupByWorkspaceName(this.WorkspaceName);
            }

            var azureADOnlyAuthentication = new AzureADOnlyAuthentication
            {
                AzureADOnlyAuthenticationProperty = false
            };

            if (this.ShouldProcess(this.WorkspaceName,string.Format(Resources.DisablingAzureADOnlyAuthentication, this.WorkspaceName)))
            {
                var result = new PSAzureADOnlyAuthentication(SynapseAnalyticsClient.CreateOrUpdateAzureADOnlyAuthentication(this.ResourceGroupName, this.WorkspaceName, azureADOnlyAuthentication), this.WorkspaceName);
                WriteObject(result);
            }
        }
    }
}
