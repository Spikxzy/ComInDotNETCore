using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(true)]
[assembly: Guid(ComObjectWithManagedCode.AssemblyInfo.LibraryGuid)]

namespace ComObjectWithManagedCode
{
    internal class AssemblyInfo
    {
		/// <summary> Id for the class of the COM object.</summary>
		internal const string ComObjClassGuid = "DE468003-94B8-495E-8FDC-FAC4A86AA11C";

		/// <summary> Id for the interface of the COM object.</summary>
		internal const string ComObjInterfaceGuid = "98BF9D9A-14B1-49E6-A7E3-E2064EE6BDE9";

        internal const string ResultClassGuid = "EE4EAE34-E2CC-46AF-B6F6-FF4B79513324";

        internal const string ResultInterfaceGuid = "B4A48873-67CE-4F6A-840B-540301C561B7";

        /// <summary> Id for the library.</summary>
        internal const string LibraryGuid = "68FE1AA9-B7F7-4F00-9D2E-136EE2514CC7";
	}
}
