namespace ComObjectWithEvents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    [ComVisible(true)]
    [Guid(AssemblyInfo.ComEventsGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ComEvents
    {
        [DispId(1)]
        void OnAdditionDone();
    }
}
