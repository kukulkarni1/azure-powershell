// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Extensions;

    /// <summary>
    /// The Azure Active Directory principal identifier and Azure built-in role that describes the access the principal will receive
    /// on the delegated resource in the managed tenant.
    /// </summary>
    public partial class Authorization :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorizationInternal
    {

        /// <summary>Backing field for <see cref="DelegatedRoleDefinitionId" /> property.</summary>
        private string[] _delegatedRoleDefinitionId;

        /// <summary>
        /// The delegatedRoleDefinitionIds field is required when the roleDefinitionId refers to the User Access Administrator Role.
        /// It is the list of role definition ids which define all the permissions that the user in the authorization can assign to
        /// other principals.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string[] DelegatedRoleDefinitionId { get => this._delegatedRoleDefinitionId; set => this._delegatedRoleDefinitionId = value; }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The identifier of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="PrincipalIdDisplayName" /> property.</summary>
        private string _principalIdDisplayName;

        /// <summary>The display name of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string PrincipalIdDisplayName { get => this._principalIdDisplayName; set => this._principalIdDisplayName = value; }

        /// <summary>Backing field for <see cref="RoleDefinitionId" /> property.</summary>
        private string _roleDefinitionId;

        /// <summary>
        /// The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will
        /// have on the projected scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string RoleDefinitionId { get => this._roleDefinitionId; set => this._roleDefinitionId = value; }

        /// <summary>Creates an new <see cref="Authorization" /> instance.</summary>
        public Authorization()
        {

        }
    }
    /// The Azure Active Directory principal identifier and Azure built-in role that describes the access the principal will receive
    /// on the delegated resource in the managed tenant.
    public partial interface IAuthorization :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The delegatedRoleDefinitionIds field is required when the roleDefinitionId refers to the User Access Administrator Role.
        /// It is the list of role definition ids which define all the permissions that the user in the authorization can assign to
        /// other principals.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The delegatedRoleDefinitionIds field is required when the roleDefinitionId refers to the User Access Administrator Role. It is the list of role definition ids which define all the permissions that the user in the authorization can assign to other principals.",
        SerializedName = @"delegatedRoleDefinitionIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] DelegatedRoleDefinitionId { get; set; }
        /// <summary>The identifier of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The identifier of the Azure Active Directory principal.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>The display name of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the Azure Active Directory principal.",
        SerializedName = @"principalIdDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalIdDisplayName { get; set; }
        /// <summary>
        /// The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will
        /// have on the projected scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope.",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }

    }
    /// The Azure Active Directory principal identifier and Azure built-in role that describes the access the principal will receive
    /// on the delegated resource in the managed tenant.
    internal partial interface IAuthorizationInternal

    {
        /// <summary>
        /// The delegatedRoleDefinitionIds field is required when the roleDefinitionId refers to the User Access Administrator Role.
        /// It is the list of role definition ids which define all the permissions that the user in the authorization can assign to
        /// other principals.
        /// </summary>
        string[] DelegatedRoleDefinitionId { get; set; }
        /// <summary>The identifier of the Azure Active Directory principal.</summary>
        string PrincipalId { get; set; }
        /// <summary>The display name of the Azure Active Directory principal.</summary>
        string PrincipalIdDisplayName { get; set; }
        /// <summary>
        /// The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will
        /// have on the projected scope.
        /// </summary>
        string RoleDefinitionId { get; set; }

    }
}