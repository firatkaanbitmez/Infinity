@echo off
tittle C.By ARTHH
color 0A
if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 
cls
echo.                                                     
echo                         SHUTDOWN TIMER
echo.
echo.
echo.
set /p var1= Enter time in minutes  and press enter : 
set /a var2=%var1% * 60
echo.
shutdown -s -f -t %var2%
echo ----------------------------------------------------
echo           Your device will shutdown in %var1% min
echo ----------------------------------------------------
pause
exit
