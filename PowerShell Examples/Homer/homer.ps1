# homer.ps1
param([string]$projectPath="C:\Users\Anthony\Documents\UW PCE\github\UW-PCE-Cloud-Computing-302\VS 2010 Examples\WindowsAzureProject1\Blobby\")

$projectFile = join-path $projectPath "Blobby.csproj"

msbuild $projectFile /t:rebuild /v:normal