using System;
using System.Runtime.InteropServices;

namespace MyComLibrary
{
    // 设置GUID和COM可见性
    [Guid("E7BAE5C8-07C7-4D8C-9A1E-0F88B5A7E0B1")]
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IMyComClass
    {
        void MyMethod();
    }

    [Guid("F2BAE5C8-07C7-4D8C-9A1E-0F88B5A7E0B1")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class MyComClass : IMyComClass
    {
        public void MyMethod()
        {
            Console.WriteLine("MyMethod called");
        }
    }
}
