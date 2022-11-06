@echo off

cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 

rd /s /q %prefetch%
mkdir %prefetch%
rd /s /q c:\windows\prefetch\
mkdir c:\windows\prefetch\


rd /s /q %temp%
mkdir %temp%
rd /s /q c:\windows\temp\
mkdir c:\windows\temp\

del /f /s /q %windir%\prefetch\*.* rd /s /q %windir%\temp & md %windir%\temp 



del /s /f /q %windir%\temp*.*
rd /s /q %windir%\temp
md %windir%\temp
del /s /f /q %windir%\Prefetch*.*
rd /s /q %windir%\Prefetch
md %windir%\Prefetch

del /s /f /q %windir%\system32\dllcache*.*
rd /s /q %windir%\system32\dllcache
md %windir%\system32\dllcache
del /s /f /q “%SystemDrive%\Temp”*.*
rd /s /q “%SystemDrive%\Temp”
md “%SystemDrive%\Temp”
del /s /f /q %temp%*.*
rd /s /q %temp%
md %temp%


exit
