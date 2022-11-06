
@echo off

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b)


@echo off
title C.By ARTHH
:Start
color 0A
cls
echo (1) Temporary Files Cleaning
echo (2) Downloader
echo (3) Post-FORMAT Settings
echo (4) File Organizer
echo (5) Windows 10 Pro Build cfg File
echo (6) Speed Test With Python
echo (7) Ip Adress 
echo (8) Shutdown Timer
echo (9) Temporary Files Cleaning
echo (10) Play MetroFM with Vlc
echo (11) Windows Desktop Shortcut Added
echo (12) Windows Defender ON 
echo (13) Windows Defender OFF
echo (14) Windows Classic Photo Reg. Added Desktop
echo (15) System Info.tmp Saves Desktop
echo (16) Dxdiag Info.txt Saves Desktop
echo (17) Tmp to Txt Files Converter
echo (18) Txt Merger 
echo (19) firat image ASCII
echo (20) Hotspot Builder for Windows 7
echo (21) 
echo (22) 
echo (23) 
echo (24) Yuklu Programlar Save Desktop
echo (25) 
echo (0) Exit
echo.


set /p choice= "Please Select one of the above options :" 

if %choice% EQU 1 goto 1
if %choice% EQU 2 goto 2
if %choice% EQU 3 goto 3
if %choice% EQU 4 goto 4
if %choice% EQU 5 goto 5
if %choice% EQU 6 goto 6
if %choice% EQU 7 goto 7
if %choice% EQU 8 goto 8
if %choice% EQU 9 goto 9
if %choice% EQU 10 goto 10
if %choice% EQU 11 goto 11
if %choice% EQU 12 goto 12
if %choice% EQU 13 goto 13
if %choice% EQU 14 goto 14
if %choice% EQU 15 goto 15
if %choice% EQU 16 goto 16
if %choice% EQU 17 goto 17
if %choice% EQU 18 goto 18
if %choice% EQU 19 goto 19
if %choice% EQU 20 goto 20
if %choice% EQU 21 goto 21
if %choice% EQU 22 goto 22
if %choice% EQU 23 goto 23
if %choice% EQU 24 goto 24
if %choice% EQU 25 goto 25
if %choice% EQU 26 goto 26
if %choice% EQU 0 goto end
goto loop


:1
@echo off

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

pause 
exit


:2
@echo off
color 0A

title C.By ARTHH
cls
cd %userprofile%\desktop
echo.
echo 1.  Python
echo 2.  Vlc Player
echo 3.  Discord
echo 4.  Opera GX
echo 5.  CodeBlocks				LUTFEN INDIRMEK ISTEDIGINIZ UYGULAMALARI 
echo 6.  Usko Downloader			ARALARINDA VIRGUL ILE YAZINIZ	
echo 7.  Crossfire Downloader		ORNEK: 1,2,4,20 
echo 8.  Steam				HEPSINI INDIRMEK ICIN 28 YAZIP ENTERLAYINIZ...
echo 9.  PaintNet				
echo 10. OBS					
echo 11. Winrar 64Bit
echo 12. WireShark
echo 13. Rufus
echo 14. SteelSeries GG
echo 15. LogitechSoftware
echo 16. Samsung Ml1610 driver
echo 17. Ubuntu
echo 18. IDM
echo 19. Movavi Video Studio
echo 20. HdTune
echo 21. Minitool Wizard
echo 22. BatExe Converter
echo 23. Exe Icon Changer
echo 24. Tp-Link UE200 Driver
echo 25. Win-PS2EXE
echo 26. Google Drive Client
echo 27. Post-Format 
echo 28. Include All
echo.

:getOptions
set "choices="
set /p "choices=Lutfen Tuslama yapiniz...: "
cls
echo Rar Password of Downloaded Programs (www.warezturkey.net)
echo Rar Password of Downloaded Programs (www.warezturkey.net) >>RarPassword.txt
if not defined choices ( 
    echo Please enter a valid option
    goto getOptions
    )

for %%a in (%choices%) do if %%a EQU 28 set choices=1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27
for %%i in (%choices%) do call :option-%%i

pause
exit

:option-1
curl https://www.python.org/ftp/python/3.9.6/python-3.9.6-amd64.exe -o python.exe
exit /B

