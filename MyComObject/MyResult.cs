namespace MyComObject
{
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [Guid(AssemblyInfo.MyResultGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    public class MyResult : IMyResult
    {
        private double result;

        public MyResult(double value1, double value2)
        {
            this.result = value1 + value2;
        }

        public double ReturnResult()
        {
            return this.result;
        }
    }
}
