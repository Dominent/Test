Write-Output "Executing build.ps1";

Get-ChildItem -Path "lib\*.dll" -Recurse | Move-Item

Remove-Item "lib"

Write-Output "Finished executing build.ps1";