:option-2
curl https://mirror.yandex.ru/mirrors/ftp.videolan.org/vlc/3.0.16/win64/vlc-3.0.16-win64.exe -o vlc.exe
exit /B

:option-3
curl https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9002/DiscordSetup.exe -o discord.exe
exit /B

:option-4
curl https://get.opera.com/ftp/pub/opera_gx/78.0.4093.153/win/Opera_GX_78.0.4093.153_Setup_x64.exe -o operagx.exe
exit /B

:option-5
curl https://nav.dl.sourceforge.net/project/codeblocks/Binaries/20.03/Windows/codeblocks-20.03mingw-setup.exe -o codeblocks.exe
exit /B

:option-6
curl https://patch.nttgame.com/knight/downloader/KnightOnline-DLM.exe?today=19082021 -o uskodownload.exe
exit /B

:option-7
curl https://cfpatch.z8games.com/download/CrossFireWest.exe -o CFdownload.exe
exit /B

:option-8
curl https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe -o steam.exe
exit /B

:option-9
curl https://www.dotpdn.com/files/paint.net.4.2.16.install.zip -o paintnet.zip
exit /B

:option-10
curl https://cdn-fastly.obsproject.com/downloads/OBS-Studio-27.0.1-Full-Installer-x64.exe -o obs.exe
exit /B
:option-11
curl https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-602tr.exe -o winrar64bit.exe
exit /B

:option-12
curl https://1.eu.dl.wireshark.org/win64/Wireshark-win64-3.2.15.exe -o wireshark.exe
exit /B

:option-13
timeout 1
start https://rufus.ie/tr/
exit /B

:option-14
curl https://engine.steelseriescdn.com/SteelSeriesGG7.0.0Setup.exe -o steelseriesengine.exe
exit /B

:option-15
curl https://download01.logi.com/web/ftp/pub/techsupport/gaming/LGS_9.02.65_x64_Logitech.exe -o logitechg300s.exe
exit /B

:option-16
curl https://ftp.ext.hp.com/pub/softlib/software13/printers/SS/SL-M3370FD/SamsungUniversalPrintDriver3.exe -o samsungml1610.exe
exit /B

:option-17
curl https://ftp.linux.org.tr/ubuntu-releases/21.04/ubuntu-21.04-desktop-amd64.iso -o ubuntu_21_04.iso
exit /B

:option-18
timeout 1
start https://www75.zippyshare.com/d/VhpXp33J/1489/IDMv6.39B2.WT.rar 
exit /B

:option-19
timeout 1
start https://www61.zippyshare.com/d/G9gSJTdE/22566/VideoSuite.21.3.0-64.WT.rar
exit /B

:option-20
timeout 1
start https://www44.zippyshare.com/d/WU9iWLN4/2680/HD.5.75.WT.rar
exit /B
:option-21
timeout 1
start https://www105.zippyshare.com/d/9fw9imeY/29455/PrttnWzrd.12.5.WT.rar
exit /B

:option-22
timeout 1
start https://bat-to-exe-converter-x64.en.softonic.com
exit /B

:option-23
timeout 1
start https://www.softpedia.com/get/Desktop-Enhancements/Icons-Related/SVERDYSH-Icon-Changer.shtml
exit /B

:option-24
curl https://rtitwww.realtek.com/rtdrivers/cn/nic1/Install_USB_Win10_10045.20_06222021.zip -o ue200driver.zip
exit /B

:option-25
timeout 1
start https://github.com/MScholtes/Win-PS2EXE
exit /B

:option-26
timeout 1
start https://www.google.com/drive/download/
exit /B

