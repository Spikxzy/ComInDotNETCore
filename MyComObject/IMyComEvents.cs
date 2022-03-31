namespace MyComObject
{
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [Guid(AssemblyInfo.IMyComEventsGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IMyComEvents
    {
        [DispId(1)]
        void OnAdditionDone();
    }
}
