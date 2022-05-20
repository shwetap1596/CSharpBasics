using System;

namespace Interfaces
{
    //If 2 interface have same method and class implement both interface then class have to define method like Interface.Method name or Methodname with public access modifier.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        interface I1
        {
            //This is valid after C#8 befor it only public method declaration is allowed. no access modifier, no defincation , no variable declaration , no static method or variable.
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
