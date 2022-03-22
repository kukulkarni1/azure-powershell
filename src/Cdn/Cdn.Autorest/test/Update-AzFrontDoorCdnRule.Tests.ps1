if(($null -eq $TestName) -or ($TestName -contains 'Update-AzFrontDoorCdnRule'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzFrontDoorCdnRule.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Update-AzFrontDoorCdnRule' {
    It 'UpdateExpanded' {
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        try
        {
            Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
            New-AzResourceGroup -Name $ResourceGroupName -Location $env.location
            $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"
            $profileSku = "Standard_AzureFrontDoor";
            New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global
            $rulesetName = 'rs' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use rulesetName : $($rulesetName)"
            New-AzFrontDoorCdnRuleSet -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Name $rulesetName
            $uriConditon = New-AzCdnDeliveryRuleRequestUriConditionObject -Name "RequestUri" -ParameterOperator "Any"
            $conditions = @(
                $uriConditon
            );
            $overrideAction = New-AzCdnDeliveryRuleRouteConfigurationOverrideActionObject -Name "RouteConfigurationOverride" `
            -CacheConfigurationQueryStringCachingBehavior "IgnoreSpecifiedQueryStrings" `
            -CacheConfigurationQueryParameter "a=test" `
            -CacheConfigurationIsCompressionEnabled "Enabled" `
            -CacheConfigurationCacheBehavior "HonorOrigin"
            $actions = @($overrideAction);
            
            $ruleName = 'r' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use ruleName : $($ruleName)"
            New-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName `
            -Action $actions -Condition $conditions

            $rule = Get-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName
            $rule.Name | Should -Be $ruleName
            $rule.Condition.Count | Should -Be $conditions.Count
            $rule.Action.Count | Should -Be $actions.Count

            $updatedConditions = @(
                
            );
            $updatedOverrideAction = New-AzCdnDeliveryRuleRouteConfigurationOverrideActionObject -Name "RouteConfigurationOverride" `
            -CacheConfigurationQueryStringCachingBehavior "IgnoreSpecifiedQueryStrings" `
            -CacheConfigurationQueryParameter "a=test1" `
            -CacheConfigurationIsCompressionEnabled "Enabled" `
            -CacheConfigurationCacheBehavior "HonorOrigin"
            $updatedActions = @($updatedOverrideAction);
            Update-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName `
            -Action $updatedActions -Condition $updatedConditions

            $updatedRule = Get-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName
            $updatedRule.Name | Should -Be $ruleName
            $updatedRule.Condition.Count | Should -Be $updatedConditions.Count
            $updatedRule.Action.Count | Should -Be $actions.Count
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }

    It 'UpdateViaIdentityExpanded' {
        $PSDefaultParameterValues['Disabled'] = $true
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        try
        {
            Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
            New-AzResourceGroup -Name $ResourceGroupName -Location $env.location
            $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"
            $profileSku = "Standard_AzureFrontDoor";
            New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global
            $rulesetName = 'rs' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use rulesetName : $($rulesetName)"
            New-AzFrontDoorCdnRuleSet -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Name $rulesetName
            $uriConditon = New-AzCdnDeliveryRuleRequestUriConditionObject -Name "RequestUri" -ParameterOperator "Any"
            $conditions = @(
                $uriConditon
            );
            $overrideAction = New-AzCdnDeliveryRuleRouteConfigurationOverrideActionObject -Name "RouteConfigurationOverride" `
            -CacheConfigurationQueryStringCachingBehavior "IgnoreSpecifiedQueryStrings" `
            -CacheConfigurationQueryParameter "a=test" `
            -CacheConfigurationIsCompressionEnabled "Enabled" `
            -CacheConfigurationCacheBehavior "HonorOrigin"
            $actions = @($overrideAction);
            
            $ruleName = 'r' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use ruleName : $($ruleName)"
            New-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName `
            -Action $actions -Condition $conditions

            $rule = Get-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName
            $rule.Name | Should -Be $ruleName
            $rule.Condition.Count | Should -Be $conditions.Count
            $rule.Action.Count | Should -Be $actions.Count

            $updatedConditions = @(
                
            );
            $updatedOverrideAction = New-AzCdnDeliveryRuleRouteConfigurationOverrideActionObject -Name "RouteConfigurationOverride" `
            -CacheConfigurationQueryStringCachingBehavior "IgnoreSpecifiedQueryStrings" `
            -CacheConfigurationQueryParameter "a=test1" `
            -CacheConfigurationIsCompressionEnabled "Enabled" `
            -CacheConfigurationCacheBehavior "HonorOrigin"
            $updatedActions = @($updatedOverrideAction);
            Get-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName | Update-AzFrontDoorCdnRule `
            -Action $updatedActions -Condition $updatedConditions

            $updatedRule = Get-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName
            $updatedRule.Name | Should -Be $ruleName
            $updatedRule.Condition.Count | Should -Be $updatedConditions.Count
            $updatedRule.Action.Count | Should -Be $actions.Count
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }
}
