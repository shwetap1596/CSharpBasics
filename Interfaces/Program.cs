using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        interface I1
        {
            static int i;
            protected void method1();
            static void method2()
            {
                Console.WriteLine("Interface static method 2");
            }
            void method3()
            {
                Console.WriteLine("Interface normal method 2");
            }
        }
        interface I2 : I1
        {
        }
    }
    public class test
    { 
    }
}
