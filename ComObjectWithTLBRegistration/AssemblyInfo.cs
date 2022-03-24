using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(true)]
[assembly: Guid(ComObjectWithTLBRegistration.AssemblyInfo.LibraryGuid)]

namespace ComObjectWithTLBRegistration
{
    internal class AssemblyInfo
    {
        /// <summary> Id for the class </summary>
        internal const string ClassGuid = "1EF51909-8DC7-4ADD-ADC0-12AC469F2F33";

        /// <summary> Id for the interface.</summary>
        internal const string InterfaceGuid = "1418A751-1102-48DA-B96A-C3289CECDBC7";

        /// <summary> Id for the library.</summary>
        internal const string LibraryGuid = "549DA0D4-B6A0-4398-BD2C-C6717E2C1460";

        internal static T Attribute<T>()
            where T : Attribute
        {
            return typeof(AssemblyInfo).Assembly.GetCustomAttribute<T>();
        }
    }
}
