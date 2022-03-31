namespace MyComObject
{
    using System.Runtime.InteropServices;

    [ComImport]
    [Guid(AssemblyInfo.IMyResultGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IMyResult
    {
        [DispId(1)]
        double ReturnResult();
    }
}