:option-27
curl https://www.python.org/ftp/python/3.9.6/python-3.9.6-amd64.exe -o python.exe
curl https://mirror.yandex.ru/mirrors/ftp.videolan.org/vlc/3.0.16/win64/vlc-3.0.16-win64.exe -o vlc.exe
curl https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9002/DiscordSetup.exe -o discord.exe
curl https://get.opera.com/ftp/pub/opera_gx/78.0.4093.153/win/Opera_GX_78.0.4093.153_Setup_x64.exe -o operagx.exe
curl https://nav.dl.sourceforge.net/project/codeblocks/Binaries/20.03/Windows/codeblocks-20.03mingw-setup.exe -o codeblocks.exe
curl https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe -o steam.exe
curl https://cdn-fastly.obsproject.com/downloads/OBS-Studio-27.0.1-Full-Installer-x64.exe -o obs.exe
curl https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-602tr.exe -o winrar64bit.exe
curl https://1.eu.dl.wireshark.org/win64/Wireshark-win64-3.2.15.exe -o wireshark.exe
curl https://engine.steelseriescdn.com/SteelSeriesGG7.0.0Setup.exe -o steelseriesengine.exe
curl https://ftp.ext.hp.com/pub/softlib/software13/printers/SS/SL-M3370FD/SamsungUniversalPrintDriver3.exe -o samsungml1610.exe
curl https://ftp.linux.org.tr/ubuntu-releases/21.04/ubuntu-21.04-desktop-amd64.iso -o ubuntu_21_04.iso
curl https://download01.logi.com/web/ftp/pub/techsupport/gaming/LGS_9.02.65_x64_Logitech.exe -o logitechg300s.exe
curl https://www.dotpdn.com/files/paint.net.4.2.16.install.zip -o paintnet.zip
curl https://patch.nttgame.com/knight/downloader/KnightOnline-DLM.exe?today=19082021 -o uskodownload.exe
curl https://cfpatch.z8games.com/download/CrossFireWest.exe -o CFdownload.exe
curl https://rtitwww.realtek.com/rtdrivers/cn/nic1/Install_USB_Win10_10045.20_06222021.zip -o ue200driver.zip


python.exe /S /V"/qn"
vlc.exe /S /V"/qn"
discord.exe /S /V"/qn"
operagx.exe  /silent /allusers=1 /launchopera=0 /setdefaultbrowser=0
codeblocks.exe /S /V"/qn"
steam.exe /S /V"/qn"
obs.exe /S /V"/qn"
winrar64bit.exe /S /V"/qn"
wireshark.exe /S /V"/qn"
samsungml1610.exe /S /V"/qn"

mkdir Silencesetup
move python.exe Silencesetup
move vlc.exe Silencesetup
move discord.exe Silencesetup
move operagx.exe Silencesetup
move codeblocks.exe Silencesetup
move steam.exe Silencesetup
move obs.exe Silencesetup
move winrar64bit.exe Silencesetup
move wireshark.exe Silencesetup
move samsungml1610.exe Silencesetup

mkdir Kurulacak

move ubuntu_21_04.iso Kurulacak
move logitechg300s.exe Kurulacak
move paintnet.zip Kurulacak
move uskodownload.exe Kurulacak
move CFdownload.exe Kurulacak
move ue200driver.zip Kurulacak
move steelseriesengine.exe Kurulacak


echo start https://www75.zippyshare.com/d/VhpXp33J/1489/IDMv6.39B2.WT.rar >>links.bat
echo timeout 1 >>links.bat
echo start https://www61.zippyshare.com/d/G9gSJTdE/22566/VideoSuite.21.3.0-64.WT.rar >>links.bat

echo timeout 1 >>links.bat
echo start https://www44.zippyshare.com/d/WU9iWLN4/2680/HD.5.75.WT.rar >>links.bat

echo timeout 1 >>links.bat
echo start https://www105.zippyshare.com/d/9fw9imeY/29455/PrttnWzrd.12.5.WT.rar >>links.bat

echo timeout 1 >>links.bat
echo start https://bat-to-exe-converter-x64.en.softonic.com >>links.bat

echo timeout 1 >>links.bat
echo start https://www.softpedia.com/get/Desktop-Enhancements/Icons-Related/SVERDYSH-Icon-Changer.shtml >>links.bat

echo timeout 1 >>links.bat
echo start https://github.com/MScholtes/Win-PS2EXE >>links.bat

echo timeout 1 >>links.bat
echo start https://www.google.com/drive/download/ >>links.bat
echo timeout 1 >>links.bat
echo start https://rufus.ie/tr/ >>links.bat
echo timeout 1 >>links.bat
echo start https://myaccount.microsoft.com/?ref=MeControl >>links.bat

exit /B



