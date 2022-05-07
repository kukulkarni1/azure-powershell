// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support
{

    /// <summary>
    /// Specifies how the LCM(Local Configuration Manager) actually applies the configuration to the target nodes. Possible values
    /// are ApplyOnly, ApplyAndMonitor, and ApplyAndAutoCorrect.
    /// </summary>
    public partial struct ConfigurationMode :
        System.IEquatable<ConfigurationMode>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode ApplyAndAutoCorrect = @"ApplyAndAutoCorrect";

        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode ApplyAndMonitor = @"ApplyAndMonitor";

        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode ApplyOnly = @"ApplyOnly";

        /// <summary>the value for an instance of the <see cref="ConfigurationMode" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ConfigurationMode" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ConfigurationMode(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ConfigurationMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConfigurationMode" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ConfigurationMode(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ConfigurationMode</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ConfigurationMode (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ConfigurationMode && Equals((ConfigurationMode)obj);
        }

        /// <summary>Returns hashCode for enum ConfigurationMode</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ConfigurationMode</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ConfigurationMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConfigurationMode" />.</param>

        public static implicit operator ConfigurationMode(string value)
        {
            return new ConfigurationMode(value);
        }

        /// <summary>Implicit operator to convert ConfigurationMode to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ConfigurationMode" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ConfigurationMode</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode e1, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ConfigurationMode</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode e1, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Support.ConfigurationMode e2)
        {
            return e2.Equals(e1);
        }
    }
}