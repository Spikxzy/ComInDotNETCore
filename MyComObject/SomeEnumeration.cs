using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyComObject
{
    [Guid(AssemblyInfo.EnumGuid)]
    [ComVisible(true)]
    public enum SomeEnumeration
    {
        zero = 0,
        one = 1,
        two = 2,
        three = 3
    }
}
