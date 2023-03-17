

cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 


cd %userprofile%\desktop

taskkill /f /im Infinity.lnk

Infinity.lnk

exit