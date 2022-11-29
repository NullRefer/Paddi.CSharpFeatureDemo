using System;

namespace Paddi.CSharpFeatureDemo.VersionEight.DefaultInterfaceMethod
{
    internal interface IDefaultInterfaceMethod
    {
        void SimpleMethod();

        void DefaultMethod() => Console.WriteLine("Default method");
    }

    internal class DefaultInterfaceMethodNotImplement : IDefaultInterfaceMethod
    {
        public void SimpleMethod()
        {
            Console.WriteLine("Simple method");
        }
    }

    internal class DefaultInterfaceMethodWithImplement : IDefaultInterfaceMethod
    {
        public void SimpleMethod()
        {
            Console.WriteLine("Simple method");
        }

        public void DefaultMethod()
        {
            Console.WriteLine("Implement default method");
        }
    }

}