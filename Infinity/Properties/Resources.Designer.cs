﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infinity.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Infinity.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Active_security {
            get {
                object obj = ResourceManager.GetObject("Active security", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///
        ///
        ///del /s /f /q “%USERPROFILE%\Local Settings\History”*.*
        ///rd /s /q “%USERPROFILE%\Local Settings\History”
        ///md “%USERPROFILE%\Local Settings\History”
        ///del /s /f /q “%USERPROFILE%\Local Settings\Temporary Internet Files”*.*
        ///rd /s /q “%USERPROFILE%\Local Settings\Temporary Internet Files”
        ///md “%USERPROFILE%\Local Settings\Temporary Internet Files”
        ///del [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string All_cleaner {
            get {
                return ResourceManager.GetString("All_cleaner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap back_arrows {
            get {
                object obj = ResourceManager.GetObject("back-arrows", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap bynogame {
            get {
                object obj = ResourceManager.GetObject("bynogame", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///@echo off
        ///title C.By.ARTHHH
        ///color 0A
        ///cls
        ///
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///
        ///
        ///
        ///
        ///net stop w32time
        ///
        ///w32tm /unregister
        ///
        ///w32tm /register
        ///
        ///net start w32time
        ///
        ///w32tm /resync
        ///
        ///
        ///
        ///exit.
        /// </summary>
        internal static string Clock_restart {
            get {
                return ResourceManager.GetString("Clock_restart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap deactive_security {
            get {
                object obj = ResourceManager.GetObject("deactive security", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///
        ///
        ///Reg.exe add &quot;HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection&quot; /v &quot;DisableRealtimeMonitoring&quot; /t REG_DWORD /d &quot;1&quot; /f
        ///
        ///
        ///exit
        ///.
        /// </summary>
        internal static string DefenderDisable {
            get {
                return ResourceManager.GetString("DefenderDisable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///
        ///
        ///
        ///Reg.exe delete &quot;HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection&quot; /v &quot;DisableRealtimeMonitoring&quot; /f
        ///
        ///Reg.exe add &quot;HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection&quot; /f
        ///
        ///
        ///exit
        ///.
        /// </summary>
        internal static string DefenderEnable {
            get {
                return ResourceManager.GetString("DefenderEnable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap fail {
            get {
                object obj = ResourceManager.GetObject("fail", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap fast_forward1 {
            get {
                object obj = ResourceManager.GetObject("fast-forward1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream gb_düstü_cek {
            get {
                return ResourceManager.GetStream("gb_düstü_cek", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream gb_yükseldi_sound {
            get {
                return ResourceManager.GetStream("gb_yükseldi_sound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_about_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_about_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_back_50px {
            get {
                object obj = ResourceManager.GetObject("icons8_back_50px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_ccleaner_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_ccleaner_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_ccleaner_48px {
            get {
                object obj = ResourceManager.GetObject("icons8_ccleaner_48px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_ccleaner_48px1 {
            get {
                object obj = ResourceManager.GetObject("icons8_ccleaner_48px1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_cd_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_cd_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_delete_folder_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_delete_folder_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_downloading_updates_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_downloading_updates_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_folder_tree_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_folder_tree_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_Gold_Bars_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_Gold_Bars_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_launch_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_launch_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_Logout_Rounded_48px {
            get {
                object obj = ResourceManager.GetObject("icons8_Logout_Rounded_48px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_microsoft_edge_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_microsoft_edge_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_next_page_50px {
            get {
                object obj = ResourceManager.GetObject("icons8_next_page_50px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_ok_50px {
            get {
                object obj = ResourceManager.GetObject("icons8_ok_50px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_ok_96px {
            get {
                object obj = ResourceManager.GetObject("icons8_ok_96px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_refresh_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_refresh_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_refresh_50px_1 {
            get {
                object obj = ResourceManager.GetObject("icons8_refresh_50px_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_refresh_96px {
            get {
                object obj = ResourceManager.GetObject("icons8_refresh_96px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_registry_editor_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_registry_editor_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_replace_96px {
            get {
                object obj = ResourceManager.GetObject("icons8_replace_96px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_restart_48px {
            get {
                object obj = ResourceManager.GetObject("icons8_restart_48px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_shutdown_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_shutdown_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_shutdown_48px {
            get {
                object obj = ResourceManager.GetObject("icons8_shutdown_48px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_Software_Installer_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_Software_Installer_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_solve_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_solve_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_trash_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_trash_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_unavailable_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_unavailable_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_windows_10_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_windows_10_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_word_32px {
            get {
                object obj = ResourceManager.GetObject("icons8_word_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap image_processing20210906_14793_3orv2p {
            get {
                object obj = ResourceManager.GetObject("image_processing20210906-14793-3orv2p", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap infinity__2_ {
            get {
                object obj = ResourceManager.GetObject("infinity__2_", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon infinity__2_1 {
            get {
                object obj = ResourceManager.GetObject("infinity__2_1", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap kopazar_logo {
            get {
                object obj = ResourceManager.GetObject("kopazar-logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap kopazar_logo1 {
            get {
                object obj = ResourceManager.GetObject("kopazar-logo1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap kopazar_logo2 {
            get {
                object obj = ResourceManager.GetObject("kopazar-logo2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap kopazarrrr {
            get {
                object obj = ResourceManager.GetObject("kopazarrrr", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap logout {
            get {
                object obj = ResourceManager.GetObject("logout", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap microsoft__1_ {
            get {
                object obj = ResourceManager.GetObject("microsoft__1_", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Multi_Circle_Preloader {
            get {
                object obj = ResourceManager.GetObject("Multi-Circle-Preloader", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ok {
            get {
                object obj = ResourceManager.GetObject("ok", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap popupinfinity {
            get {
                object obj = ResourceManager.GetObject("popupinfinity", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap question {
            get {
                object obj = ResourceManager.GetObject("question", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Reload_1_3s_197px__1_ {
            get {
                object obj = ResourceManager.GetObject("Reload-1.3s-197px (1)", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Reload_1s_200px__1_ {
            get {
                object obj = ResourceManager.GetObject("Reload-1s-200px (1)", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///
        ///
        ///ipconfig /flushdns
        ///ipconfig /registerdns
        ///ipconfig /release
        ///ipconfig /renew
        ///netsh winsock reset
        ///
        ///
        ///exit
        ///.
        /// </summary>
        internal static string Reset_an_Internet_Connection__Flush_DNS_ {
            get {
                return ResourceManager.GetString("Reset_an_Internet_Connection__Flush_DNS_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap settings {
            get {
                object obj = ResourceManager.GetObject("settings", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///
        ///rd /s /q %prefetch%
        ///mkdir %prefetch%
        ///rd /s /q c:\windows\prefetch\
        ///mkdir c:\windows\prefetch\
        ///
        ///
        ///rd /s /q %temp%
        ///mkdir %temp%
        ///rd /s /q c:\windows\temp\
        ///mkdir c:\windows\temp\
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///exit
        ///.
        /// </summary>
        internal static string Temporary_Files__Temp_Prefetch_Cache_ {
            get {
                return ResourceManager.GetString("Temporary_Files__Temp_Prefetch_Cache_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap upgrade {
            get {
                object obj = ResourceManager.GetObject("upgrade", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///
        ///
        ///
        ///reg add &quot;HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32&quot; /f /ve
        ///taskkill /f /im explorer.exe
        ///explorer.exe
        ///
        ///
        ///
        ///exit
        ///.
        /// </summary>
        internal static string Windows_11_Change_OldContextMenu {
            get {
                return ResourceManager.GetString("Windows_11_Change_OldContextMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap windows_xp_loading {
            get {
                object obj = ResourceManager.GetObject("windows-xp-loading", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap windows_xp_loading1 {
            get {
                object obj = ResourceManager.GetObject("windows-xp-loading1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///@echo off
        ///color 0A
        ///
        ///
        ///
        ///if not &quot;%1&quot;==&quot;am_admin&quot; (powershell start -verb runas &apos;%0&apos; am_admin &amp; exit /b) 
        ///cmd /c powershell -Nop -NonI -Nologo -WindowStyle Hidden &quot;Write-Host&quot;
        ///
        ///title C.By ARTHH
        ///cls
        ///
        ///cd %userprofile%\downloads
        ///
        ///curl -L https://github.com/microsoft/winget-cli/releases/latest/download/Microsoft.DesktopAppInstaller_8wekyb3d8bbwe.msixbundle -o winpackageins.msixbundle
        ///
        ///
        ///
        ///powershell -command &quot;Add-AppPackage -path &quot;%userprofile%\downloads\winpackageins.msixbundle&quot;&quot;
        ///
        ///winget search  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string windowspackagerinstall {
            get {
                return ResourceManager.GetString("windowspackagerinstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap yesilyurtlogo {
            get {
                object obj = ResourceManager.GetObject("yesilyurtlogo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
