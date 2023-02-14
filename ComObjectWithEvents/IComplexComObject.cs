using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ComObjectWithEvents
{
    [ComImport]
    [Guid(AssemblyInfo.ComObjectInterfaceGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IComplexComObject
    {
        [DispId(1)]
        double Addition(double firstValue, double secondValue);

        void TriggerAdditionDone();
    }
}
