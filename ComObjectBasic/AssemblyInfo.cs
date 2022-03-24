using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(true)]
[assembly: Guid(ComObjectBasic.AssemblyInfo.LibraryGuid)]

namespace ComObjectBasic
{
    internal class AssemblyInfo
    {
        /// <summary> Id for the class </summary>
        internal const string ClassGuid = "12882A6C-7176-47BF-8F39-7C029B9350A2";

        /// <summary> Id for the interface.</summary>
        internal const string InterfaceGuid = "79FA01D0-D8A6-4A5F-93AA-0C194109D08F";

        /// <summary> Id for the library.</summary>
        internal const string LibraryGuid = "6CAE0A24-8102-4070-A049-7AF0546E1419";
    }
}
