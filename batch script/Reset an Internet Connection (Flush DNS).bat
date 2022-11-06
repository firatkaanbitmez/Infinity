@echo off

cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 


ipconfig /flushdns
ipconfig /registerdns
ipconfig /release
ipconfig /renew
netsh winsock reset


exit