:3
@echo off
color 0a
reg add "HKEY_CURRENT_USER\Control Panel\Desktop" /v WallPaper /t REG_SZ /d " " /f

reg add "HKEY_CURRENT_USER\Control Panel\Colors" /v Background /t REG_SZ /d "0 0 0" /f

Reg.exe add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection" /v "DisableRealtimeMonitoring" /t REG_DWORD /d "1" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{645FF040-5081-101B-9F08-00AA002F954E}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{645FF040-5081-101B-9F08-00AA002F954E}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{59031a47-3f72-44a7-89c5-5595fe6b30ee}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{59031a47-3f72-44a7-89c5-5595fe6b30ee}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /t REG_DWORD /d "0" /f

powershell.exe -command "Get-AppxPackage Microsoft.WindowsFeedbackHub| Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.Getstarted | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage *officehub* | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage *skypeapp* | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage *solitairecollection* | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage *onenote* | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage *bingweather* | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage *Skype* | Remove-AppxPackage" 
powershell.exe -command "Get-AppxPackage *Spotify* | Remove-AppxPackage"    
powershell.exe -command "Get-AppxPackage Microsoft.MicrosoftStickyNotes | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.MixedReality.Portal | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.XboxApp | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage *xboxapp* | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.Xbox.TCUI | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.Xbox.TCUI | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.XboxGameOverlay | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.XboxGamingOverlay | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.XboxIdentityProvider | Remove-AppxPackage"
powershell.exe -command "Get-AppxPackage Microsoft.XboxSpeechToTextOverlay | Remove-AppxPackage"

DISM /online /disable-feature /featurename:Internet-Explorer-Optional-amd64 /Norestart
DISM /online /enable-feature /featurename:LegacyComponents /Norestart
DISM /online /enable-feature /featurename:DirectPlay /Norestart
DISM /online /enable-feature /featurename:NetFx3 /Norestart
DISM /online /enable-feature /featurename:WCF-HTTP-Activation /Norestart
DISM /online /enable-feature /featurename:WCF-NonHTTP-Activation /Norestart
DISM /online /enable-feature /featurename:IIS-WebServerRole /Norestart
DISM /online /enable-feature /featurename:IIS-WebServer /Norestart
DISM /online /enable-feature /featurename:IIS-ApplicationDevelopment /Norestart
DISM /online /enable-feature /featurename:IIS-Security /Norestart
DISM /online /enable-feature /featurename:IIS-RequestFiltering /Norestart
DISM /online /enable-feature /featurename:IIS-NetFxExtensibility /Norestart
DISM /online /enable-feature /featurename:WAS-WindowsActivationService /Norestart
DISM /online /enable-feature /featurename:WAS-ProcessModel /Norestart
DISM /online /enable-feature /featurename:WAS-NetFxEnvironment /Norestart
DISM /online /enable-feature /featurename:WAS-ConfigurationAPI /Norestart
DISM /online /enable-feature /featurename:NetFx4Extended-ASPNET45 /Norestart
DISM /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /Norestart
DISM /online /enable-feature /featurename:VirtualMachinePlatform /Norestart
DISM /online /disable-feature /featurename:Windows-Defender-Default-Definitions /Norestart



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

pause

shutdown /r


exit




:4
@echo off
color 0A
title C.By ARTHH
cls

rem For each file in your folder
for %%a in (".\*") do (
rem check if the file has an extension and if it is not our script
if "%%~xa" NEQ "" if "%%~dpxa" NEQ "%~dpx0" (
rem check if extension folder exists, if not it is created
if not exist "%%~xa" mkdir "%%~xa"
rem Move the file to directory
move "%%a" "%%~dpa%%~xa\"
))

pause
exit

:5
@echo off
color 0A
cd %userprofile%\desktop
mkdir Dosyayi_Sources_icine_at

echo [Channel] >>Dosyayi_Sources_icine_at\ei.cfg
echo Retail >>Dosyayi_Sources_icine_at\ei.cfg
pause
exit


:6
curl -s https://raw.githubusercontent.com/sivel/speedtest-cli/master/speedtest.py | python -
echo.
pause 
exit 
:7
ipconfig
pause
exit

:8
@echo off
tittle C.By ARTHH
color 0A
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




:9

@echo off

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

pause 
exit













