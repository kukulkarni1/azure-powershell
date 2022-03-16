// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.DoNotFormat]
    public partial class Trigger :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITrigger,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ProxyResource();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)__proxyResource).Id; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? IncrementalScanStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).IncrementalScanStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).IncrementalScanStartTime = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public int? Interval { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).Interval; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).Interval = value ?? default(int); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).LastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastScheduled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).LastScheduled; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).CreatedAt = value; }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).LastModifiedAt = value; }

        /// <summary>Internal Acessors for LastScheduled</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerInternal.LastScheduled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).LastScheduled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).LastScheduled = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerProperties Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.TriggerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Recurrence</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerRecurrence Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerInternal.Recurrence { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).Recurrence; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).Recurrence = value; }

        /// <summary>Internal Acessors for RecurrenceSchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceSchedule Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerInternal.RecurrenceSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceSchedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceSchedule = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.TriggerProperties()); set => this._property = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecurrenceEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceEndTime = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.TriggerFrequency? RecurrenceFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceFrequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceFrequency = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.TriggerFrequency)""); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string RecurrenceInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceInterval; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceInterval = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecurrenceStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceStartTime = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public string RecurrenceTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceTimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).RecurrenceTimeZone = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType? ScanLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScanLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScanLevel = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType)""); }

        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties ScheduleAdditionalProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleAdditionalProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleAdditionalProperty = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public int[] ScheduleHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleHour = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public int[] ScheduleMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleMinute = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public int[] ScheduleMonthDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleMonthDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleMonthDay = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence[] ScheduleMonthlyOccurrence { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleMonthlyOccurrence; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleMonthlyOccurrence = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek[] ScheduleWeekDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleWeekDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerPropertiesInternal)Property).ScheduleWeekDay = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="Trigger" /> instance.</summary>
        public Trigger()
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
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    public partial interface ITrigger :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"incrementalScanStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? IncrementalScanStartTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"interval",
        PossibleTypes = new [] { typeof(int) })]
        int? Interval { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"lastScheduled",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastScheduled { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecurrenceEndTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"frequency",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.TriggerFrequency) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.TriggerFrequency? RecurrenceFrequency { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recurrenceInterval",
        PossibleTypes = new [] { typeof(string) })]
        string RecurrenceInterval { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecurrenceStartTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string RecurrenceTimeZone { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"scanLevel",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType? ScanLevel { get; set; }
        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dictionary of <any>",
        SerializedName = @"additionalProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties ScheduleAdditionalProperty { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hours",
        PossibleTypes = new [] { typeof(int) })]
        int[] ScheduleHour { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minutes",
        PossibleTypes = new [] { typeof(int) })]
        int[] ScheduleMinute { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"monthDays",
        PossibleTypes = new [] { typeof(int) })]
        int[] ScheduleMonthDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"monthlyOccurrences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence[] ScheduleMonthlyOccurrence { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"weekDays",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek[] ScheduleWeekDay { get; set; }

    }
    internal partial interface ITriggerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal
    {
        global::System.DateTime? CreatedAt { get; set; }

        global::System.DateTime? IncrementalScanStartTime { get; set; }

        int? Interval { get; set; }

        global::System.DateTime? LastModifiedAt { get; set; }

        global::System.DateTime? LastScheduled { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerProperties Property { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ITriggerRecurrence Recurrence { get; set; }

        global::System.DateTime? RecurrenceEndTime { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.TriggerFrequency? RecurrenceFrequency { get; set; }

        string RecurrenceInterval { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceSchedule RecurrenceSchedule { get; set; }

        global::System.DateTime? RecurrenceStartTime { get; set; }

        string RecurrenceTimeZone { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanLevelType? ScanLevel { get; set; }
        /// <summary>Dictionary of <any></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleAdditionalProperties ScheduleAdditionalProperty { get; set; }

        int[] ScheduleHour { get; set; }

        int[] ScheduleMinute { get; set; }

        int[] ScheduleMonthDay { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence[] ScheduleMonthlyOccurrence { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DaysOfWeek[] ScheduleWeekDay { get; set; }

    }
}