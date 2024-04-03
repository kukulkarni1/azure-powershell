if(($null -eq $TestName) -or ($TestName -contains 'Update-AzNetworkFunctionCollectorPolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzNetworkFunctionCollectorPolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Update-AzNetworkFunctionCollectorPolicy' {
    It 'UpdateExpandedThrow' -skip {
        { 
            $config = Update-AzNetworkFunctionCollectorPolicy -collectorpolicyname $env.collectorPolicyName -azuretrafficcollectorname $env.azureTrafficCollectorName -resourcegroupname $env.resourceGroup -location $env.location -IngestionPolicyIngestionSource @{ResourceId = $env.ResourceIdLessThan1G} -IngestionPolicyIngestionType $env.IngestionType
            $config | Should -Be $null
        } | Should -Throw
    }

    It 'UpdateExpanded' -skip {
        { 
            $config = Update-AzNetworkFunctionCollectorPolicy -collectorpolicyname $env.collectorPolicyName -azuretrafficcollectorname $env.azureTrafficCollectorName -resourcegroupname $env.resourceGroup -location $env.location -IngestionPolicyIngestionSource @{ResourceId = $env.ResourceId1G} -IngestionPolicyIngestionType $env.IngestionType
            $config.Name | Should -Be $env.collectorPolicyName
        } | Should -Not -Throw
    }
}