:10
@echo off
title Metro FM Launcher (MultiArch)

echo Initiating ArchTest...
ping 1.1.1.1 -n 1 -w 250 > nul

if exist "%SYSTEMDRIVE%\Program Files (x86)\" (
   echo 64bit OS detected, Initiating APP-ArchTest...
   ping 1.1.1.1 -n 1 -w 100 > nul
   goto installArchtest
) else (
   echo 32bit OS detected, Initiating APP...
   ping 1.1.1.1 -n 1 -w 100 > nul
   echo.
   goto runmultibit
)

:installArchtest
if exist "%SYSTEMDRIVE%\Program Files\VideoLAN\VLC\" (
   echo 64bit APP on 64bit OS detected, Initiating APP...
   ping 1.1.1.1 -n 1 -w 100 > nul
   echo.
   goto runmultibit
) else (
   echo 32bit APP on 64bit OS detected, Initiating APP...
   ping 1.1.1.1 -n 1 -w 100 > nul
   echo.
   goto run64biton32
)

:runmultibit
cls
start "" "C:\Program Files\VideoLAN\VLC\vlc.exe" -vvv http://provisioning.streamtheworld.com/pls/METRO_FMAAC.pls
echo APP Initiated.
ping 1.1.1.1 -n 1 -w 2000 > nul
goto theEnd

:run64biton32
cls
start "" "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe" -vvv http://provisioning.streamtheworld.com/pls/METRO_FMAAC.pls
echo APP Initiated.
ping 1.1.1.1 -n 1 -w 2000 > nul
goto theEnd

:theEnd
echo.
echo.
echo.
echo Thanks for using this launcher! GOODBYE!
echo.
echo This Launcher is created by "linux.gemini".
echo.
ping 1.1.1.1 -n 1 -w 3500 > nul
exit











