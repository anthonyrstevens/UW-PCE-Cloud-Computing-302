$url = "http://www.imdb.com/name/nm0001610/"
$req = [System.Net.WebRequest]::Create($url)
$resp = $req.GetResponse()
$s = $resp.GetResponseStream()
$sr = new-object System.IO.StreamReader($s)
$html = $sr.ReadToEnd()
$html -match "Clueless"