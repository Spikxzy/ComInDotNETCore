using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

using Microsoft.Win32;

namespace ComObjectBasic
{
    [ComVisible(true)]
    [Guid(AssemblyInfo.ClassGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("SimpleComObject")]
    public class SimpleComObject : ISimpleComObject
    {
        public double Addition(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
