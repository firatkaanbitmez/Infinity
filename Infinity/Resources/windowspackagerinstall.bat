
@echo off
color 0A



if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 
cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"

title C.By ARTHH
cls

cd %userprofile%\downloads

curl -L https://github.com/microsoft/winget-cli/releases/latest/download/Microsoft.DesktopAppInstaller_8wekyb3d8bbwe.msixbundle -o winpackageins.msixbundle



powershell -command "Add-AppPackage -path "%userprofile%\downloads\winpackageins.msixbundle""

winget search zoom --accept-source-agreements
winget source reset --force
winget source add -n winget "https://cdn.winget.microsoft.com/cache"
winget source update --accept-source-agreements
winget search vlc --accept-source-agreements

exit