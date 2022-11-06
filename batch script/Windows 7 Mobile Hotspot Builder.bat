@echo off


if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 

color 0A
cls
echo Please Always run as Administrator. 
echo Please enter a password and network name of at least 8 characters and at most 64 characters. 

set /p hostname= "Please Enter the Network Name:"

set /p password="Please Enter the Network Password:"
netsh wlan set hostednetwork mode=allow ssid=%hostname% key=%password%

netsh wlan start hostednetwork

echo netsh wlan start hostednetwork >>%userprofile%\desktop\hotspot.bat
pause
exit


