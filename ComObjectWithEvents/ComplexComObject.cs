namespace ComObjectWithEvents
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Timers;
    using Microsoft.Win32;

    [ComVisible(true)]
    [Guid(AssemblyInfo.ComObjectClassGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(ComEvents))]
    [ProgId("ComplexComObject")]
    public class ComplexComObject : IComplexComObject
    {
        [ComRegisterFunction]
        public static void DllRegisterServer(Type t)
        {
            // Additional CLSID entries
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(@"CLSID\{" + AssemblyInfo.ComObjectClassGuid + @"}"))
            {
                using (RegistryKey typeLib = key.CreateSubKey(@"TypeLib"))
                {
                    typeLib.SetValue(string.Empty, "{" + AssemblyInfo.LibraryGuid + "}", RegistryValueKind.String);
                }
            }

            // Interface entries
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(@"Interface\{" + AssemblyInfo.ComObjectInterfaceGuid + @"}"))
            {
                using (RegistryKey typeLib = key.CreateSubKey(@"ProxyStubClsid32"))
                {
                    typeLib.SetValue(string.Empty, "{00020424-0000-0000-C000-000000000046}", RegistryValueKind.String);
                }

                using (RegistryKey typeLib = key.CreateSubKey(@"TypeLib"))
                {
                    typeLib.SetValue(string.Empty, "{" + AssemblyInfo.LibraryGuid + "}", RegistryValueKind.String);
                    Version version = typeof(AssemblyInfo).Assembly.GetName().Version;
                    typeLib.SetValue("Version", string.Format("{0}.{1}", version.Major, version.Minor), RegistryValueKind.String);
                }
            }

            // TLB entries
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(@"TypeLib\{" + AssemblyInfo.LibraryGuid + @"}"))
            {
                Version version = typeof(AssemblyInfo).Assembly.GetName().Version;
                using (RegistryKey keyVersion = key.CreateSubKey(string.Format("{0}.{1}", version.Major, version.Minor)))
                {
                    // typelib key for 32 bit
                    keyVersion.SetValue(string.Empty, AssemblyInfo.Attribute<AssemblyDescriptionAttribute>().Description, RegistryValueKind.String);
                    using (RegistryKey keyWin32 = keyVersion.CreateSubKey(@"0\win32"))
                    {
                        keyWin32.SetValue(string.Empty, Path.ChangeExtension(Assembly.GetExecutingAssembly().Location, ".comhost.tlb"), RegistryValueKind.String);
                    }

                    // typelib key for 64 bit
                    keyVersion.SetValue(string.Empty, AssemblyInfo.Attribute<AssemblyDescriptionAttribute>().Description, RegistryValueKind.String);
                    using (RegistryKey keyWin64 = keyVersion.CreateSubKey(@"0\win64"))
                    {
                        keyWin64.SetValue(string.Empty, Path.ChangeExtension(Assembly.GetExecutingAssembly().Location, ".comhost.tlb"), RegistryValueKind.String);
                    }

                    using (RegistryKey keyFlags = keyVersion.CreateSubKey(@"FLAGS"))
                    {
                        keyFlags.SetValue(string.Empty, "0", RegistryValueKind.String);
                    }
                }
            }
        }

        [ComUnregisterFunction]
        public static void DllUnregisterServer(Type t)
        {
            Registry.ClassesRoot.DeleteSubKeyTree(@"CLSID\{" + AssemblyInfo.ComObjectClassGuid + @"}", false);
            Registry.ClassesRoot.DeleteSubKeyTree(@"Interface\{" + AssemblyInfo.ComObjectInterfaceGuid + @"}", false);
            Registry.ClassesRoot.DeleteSubKeyTree(@"TypeLib\{" + AssemblyInfo.LibraryGuid + @"}", false);
        }

        public ComplexComObject()
        {
            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Elapsed += (Object source, ElapsedEventArgs args) =>
            {
                TriggerAdditionDone();
            };
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        [Guid(AssemblyInfo.OnAdditionDoneDelegateGuid)]
        public delegate void OnAdditionDoneDelegate();

        private event OnAdditionDoneDelegate OnAdditionDone;

        public double Addition(double firstValue, double secondValue)
        {
            TriggerAdditionDone();
            return firstValue + secondValue;
        }

        public void TriggerAdditionDone() => OnAdditionDone?.Invoke();
    }
}