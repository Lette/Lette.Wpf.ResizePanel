$ErrorActionPreference = 'Stop'

Push-Location .\Lette.Wpf.ResizePanel

$Env:CURRENT_COMMIT = git rev-parse --verify HEAD
dotnet pack -c Release -o .

Pop-Location
