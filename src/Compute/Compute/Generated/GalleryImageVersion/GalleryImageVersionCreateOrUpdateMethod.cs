//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Common.Strategies;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "GalleryImageVersion", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSGalleryImageVersion))]
    public partial class NewAzureRmGalleryImageVersion : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.Name, VerbsCommon.New))
                {
                    string resourceGroupName = this.ResourceGroupName;
                    string galleryName = this.GalleryName;
                    string galleryImageName = this.GalleryImageDefinitionName;
                    string galleryImageVersionName = this.Name;
                    GalleryImageVersion galleryImageVersion = new GalleryImageVersion();

                    galleryImageVersion.Location = this.Location;

                    if (this.IsParameterBound(c => c.Tag))
                    {
                        galleryImageVersion.Tags = this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value);
                    }

                    if (this.IsParameterBound(c => c.DataDiskImage))
                    {
                        if (galleryImageVersion.StorageProfile == null)
                        {
                            galleryImageVersion.StorageProfile = new GalleryImageVersionStorageProfile();
                        }
                        galleryImageVersion.StorageProfile.DataDiskImages = this.DataDiskImage;
                    }

                    if (this.IsParameterBound(c => c.OSDiskImage))
                    {
                        if (galleryImageVersion.StorageProfile == null)
                        {
                            galleryImageVersion.StorageProfile = new GalleryImageVersionStorageProfile();
                        }
                        galleryImageVersion.StorageProfile.OsDiskImage = this.OSDiskImage;
                    }

                    if (this.IsParameterBound(c => c.ReplicaCount))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.ReplicaCount = this.ReplicaCount;
                    }

                    if (this.IsParameterBound(c => c.PublishingProfileExcludeFromLatest))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.ExcludeFromLatest = this.PublishingProfileExcludeFromLatest.IsPresent;
                    }

                    if (this.IsParameterBound(c => c.PublishingProfileEndOfLifeDate))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.EndOfLifeDate = this.PublishingProfileEndOfLifeDate;
                    }

                    if (this.IsParameterBound(c => c.StorageAccountType))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.StorageAccountType = this.StorageAccountType;
                    }

                    if (this.IsParameterBound(c => c.TargetRegion))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.TargetRegions = new List<TargetRegion>();
                        foreach (var t in this.TargetRegion)
                        {
                            var target = new TargetRegion()
                            {
                                Name = (string)t["Name"],
                                RegionalReplicaCount = (int?)t["ReplicaCount"],
                                StorageAccountType = (string)t["StorageAccountType"],
                            };
                            if (t["Encryption"] != null)
                            {
                                var osDiskEncryptionSetId = (string)((Hashtable)((Hashtable)t["Encryption"])["osDiskImage"])["DiskEncryptionSetId"];
                                var osDiskImageEncryption = new OSDiskImageEncryption(osDiskEncryptionSetId);

                                List<DataDiskImageEncryption> dataDiskImageEncryption = null;
                                var dataDiskImage = (object[])((Hashtable)t["Encryption"])["dataDiskImages"];
                                
                                if (dataDiskImage != null)
                                {
                                    dataDiskImageEncryption = new List<DataDiskImageEncryption>();
                                    foreach (Hashtable dataDiskEncryptionSetId in dataDiskImage)
                                    {
                                        DataDiskImageEncryption d = new DataDiskImageEncryption((int)dataDiskEncryptionSetId["Lun"], (string)dataDiskEncryptionSetId["DiskEncryptionSetId"]);
                                        dataDiskImageEncryption.Add(d);
                                    }
                                }
                                
                                target.Encryption = new EncryptionImages(osDiskImageEncryption, dataDiskImageEncryption);
                            }

                            galleryImageVersion.PublishingProfile.TargetRegions.Add(target);
                        }
                    }

                    Dictionary<string, List<string>> auxAuthHeader = null;
                    if (this.IsParameterBound(c => c.SourceImageId))
                    {
                        if (galleryImageVersion.StorageProfile == null)
                        {
                            galleryImageVersion.StorageProfile = new GalleryImageVersionStorageProfile();
                        }
                        if (galleryImageVersion.StorageProfile.Source == null)
                        {
                            galleryImageVersion.StorageProfile.Source = new GalleryArtifactVersionSource();
                        }
                        galleryImageVersion.StorageProfile.Source.Id = this.SourceImageId;

                        var resourceId = ResourceId.TryParse(this.SourceImageId);

                        if (string.Equals("galleries", resourceId?.ResourceType?.Provider, StringComparison.OrdinalIgnoreCase)
                         && !string.Equals(this.ComputeClient?.ComputeManagementClient?.SubscriptionId, resourceId?.SubscriptionId, StringComparison.OrdinalIgnoreCase))
                        {
                            List<string> resourceIds = new List<string>();
                            resourceIds.Add(this.SourceImageId);
                            var auxHeaderDictionary = GetAuxilaryAuthHeaderFromResourceIds(resourceIds);
                            if (auxHeaderDictionary != null && auxHeaderDictionary.Count > 0)
                            {
                                auxAuthHeader = new Dictionary<string, List<string>>(auxHeaderDictionary);
                            }
                        }
                    }

                    GalleryImageVersion result;
                    if (auxAuthHeader != null) { 
                        var res = GalleryImageVersionsClient.CreateOrUpdateWithHttpMessagesAsync(
                            this.ResourceGroupName,
                            galleryName,
                            galleryImageName, 
                            galleryImageVersionName, galleryImageVersion,
                            auxAuthHeader).GetAwaiter().GetResult();

                        result = res.Body;
                    }
                    else
                    {
                        result = GalleryImageVersionsClient.CreateOrUpdate(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion);
                    }

                    var psObject = new PSGalleryImageVersion();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<GalleryImageVersion, PSGalleryImageVersion>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string GalleryName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Alias("GalleryImageName")]
        public string GalleryImageDefinitionName { get; set; }

        [Alias("GalleryImageVersionName")]
        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 3,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/Galleries")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public GalleryDataDiskImage [] DataDiskImage { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public GalleryOSDiskImage OSDiskImage { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public DateTime PublishingProfileEndOfLifeDate { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PublishingProfileExcludeFromLatest { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int ReplicaCount { get; set; }

        [Parameter(
           Mandatory = false,
           ValueFromPipelineByPropertyName = true)]
        public string SourceImageId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Standard_LRS", "Standard_ZRS", "Premium_LRS")]
        public string StorageAccountType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable[] TargetRegion { get; set; }
    }

    [Cmdlet(VerbsData.Update, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "GalleryImageVersion", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSGalleryImageVersion))]
    public partial class UpdateAzureRmGalleryImageVersion : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.Name, VerbsData.Update))
                {
                    string resourceGroupName;
                    string galleryName;
                    string galleryImageName;
                    string galleryImageVersionName;
                    switch (this.ParameterSetName)
                    {
                        case "ResourceIdParameter":
                            resourceGroupName = GetResourceGroupName(this.ResourceId);
                            galleryName = GetResourceName(this.ResourceId, "Microsoft.Compute/Galleries", "Images", "Versions");
                            galleryImageName = GetInstanceId(this.ResourceId, "Microsoft.Compute/Galleries", "Images", "Versions");
                            galleryImageVersionName = GetVersion(this.ResourceId, "Microsoft.Compute/Galleries", "Images", "Versions");
                            break;
                        case "ObjectParameter":
                            resourceGroupName = GetResourceGroupName(this.InputObject.Id);
                            galleryName = GetResourceName(this.InputObject.Id, "Microsoft.Compute/Galleries", "Images", "Versions");
                            galleryImageName = GetInstanceId(this.InputObject.Id, "Microsoft.Compute/Galleries", "Images", "Versions");
                            galleryImageVersionName = GetVersion(this.InputObject.Id, "Microsoft.Compute/Galleries", "Images", "Versions");
                            break;
                        default:
                            resourceGroupName = this.ResourceGroupName;
                            galleryName = this.GalleryName;
                            galleryImageName = this.GalleryImageDefinitionName;
                            galleryImageVersionName = this.Name;
                            break;
                    }

                    var galleryImageVersion = new GalleryImageVersion();

                    if (this.ParameterSetName == "ObjectParameter")
                    {
                        ComputeAutomationAutoMapperProfile.Mapper.Map<PSGalleryImageVersion, GalleryImageVersion>(this.InputObject, galleryImageVersion);
                    }
                    else
                    {
                        galleryImageVersion = GalleryImageVersionsClient.Get(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
                    }

                    if (this.IsParameterBound(c => c.Tag))
                    {
                        galleryImageVersion.Tags = this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value);
                    }

                    if (this.IsParameterBound(c => c.ReplicaCount))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.ReplicaCount = this.ReplicaCount;
                    }

                    if (this.IsParameterBound(c => c.PublishingProfileExcludeFromLatest))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.ExcludeFromLatest = this.PublishingProfileExcludeFromLatest.IsPresent;
                    }

                    if (this.IsParameterBound(c => c.PublishingProfileEndOfLifeDate))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.EndOfLifeDate = this.PublishingProfileEndOfLifeDate;
                    }

                    if (this.IsParameterBound(c => c.TargetRegion))
                    {
                        if (galleryImageVersion.PublishingProfile == null)
                        {
                            galleryImageVersion.PublishingProfile = new GalleryImageVersionPublishingProfile();
                        }
                        galleryImageVersion.PublishingProfile.TargetRegions = new List<TargetRegion>();
                        foreach (var t in this.TargetRegion)
                        {
                            var target = new TargetRegion()
                            {
                                Name = (string)t["Name"],
                                RegionalReplicaCount = (int?)t["ReplicaCount"],
                                StorageAccountType = (string)t["StorageAccountType"],
                            };
                            if (t["Encryption"] != null)
                            {
                                var osDiskEncryptionSetId = (string)((Hashtable)((Hashtable)t["Encryption"])["osDiskImage"])["DiskEncryptionSetId"];
                                var osDiskImageEncryption = new OSDiskImageEncryption(osDiskEncryptionSetId);

                                List<DataDiskImageEncryption> dataDiskImageEncryption = null;
                                var dataDiskImage = (object[])((Hashtable)t["Encryption"])["dataDiskImages"];

                                if (dataDiskImage != null)
                                {
                                    dataDiskImageEncryption = new List<DataDiskImageEncryption>();
                                    foreach (Hashtable dataDiskEncryptionSetId in dataDiskImage)
                                    {
                                        DataDiskImageEncryption d = new DataDiskImageEncryption((int)dataDiskEncryptionSetId["Lun"], (string)dataDiskEncryptionSetId["DiskEncryptionSetId"]);
                                        dataDiskImageEncryption.Add(d);
                                    }
                                }

                                target.Encryption = new EncryptionImages(osDiskImageEncryption, dataDiskImageEncryption);
                            }

                            galleryImageVersion.PublishingProfile.TargetRegions.Add(target);
                        }
                    }

                    if (galleryImageVersion.StorageProfile != null && galleryImageVersion.StorageProfile.Source != null && galleryImageVersion.StorageProfile.Source.Id != null)
                    {
                        galleryImageVersion.StorageProfile.Source.Id = null;
                    }

                    galleryImageVersion.StorageProfile.DataDiskImages = null;
                    galleryImageVersion.StorageProfile.OsDiskImage = null;

                    var result = GalleryImageVersionsClient.CreateOrUpdate(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion);
                    var psObject = new PSGalleryImageVersion();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<GalleryImageVersion, PSGalleryImageVersion>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string GalleryName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Alias("GalleryImageName")]
        public string GalleryImageDefinitionName { get; set; }

        [Alias("GalleryImageVersionName")]
        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 3,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            ParameterSetName = "ResourceIdParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string ResourceId { get; set; }

        [Alias("GalleryImageVersion")]
        [Parameter(
            ParameterSetName = "ObjectParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true)]
        public PSGalleryImageVersion InputObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public DateTime PublishingProfileEndOfLifeDate { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PublishingProfileExcludeFromLatest { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int ReplicaCount { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable[] TargetRegion { get; set; }
    }
}
