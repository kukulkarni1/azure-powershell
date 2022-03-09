// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support
{

    /// <summary>The OS type.</summary>
    public partial struct OperatingSystemTypes :
        System.IEquatable<OperatingSystemTypes>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes Linux = @"Linux";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes Unknown = @"Unknown";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes Windows = @"Windows";

        /// <summary>the value for an instance of the <see cref="OperatingSystemTypes" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OperatingSystemTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperatingSystemTypes" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OperatingSystemTypes(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OperatingSystemTypes</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OperatingSystemTypes (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OperatingSystemTypes && Equals((OperatingSystemTypes)obj);
        }

        /// <summary>Returns hashCode for enum OperatingSystemTypes</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OperatingSystemTypes" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OperatingSystemTypes(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OperatingSystemTypes</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OperatingSystemTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperatingSystemTypes" />.</param>

        public static implicit operator OperatingSystemTypes(string value)
        {
            return new OperatingSystemTypes(value);
        }

        /// <summary>Implicit operator to convert OperatingSystemTypes to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OperatingSystemTypes" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OperatingSystemTypes</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OperatingSystemTypes</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes e2)
        {
            return e2.Equals(e1);
        }
    }
}