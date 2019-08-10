Write-Output "Executing build.ps1";

$appSettings = Get-Content 'appSettings.json' | Out-String | ConvertFrom-Json;

$tesseractPath = $appSettings.Tesseract.Path;

$tesseractExe = $appSettings.Tesseract.Executable;

$tesseractDLL = $appSettings.Tesseract.TesseractDll;
$liptonicaDLL = $appSettings.Tesseract.LiptonicaDll;

$tesseractDLLPath = Join-Path $tesseractPath $tesseractDLL;
$tesseractExePath = Join-Path $tesseractPath $tesseractExe;
$liptonicaDLLPath = Join-Path $tesseractPath $liptonicaDLL;

Write-Output "Copying $tesseractDLLPath to $tesseractDLL";
Copy-Item -Path $tesseractDLLPath -Destination $tesseractDLL;

Write-Output "Copying $liptonicaDLLPath to $liptonicaDLL";
Copy-Item -Path $liptonicaDLLPath -Destination $liptonicaDLL;

Write-Output "Copying $tesseractExePath to $tesseractExe";
Copy-Item -Path $tesseractExePath -Destination $tesseractExe;

Write-Output "Finished executing build.ps1";