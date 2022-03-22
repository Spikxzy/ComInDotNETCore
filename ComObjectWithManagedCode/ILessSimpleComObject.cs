namespace ComObjectWithManagedCode
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport]
    [Guid(AssemblyInfo.ComObjInterfaceGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ILessSimpleComObject
    {
        IResult Addition(double firstValue, double secondValue);
        string HelloWorld();
    }
}