:11
@Echo Off

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{645FF040-5081-101B-9F08-00AA002F954E}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{645FF040-5081-101B-9F08-00AA002F954E}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{59031a47-3f72-44a7-89c5-5595fe6b30ee}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{59031a47-3f72-44a7-89c5-5595fe6b30ee}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel" /v "{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /t REG_DWORD /d "0" /f

Reg.exe add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu" /v "{20D04FE0-3AEA-1069-A2D8-08002B30309D}" /t REG_DWORD /d "0" /f

pause
Exit


:12
@Echo Off

Reg.exe delete "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection" /v "DisableRealtimeMonitoring" /f

Reg.exe add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection" /f

pause
Exit

:13
@echo off

Reg.exe add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection" /v "DisableRealtimeMonitoring" /t REG_DWORD /d "1" /f

pause
exit



:14
@echo off
echo Windows Registry Editor Version 5.00 >> %userprofile%\desktop\"classicfoto".reg


echo [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations]>> %userprofile%\desktop\"classicfoto".reg
echo ".tif"="PhotoViewer.FileAssoc.Tiff">> %userprofile%\desktop\"classicfoto".reg
echo ".tiff"="PhotoViewer.FileAssoc.Tiff">> %userprofile%\desktop\"classicfoto".reg
echo ".png"="PhotoViewer.FileAssoc.Tiff">> %userprofile%\desktop\"classicfoto".reg
echo ".bmp"="PhotoViewer.FileAssoc.Tiff">> %userprofile%\desktop\"classicfoto".reg
echo ".jpeg"="PhotoViewer.FileAssoc.Tiff">> %userprofile%\desktop\"classicfoto".reg
echo ".jpg"="PhotoViewer.FileAssoc.Tiff">> %userprofile%\desktop\"classicfoto".reg
echo ".ico"="PhotoViewer.FileAssoc.Tiff">> %userprofile%\desktop\"classicfoto".reg

pause

exit

:15
@ECHO OFF 
color 0A

set /P dosya="Lutfen Adinizi ve Soyadinizi yaziniz: "

TITLE C.By ARTHH
ECHO Lutfen Bekleyin Sistem Bilgileriniz Yukleniyor...

ECHO ============================================================================================================ >>%userprofile%\desktop\"%dosya%".tmp
ECHO XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX>>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp
ECHO %dosya% SYSTEM INFORMATION >>%userprofile%\desktop\"%dosya%".tmp
wmic ComputerSystem GET Model | findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
wmic baseboard get product,Manufacturer,version,serialnumber| findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
wmic os get caption | findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
wmic computersystem get name,systemtype| findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp
ECHO RAM MEMORY INFO >>%userprofile%\desktop\"%dosya%".tmp
wmic MemoryChip get Capacity, Speed, Tag | findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp
wmic cpu get name | findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
wmic path win32_videocontroller get name | findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp
wmic diskdrive get name,model,size,serialnumber | findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp
wmic desktopmonitor get Caption, MonitorType, MonitorManufacturer, Name  | findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
wmic bios get serialnumber |findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp
wmic printer list brief  |findstr /rc:"[^ ]" >>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp
ECHO NETWORK INFO >>%userprofile%\desktop\"%dosya%".tmp
ipconfig | findstr IPv4 >>%userprofile%\desktop\"%dosya%".tmp
ipconfig | findstr IPv6 >>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================ >>%userprofile%\desktop\"%dosya%".tmp
ECHO XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX>>%userprofile%\desktop\"%dosya%".tmp
ECHO ============================================================================================================>>%userprofile%\desktop\"%dosya%".tmp


exit





:16
@echo off
echo Sistem Bilgileriniz Yukleniyor Lutfen Bekleyin.
dxdiag.exe /t \Users\%USERNAME%\Desktop\dxdiag.txt
pause
exit


:17
@echo off
set mypath=%cd%
@echo %mypath%

ren *.tmp *.txt

exit

:18
@echo off
color 0A
:start
set mypath=%cd%
@echo %mypath%

type *.txt > birlestir.txt
::for %f in (*.txt) do type “%f” >> birlestirilmis.txt

echo Birlestirilme tamamlandi...

pause
exit

:19
@echo off
color 0A
cls
                                                                                              
echo    `.............     .:::.      `..........`                 `-::::-          ................... 
echo   `NMMMMMMMMMMMMMo   .MMMMM.    `NMMMMMMMMMMMNms:            `mMMMMMMy        /MMMMMMMMMMMMMMMMMMMo
echo   `MMMMMNNNNNNNNN/   .MMMMM.    .MMMMMmmmmNMMMMMMd.          yMMMMMMMM/       :NNNNNNNMMMMMNNNNNNN+
echo   `MMMMM-            .MMMMM.    .MMMMM.    `/NMMMMh         /MMMMsMMMMN.             `MMMMM:       
echo   `MMMMM-            .MMMMM.    .MMMMM.      sMMMMm        .NMMMy oMMMMd             `MMMMM:       
echo   `MMMMM-            .MMMMM.    .MMMMM.     -mMMMMo        dMMMN`  dMMMMo            `MMMMM:       
echo   `MMMMMhyyyyyyyo    .MMMMM.    .MMMMMyyyyhmMMMMN+        oMMMM/   -MMMMM-           `MMMMM:       
echo   `MMMMMMMMMMMMMM    .MMMMM.    .MMMMMMMMMMMMMh:         -MMMMy     oMMMMm`          `MMMMM:       
echo   `MMMMMyooooooo+    .MMMMM.    .MMMMM+:/omMMMMd-       `mMMMMo/////+NMMMMy          `MMMMM:       
echo   `MMMMM-            .MMMMM.    .MMMMM.    sMMMMN-      sMMMMMMMMMMMMMMMMMM/         `MMMMM:       
echo   `MMMMM-            .MMMMM.    .MMMMM.     yMMMMN.    :MMMMmyyyyyyyyydMMMMN.        `MMMMM:       
echo   `MMMMM-            .MMMMM.    .MMMMM.     `dMMMMm`  `NMMMM-         `mMMMMh        `MMMMM:       
echo   `MMMMM-            .MMMMM.    .MMMMM.      .NMMMMd  hMMMMo           -MMMMMo       `MMMMM:       
echo   `syhys`            `syhys`    `syhys`       -yyhyy.`yyhyo             /yhhyo        syhys`       

pause
exit

:20
@echo off
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





:24
@echo off
color 0a
cls
wmic product get name,version | findstr /rc:"[^ ]" >>%userprofile%\desktop\programlar.txt
exit


:end

