namespace ComObjectBasic
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport]
    [Guid(AssemblyInfo.InterfaceGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ISimpleComObject
    {
        double Addition(double firstValue, double secondValue);
        string HelloWorld();
    }
}
