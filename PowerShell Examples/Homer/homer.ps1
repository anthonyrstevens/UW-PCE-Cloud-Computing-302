# homer.ps1
param
(
    [string]$projectPath="..\..\VS 2010 Examples\WindowsAzureProject1\Blobby\",
    [parameter(Mandatory=$true)]
    [string]$logFile
)

function Build()
{
    Write-ToLog "Build started..." $logFile

    # pull from git
    # git pull -v | out-file "c:\temp\git.log" -append -force

    # local project file

    $projectFile = join-path $projectPath "Blobby.csproj"
    
    $results = ""
    
    try
    {
        msbuild $projectFile /t:rebuild /v:minimal | out-file $logFile -append -force
        $results = "Success!  Yay!"
    }
    catch [exception]
    {
        $results = ("FATAL: {0}" -f $_.Exception.ToString())
        Write-ToLog $results $logFile
    }
    
    Write-ToLog "Build complete." $logFile
    
    # send notice of build results to an email
    Send-BuildNotice $results
}

function Send-BuildNotice([string]$results)
{
    # do nothing?
    # TODO
    Write-Warning "Send-BuildNotice is still not implemented!"
}

function Write-ToLog($msg, $path) {
    $fullMessage = ("[{0}]{1}{2}" -f [datetime]::Now.ToString(), [System.Environment]::NewLine, $msg)
    Ensure-LogDirectoryExists $path
    $fullMessage | out-file $path -append -force
}

function Ensure-LogDirectoryExists($path)
{
    $parentDir = $path | split-path -parent
    if (-not (test-path $parentDir)) {
        new-item -itemtype directory -path $parentDir | out-null
    }
}

Build