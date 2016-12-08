using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ERP.General
{
    class Registr
    {

        public static void SetSkin(string skinName)
        {
         
            RegistryKey rk = null;
            try
            {
                RegistryKey userDefaults = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                if (userDefaults != null) rk = userDefaults.CreateSubKey(Application.ProductName + @"\Skin");
                if (rk != null) rk.SetValue("Skin",skinName);}
            catch 
            {
                // ignored
            }
        }

        public static string GetSkin()
        {
            var value = string.Empty;
            RegistryKey software = Registry.CurrentUser.OpenSubKey("Software", false);
            if (software != null)
            {
                RegistryKey skinKey = software.OpenSubKey(Application.ProductName + @"\Skin", false);
                value = skinKey != null && (skinKey.GetValue("Skin", 0).ToString() != "0")
                    ? skinKey.GetValue("Skin").ToString()
                    : String.Empty;
            }
            return value;
        }
        public static void WriteToRegistry(string path,string name,string value)
        {

            RegistryKey rk = null;
            try
            {
                RegistryKey userDefaults = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                if (userDefaults != null) rk = userDefaults.CreateSubKey(path); 
                rk?.SetValue(name, value);
            }
            catch
            {
                
            }
        }

        public static string ReadFromRegistry(string path, string value)
        {
            var result = string.Empty;
         
            var software = Registry.CurrentUser.OpenSubKey("Software", false);
            if (software != null)
            {
                RegistryKey key = software.OpenSubKey(path, false);
                result = key != null && (key.GetValue(value, 0).ToString() != "0")
                    ? key.GetValue(value).ToString()
                    : string.Empty;

            }
            return result;
        }

    }
}
