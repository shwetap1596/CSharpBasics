using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        //In C#, the extension method concept allows you to add new methods in the existing class or in the structure without modifying the source code of the original type 
        //and you do not require any kind of special permission from the original type and there is no need to re-compile the original type. It is introduced in C# 3.0.
        // 1 Use: we can add method in any third party dll and we can use it all over project.
        static void Main(string[] args)
        {
            // 1  example
            //int i = 10;

            //bool result = i.IsGreaterThan(100);

            //Console.WriteLine(result);

            // 2 example
            test t1 = new test();
            t1.M1();
            t1.M2();
            t1.M3();
            t1.M4();
            t1.M5("Method Name: M5"); 
            Console.ReadKey();
        }
    }

    public class test
    {
        // Method 1 
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        // Method 2 
        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        // Method 3 
        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        } 
    }
}

//Notes:

//Extension methods are always defined as a static method, but when they are bound with any class or structure they will convert into non-static methods.
//Here, Binding parameters are those parameters which are used to bind the new method with the existing class or structure. It does not take any value when you are calling the extension method because they are used only for binding not for any other use. In the parameter list of the extension method binding parameter is always present at the first place if you write binding parameter to second, or third, or any other place rather than first place then the compiler will give an error. The binding parameter is created using this keyword followed by the name of the class in which you want to add a new method and the parameter name
//Multiple binding parameters are not allowed means an extension method only contains a single binding parameter. But you can define one or more normal parameter in the extension method.
//When an extension method is defined with the same name and the signature of the existing method, then the compiler will print the existing method, not the extension method. Or in other words, the extension method does not support method overriding.
//The main advantage of the extension method is to add new methods in the existing class without using inheritance.
