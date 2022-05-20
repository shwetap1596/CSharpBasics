
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    //An extension method is a static method of a static class, where the "this" modifier is applied to the first parameter. The type of the first parameter will be the type that is extended.
    //Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.
    public static class Extension
    {
        //1. Example 1
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        //2. Example2
        //i am adding this method into test class so now at any place in project you can user this method as test class method like other test class method
        public static void M4(this test g)
        {
            Console.WriteLine("Method Name: M4");
        }
        public static void M5(this test g, string str)
        {
            Console.WriteLine(str);
        } 
    }
}
