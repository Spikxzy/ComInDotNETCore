using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

[assembly: ComVisible(true)]
[assembly: Guid(ComObjectWithEvents.AssemblyInfo.LibraryGuid)]

namespace ComObjectWithEvents
{
    internal class AssemblyInfo
    {
        internal const string LibraryGuid = "3D37CAC5-1A40-4E19-BDCD-C0020DB78EF7";
        internal const string ComObjectInterfaceGuid = "26673784-89E0-4215-9B1A-0CB078AC4E8B";
        internal const string ComEventsGuid = "51249E63-A9E2-4713-8EFA-CA8F9C6BFBB7";
        internal const string OnAdditionDoneDelegateGuid = "DB769A5F-95B0-45F3-A2BF-73F7BB5CC74D";
        internal const string ComObjectClassGuid = "01B19BC2-010D-4B97-9789-17EE1083CE5F";

        internal static T Attribute<T>()
            where T : Attribute
        {
            return typeof(AssemblyInfo).Assembly.GetCustomAttribute<T>();
        }
    }
}
