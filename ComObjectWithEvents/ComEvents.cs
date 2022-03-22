using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ComObjectWithEvents
{
    [ComVisible(true)]
    [Guid(AssemblyInfo.ComEventsGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ComEvents
    {
        [DispId(1)]
        void OnAdditionDone();
    }
}
