
@echo off

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b)

title C.By ARTHH
:Start
color 0A
cls

echo. 
                                                   
set /p var1= Kullanima acmak istediginiz PORT Numarasini giriniz:

netsh advfirewall firewall add rule name= "Open Port %var1% " dir=in action=allow protocol=TCP localport=%var1%
netsh advfirewall firewall add rule name= "Open Port %var1% " dir=out action=allow protocol=TCP localport=%var1%


