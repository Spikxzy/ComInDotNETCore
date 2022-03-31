﻿namespace MyComObject
{
    using System.Runtime.InteropServices;

    [ComImport]
    [Guid(AssemblyInfo.IMyComObjectGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IMyComObject
    {
        [DispId(1)]
        IMyResult Addition(double value1, double value2);
    }
}
