using System.Runtime.InteropServices;

namespace ComObjectWithEvents
{
    [ComVisible(true)]
    [Guid(AssemblyInfo.ComObjectClassGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(ComEvents))]
    [ProgId("ComplexComObject")]
    public class ComplexComObject : IComplexComObject
    {
        [Guid(AssemblyInfo.OnAdditionDoneDelegateGuid)]
        public delegate void OnAdditionDoneDelegate();

        private event OnAdditionDoneDelegate OnAdditionDone;

        public double Addition(double firstValue, double secondValue)
        {
            var ev = OnAdditionDone;
            if (ev != null)
            {
                ev();
            }

            return firstValue + secondValue;
        }
    }
}