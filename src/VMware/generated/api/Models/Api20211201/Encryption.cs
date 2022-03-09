// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The properties of customer managed encryption key</summary>
    public partial class Encryption :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionInternal
    {

        /// <summary>Backing field for <see cref="KeyVaultProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultProperties _keyVaultProperty;

        /// <summary>The key vault where the encryption key is stored</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultProperties KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.EncryptionKeyVaultProperties()); set => this._keyVaultProperty = value; }

        /// <summary>The name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyName = value ?? null; }

        /// <summary>The state of key provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? KeyVaultPropertyKeyState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyState; }

        /// <summary>The URL of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyVaultUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyVaultUrl = value ?? null; }

        /// <summary>The version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyVersion = value ?? null; }

        /// <summary>Property of the key if user provided or auto detected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? KeyVaultPropertyVersionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).VersionType; }

        /// <summary>Internal Acessors for KeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionInternal.KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.EncryptionKeyVaultProperties()); set { {_keyVaultProperty = value;} } }

        /// <summary>Internal Acessors for KeyVaultPropertyKeyState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionInternal.KeyVaultPropertyKeyState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).KeyState = value; }

        /// <summary>Internal Acessors for KeyVaultPropertyVersionType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionInternal.KeyVaultPropertyVersionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).VersionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultPropertiesInternal)KeyVaultProperty).VersionType = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionState? _status;

        /// <summary>Status of customer managed encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionState? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="Encryption" /> instance.</summary>
        public Encryption()
        {

        }
    }
    /// The properties of customer managed encryption key
    public partial interface IEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>The name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The state of key provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of key provided",
        SerializedName = @"keyState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? KeyVaultPropertyKeyState { get;  }
        /// <summary>The URL of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL of the vault.",
        SerializedName = @"keyVaultUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVaultUrl { get; set; }
        /// <summary>The version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>Property of the key if user provided or auto detected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Property of the key if user provided or auto detected",
        SerializedName = @"versionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? KeyVaultPropertyVersionType { get;  }
        /// <summary>Status of customer managed encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of customer managed encryption key",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionState? Status { get; set; }

    }
    /// The properties of customer managed encryption key
    internal partial interface IEncryptionInternal

    {
        /// <summary>The key vault where the encryption key is stored</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IEncryptionKeyVaultProperties KeyVaultProperty { get; set; }
        /// <summary>The name of the key.</summary>
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The state of key provided</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionKeyStatus? KeyVaultPropertyKeyState { get; set; }
        /// <summary>The URL of the vault.</summary>
        string KeyVaultPropertyKeyVaultUrl { get; set; }
        /// <summary>The version of the key.</summary>
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>Property of the key if user provided or auto detected</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionVersionType? KeyVaultPropertyVersionType { get; set; }
        /// <summary>Status of customer managed encryption key</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.EncryptionState? Status { get; set; }

    }
}