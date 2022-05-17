// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    public partial struct WafGranularity :
        System.IEquatable<WafGranularity>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity P1D = @"P1D";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity Pt1H = @"PT1H";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity Pt5M = @"PT5M";

        /// <summary>the value for an instance of the <see cref="WafGranularity" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WafGranularity</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WafGranularity" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WafGranularity(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WafGranularity</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WafGranularity (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WafGranularity && Equals((WafGranularity)obj);
        }

        /// <summary>Returns hashCode for enum WafGranularity</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WafGranularity</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="WafGranularity"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WafGranularity(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WafGranularity</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WafGranularity" />.</param>

        public static implicit operator WafGranularity(string value)
        {
            return new WafGranularity(value);
        }

        /// <summary>Implicit operator to convert WafGranularity to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WafGranularity" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WafGranularity</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WafGranularity</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.WafGranularity e2)
        {
            return e2.Equals(e1);
        }
    }
}