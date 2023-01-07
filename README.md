# Infinity

![Screenshot 2022-11-08 020530](https://user-images.githubusercontent.com/74864221/200434442-fd79a788-8930-4f60-9917-17096adfceb6.png)


![Screenshot 2022-11-08 020548](https://user-images.githubusercontent.com/74864221/200434445-b8cbcee3-b673-4843-92d5-53046950fb2a.png)




Reg DELETE "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\IEXPLORE.EXE" /f

winget install --silent --accept-package-agreements --accept-source-agreements --id VideoLAN.VLC
winget install --silent --accept-package-agreements --accept-source-agreements --id Discord.Discord
winget install --silent --accept-package-agreements --accept-source-agreements --id Valve.Steam
winget install --silent --accept-package-agreements --accept-source-agreements --id RARLab.WinRAR
winget install --silent --accept-package-agreements --accept-source-agreements --id Opera.OperaGX
winget install --silent --accept-package-agreements --accept-source-agreements --id Notepad++.Notepad++
winget install --silent --accept-package-agreements --accept-source-agreements --id Nvidia.GeForceExperience

reg add "HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32" /f /ve
taskkill /f /im explorer.exe
explorer.exe
