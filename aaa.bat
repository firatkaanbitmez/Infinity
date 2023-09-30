
::İnternet Explorer path DELETE
Reg DELETE "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\IEXPLORE.EXE" /f
::Power settings Addded Ultimate Performance
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61
::Power Ultimate Set and PowerSleep Zero
powercfg -S e9a42b02-d5df-448d-aa00-03f14749eb61
powercfg /change -monitor-timeout-ac 0
powercfg /change -monitor-timeout-dc 0
powercfg /change -standby-timeout-ac 0
powercfg /change -standby-timeout-dc 0
powercfg /change -hibernate-timeout-ac 0
powercfg /change -hibernate-timeout-dc 0


::Bacground COLOR BLACK

reg add "HKEY_CURRENT_USER\Control Panel\Desktop" /v WallPaper /t REG_SZ /d " " /f

reg add "HKEY_CURRENT_USER\Control Panel\Colors" /v Background /t REG_SZ /d "0 0 0" /f
RUNDLL32.EXE user32.dll,UpdatePerUserSystemParameters

taskkill /f /im explorer.exe
explorer.exe



::BACKGROUND APPLİCATİON DİSABLE
Reg Add HKCU\Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications /v GlobalUserDisabled /t REG_DWORD /d 1 /f
::TRANSPARENCT EFFECT DİSABLE
Reg Add HKCU\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize /v EnableTransparency /t REG_DWORD /d 0 /f

::XBOX GAMEDVR DİSABLE
reg.exe add ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR"" /v ""AppCaptureEnabled"" /t REG_DWORD /d ""0"" /f"

::Windows_11_Change_OldContextMenu
reg add "HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32" /f /ve
taskkill /f /im explorer.exe
explorer.exe

::Windows Defender Disable
Reg.exe add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection" /v "DisableRealtimeMonitoring" /t REG_DWORD /d "1" /f


::Disable_Windows_Search_on_taskbar_and_Start_menu_for_all_users
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\default\Search" /v "DisableSearch" /t REG_DWORD /d 1 /f
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\Windows Search" /v "DisableSearch" /t REG_DWORD /d 1 /f



::ALL SYSTEM CLEANER



cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden "Write-Host"

if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b) 


del /s /f /q “%USERPROFILE%\Local Settings\History”*.*
rd /s /q “%USERPROFILE%\Local Settings\History”
md “%USERPROFILE%\Local Settings\History”
del /s /f /q “%USERPROFILE%\Local Settings\Temporary Internet Files”*.*
rd /s /q “%USERPROFILE%\Local Settings\Temporary Internet Files”
md “%USERPROFILE%\Local Settings\Temporary Internet Files”
del /s /f /q “%USERPROFILE%\Local Settings\Temp”*.*
rd /s /q “%USERPROFILE%\Local Settings\Temp”
md “%USERPROFILE%\Local Settings\Temp”
del /s /f /q “%USERPROFILE%\Recent”*.*
rd /s /q “%USERPROFILE%\Recent”
md “%USERPROFILE%\Recent”
del /s /f /q “%USERPROFILE%\Cookies”*.*
rd /s /q “%USERPROFILE%\Cookies”
md “%USERPROFILE%\Cookies”


rd /s /q %prefetch%
mkdir %prefetch%
rd /s /q c:\windows\prefetch\
mkdir c:\windows\prefetch\


rd /s /q %temp%
mkdir %temp%
rd /s /q c:\windows\temp\
mkdir c:\windows\temp\

del /f /s /q %windir%\prefetch\*.* rd /s /q %windir%\temp & md %windir%\temp 



rd /s /q %SYSTEMDRIVE%\$Recycle.bin


powershell.exe -command "cleanmgr /sagerun:1 | out-Null"


RD /S /Q %SystemDrive%\windows.old
 
del /f /s /q %systemdrive%\*.tmp 

del /f /s /q %systemdrive%\*._mp 

del /f /s /q %systemdrive%\*.log 

del /f /s /q %systemdrive%\*.gid 

del /f /s /q %systemdrive%\*.chk  

del /f /s /q %systemdrive%\*.old 

del /f /s /q %windir%\*.bak 


attrib -h -r -s %windir%\system32\catroot2
attrib -h -r -s %windir%\system32\catroot2.
net stop wuauserv
net stop cryptSvc
net stop bits
net stop msiserver
Ren C:\Windows\SoftwareDistribution SoftwareDistribution.old
Ren C:\Windows\System32\catroot2 Catroot2.old
net start wuauserv
net start cryptSvc
net start bits
net start msiserver


