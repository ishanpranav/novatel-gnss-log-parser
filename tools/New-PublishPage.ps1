[Environment]::CurrentDirectory = $(Get-Location)

$xslCompiledTransform = New-Object System.Xml.Xsl.XslCompiledTransform
$str = ((Get-Content "../docs/publish.html" -Raw).Replace("&nbsp", " "))
$stringReader = [System.IO.StringReader]::new($str)
$streamWriter = (New-Object System.IO.StreamWriter "../docs/index.html")

try {
    $xmlReader = [System.Xml.XmlReader]::Create($stringReader)

    $xslCompiledTransform.Load("publish-page.xsl")
    
    try {
        $xslCompiledTransform.Transform($xmlReader, $streamWriter)   
    }
    finally {
        $xmlReader.Dispose()
    }
}
finally {
    $stringReader.Close()
    $streamWriter.Close()
}
