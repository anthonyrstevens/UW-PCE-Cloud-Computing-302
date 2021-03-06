#$path = "C:\Users\Anthony\Documents\UW PCE\Cloud 302 Winter 2012\Homework for Week 7.txt"
#$path = "C:\Users\Anthony\Documents\UW PCE\Cloud 302 Winter 2012\perf1.txt"
#$path = "C:\Users\Anthony\Documents\UW PCE\Cloud 302 Winter 2012\perf2.txt"
#$path = "C:\Users\Anthony\Documents\UW PCE\Cloud 302 Winter 2012\perf3.txt"
$path = "C:\Users\Anthony\Documents\UW PCE\Cloud 302 Winter 2012\perf4.txt"
$content = get-content $path
$start = [System.DateTime]::Now
$index = 0

@(1..10) | % {
    $newFile = [System.Guid]::NewGuid().ToString() + ".txt"
    $fullNewFilePath = Join-Path "c:\temp\c302perf1" $newFile
    $content | out-file -FilePath $fullNewFilePath
    
    $index = $index + 1
    if (($index % 100) -eq 0)
    {
        $end = [System.DateTime]::Now
        $elapsed = $end - $start
    }
}
$end =[System.DateTime]::Now
$elapsed = $end - $start
Write-Host $elapsed.TotalMilliseconds
$average = [double]$elapsed.TotalMilliseconds / [double]$index
Write-Host "Average time per single loop iteration: $($average)"