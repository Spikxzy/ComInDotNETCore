namespace ComObjectWithManagedCode
{
    using System;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [Guid(AssemblyInfo.ComObjClassGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("LessSimpleComObject")]
    public class LessSimpleComObject : ILessSimpleComObject
    {
        public IResult Addition(double firstValue, double secondValue)
        {
            return new Result(firstValue + secondValue);
        }

        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}