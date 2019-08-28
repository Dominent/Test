Write-Output "Executing build.ps1";

Get-ChildItem -Path "lib\*.dll" -Recurse | Copy-Item -Force

Remove-Item "lib" -Force -Recurse

Write-Output "Finished executing build.ps1";