
@echo off
title C.By.ARTHHH
color 0A
cls

cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 




net stop w32time

w32tm /unregister

w32tm /register

net start w32time

w32tm /resync



exit