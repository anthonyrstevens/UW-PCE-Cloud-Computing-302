$url = "http://reputrade.net/test/test1.xml"
$req = [System.Net.WebRequest]::Create($url)
$resp = $req.GetResponse()
$s = $resp.GetResponseStream()
$sr = new-object System.IO.StreamReader($s)
$xml = $sr.ReadToEnd()
$xml