// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class RecurrenceScheduleOccurrence :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrence,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrenceInternal
    {

        /// <summary>Backing field for <see cref="AdditionalProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrenceAdditionalProperties _additionalProperty;

        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrenceAdditionalProperties AdditionalProperty { get => (this._additionalProperty = this._additionalProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.RecurrenceScheduleOccurrenceAdditionalProperties()); set => this._additionalProperty = value; }

        /// <summary>Backing field for <see cref="Day" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DayOfWeek? _day;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DayOfWeek? Day { get => this._day; set => this._day = value; }

        /// <summary>Backing field for <see cref="Occurrence" /> property.</summary>
        private int? _occurrence;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public int? Occurrence { get => this._occurrence; set => this._occurrence = value; }

        /// <summary>Creates an new <see cref="RecurrenceScheduleOccurrence" /> instance.</summary>
        public RecurrenceScheduleOccurrence()
        {

        }
    }
    public partial interface IRecurrenceScheduleOccurrence :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable
    {
        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dictionary of <any>",
        SerializedName = @"additionalProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrenceAdditionalProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrenceAdditionalProperties AdditionalProperty { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"day",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DayOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DayOfWeek? Day { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"occurrence",
        PossibleTypes = new [] { typeof(int) })]
        int? Occurrence { get; set; }

    }
    internal partial interface IRecurrenceScheduleOccurrenceInternal

    {
        /// <summary>Dictionary of <any></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IRecurrenceScheduleOccurrenceAdditionalProperties AdditionalProperty { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DayOfWeek? Day { get; set; }

        int? Occurrence { get; set; }

    }
}