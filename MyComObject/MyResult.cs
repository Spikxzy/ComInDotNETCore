namespace MyComObject
{
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [Guid(AssemblyInfo.MyResultGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    public class MyResult : IMyResult
    {
        private static double betterResult;

        private double result;

        public static void SetResult()
        {
            betterResult = 1;
        }

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
