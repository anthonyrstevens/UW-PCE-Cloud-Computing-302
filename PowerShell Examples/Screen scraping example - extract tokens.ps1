$url = "http://fdd61e7b0302494bbccd7e725d1ed686.cloudapp.net/"
$req = [System.Net.WebRequest]::Create($url)
$resp = $req.GetResponse()
$s = $resp.GetResponseStream()
$sr = new-object System.IO.StreamReader($s)
$html = $sr.ReadToEnd()
$html.Split(@(" ","=","<",">")) |% {
    if (-not ([string]::IsNullOrEmpty($_))) {
        Write-Host($_)
    }
}