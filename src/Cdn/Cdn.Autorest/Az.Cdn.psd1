@{
  GUID = 'f9fae843-9c26-4513-9442-17f4379802bf'
  RootModule = './Az.Cdn.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Cdn cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Cdn.private.dll'
  FormatsToProcess = './Az.Cdn.format.ps1xml'
  FunctionsToExport = 'Clear-AzCdnEndpointContent', 'Clear-AzFrontDoorCdnEndpointContent', 'Disable-AzCdnCustomDomainCustomHttps', 'Enable-AzCdnCustomDomainCustomHttps', 'Get-AzCdnCustomDomain', 'Get-AzCdnEdgeNode', 'Get-AzCdnEndpoint', 'Get-AzCdnEndpointResourceUsage', 'Get-AzCdnManagedRuleSet', 'Get-AzCdnOrigin', 'Get-AzCdnOriginGroup', 'Get-AzCdnPolicy', 'Get-AzCdnProfile', 'Get-AzCdnProfileResourceUsage', 'Get-AzCdnProfileSupportedOptimizationType', 'Get-AzCdnResourceUsage', 'Get-AzFrontDoorCdnCustomDomain', 'Get-AzFrontDoorCdnEndpoint', 'Get-AzFrontDoorCdnEndpointResourceUsage', 'Get-AzFrontDoorCdnOrigin', 'Get-AzFrontDoorCdnOriginGroup', 'Get-AzFrontDoorCdnOriginGroupResourceUsage', 'Get-AzFrontDoorCdnProfile', 'Get-AzFrontDoorCdnProfileResourceUsage', 'Get-AzFrontDoorCdnRoute', 'Get-AzFrontDoorCdnRule', 'Get-AzFrontDoorCdnRuleSet', 'Get-AzFrontDoorCdnRuleSetResourceUsage', 'Get-AzFrontDoorCdnSecret', 'Get-AzFrontDoorCdnSecurityPolicy', 'Import-AzCdnEndpointContent', 'Invoke-AzCdnSecretValidate', 'New-AzCdnAzureFirstPartyManagedCertificateParametersObject', 'New-AzCdnCustomDomain', 'New-AzCdnCustomerCertificateParametersObject', 'New-AzCdnDeliveryRuleCacheExpirationActionObject', 'New-AzCdnDeliveryRuleCacheKeyQueryStringActionObject', 'New-AzCdnDeliveryRuleClientPortConditionObject', 'New-AzCdnDeliveryRuleCookiesConditionObject', 'New-AzCdnDeliveryRuleHostNameConditionObject', 'New-AzCdnDeliveryRuleHttpVersionConditionObject', 'New-AzCdnDeliveryRuleIsDeviceConditionObject', 'New-AzCdnDeliveryRulePostArgsConditionObject', 'New-AzCdnDeliveryRuleQueryStringConditionObject', 'New-AzCdnDeliveryRuleRemoteAddressConditionObject', 'New-AzCdnDeliveryRuleRequestBodyConditionObject', 'New-AzCdnDeliveryRuleRequestHeaderActionObject', 'New-AzCdnDeliveryRuleRequestHeaderConditionObject', 'New-AzCdnDeliveryRuleRequestMethodConditionObject', 'New-AzCdnDeliveryRuleRequestSchemeConditionObject', 'New-AzCdnDeliveryRuleRequestUriConditionObject', 'New-AzCdnDeliveryRuleResponseHeaderActionObject', 'New-AzCdnDeliveryRuleRouteConfigurationOverrideActionObject', 'New-AzCdnDeliveryRuleServerPortConditionObject', 'New-AzCdnDeliveryRuleSocketAddrConditionObject', 'New-AzCdnDeliveryRuleSslProtocolConditionObject', 'New-AzCdnDeliveryRuleUrlFileExtensionConditionObject', 'New-AzCdnDeliveryRuleUrlFileNameConditionObject', 'New-AzCdnDeliveryRuleUrlPathConditionObject', 'New-AzCdnEndpoint', 'New-AzCdnManagedCertificateParametersObject', 'New-AzCdnOrigin', 'New-AzCdnOriginGroup', 'New-AzCdnOriginGroupOverrideActionObject', 'New-AzCdnPolicy', 'New-AzCdnProfile', 'New-AzCdnProfileSsoUri', 'New-AzCdnSecurityPolicyWebApplicationFirewallAssociationObject', 'New-AzCdnSecurityPolicyWebApplicationFirewallParametersObject', 'New-AzCdnUrlRedirectActionObject', 'New-AzCdnUrlRewriteActionObject', 'New-AzCdnUrlSigningActionObject', 'New-AzCdnUrlSigningKeyParametersObject', 'New-AzFrontDoorCdnCustomDomain', 'New-AzFrontDoorCdnEndpoint', 'New-AzFrontDoorCdnOrigin', 'New-AzFrontDoorCdnOriginGroup', 'New-AzFrontDoorCdnProfile', 'New-AzFrontDoorCdnRoute', 'New-AzFrontDoorCdnRule', 'New-AzFrontDoorCdnRuleSet', 'New-AzFrontDoorCdnSecret', 'New-AzFrontDoorCdnSecurityPolicy', 'Remove-AzCdnCustomDomain', 'Remove-AzCdnEndpoint', 'Remove-AzCdnOrigin', 'Remove-AzCdnOriginGroup', 'Remove-AzCdnPolicy', 'Remove-AzCdnProfile', 'Remove-AzFrontDoorCdnCustomDomain', 'Remove-AzFrontDoorCdnEndpoint', 'Remove-AzFrontDoorCdnOrigin', 'Remove-AzFrontDoorCdnOriginGroup', 'Remove-AzFrontDoorCdnProfile', 'Remove-AzFrontDoorCdnRoute', 'Remove-AzFrontDoorCdnRule', 'Remove-AzFrontDoorCdnRuleSet', 'Remove-AzFrontDoorCdnSecret', 'Remove-AzFrontDoorCdnSecurityPolicy', 'Start-AzCdnEndpoint', 'Stop-AzCdnEndpoint', 'Test-AzCdnEndpointCustomDomain', 'Test-AzCdnNameAvailability', 'Test-AzCdnProbe', 'Test-AzFrontDoorCdnEndpointCustomDomain', 'Test-AzFrontDoorCdnEndpointNameAvailability', 'Test-AzFrontDoorCdnProfileHostNameAvailability', 'Update-AzCdnEndpoint', 'Update-AzCdnOrigin', 'Update-AzCdnOriginGroup', 'Update-AzCdnPolicy', 'Update-AzCdnProfile', 'Update-AzFrontDoorCdnCustomDomain', 'Update-AzFrontDoorCdnCustomDomainValidationToken', 'Update-AzFrontDoorCdnEndpoint', 'Update-AzFrontDoorCdnOrigin', 'Update-AzFrontDoorCdnOriginGroup', 'Update-AzFrontDoorCdnProfile', 'Update-AzFrontDoorCdnRoute', 'Update-AzFrontDoorCdnRule', 'Update-AzFrontDoorCdnSecurityPolicy', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Cdn'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
