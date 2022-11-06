@echo off

cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 

rd /s /q %temp%
mkdir %temp%
rd /s /q c:\windows\temp\
mkdir c:\windows\temp\



RD /S /Q %SystemDrive%\windows.old

rd /s /q %prefetch%
mkdir %prefetch%
rd /s /q c:\windows\prefetch\
mkdir c:\windows\prefetch\


rd /s /q %SYSTEMDRIVE%\$Recycle.bin

powershell.exe -command "cleanmgr /sagerun:1 | out-Null"


exit
