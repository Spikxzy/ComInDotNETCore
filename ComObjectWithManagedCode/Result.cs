using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ComObjectWithManagedCode
{
    [ComVisible(true)]
    [Guid(AssemblyInfo.ResultClassGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Result : IResult
    {
        private double value;

        public Result(double value)
        {
            this.value = value;
        }

        public double ReturnResult()
        {
            return value;
        }
    }
}
