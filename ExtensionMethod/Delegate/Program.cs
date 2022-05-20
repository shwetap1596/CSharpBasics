using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //Delegate is a reference type data type
    //A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods. Delegates in C# are similar to the function pointer in C/C++.
    //Delegates are mainly used in implementing the call-back methods and event handler.
    //Delegate provides a way to pass a method as argument to other method. To create a Callback in C#
    //Delegates can be chained together as two or more methods can be called on a single event.
    //There is nothing that is done with delegates that cannot be done with regular methods. Delegates are used because they bring several advantages. They foster flexibility of the application and code reuse. 
    class Program
    {
        public delegate void Print(int value);
        public delegate void Anonymous();
        public delegate int Arithm(int x, int y);

        static void Main(string[] args)
        {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;
            // or
            // Print printDel = new Print(PrintNumber);

            printDel.Invoke(100000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(200);

            ///Single cast delegate
            ///‘+’ or ‘+=’ Operator is used to add the methods to delegates.
            ///‘–’ or ‘-=’ Operator is used to remove the methods from the delegates list.

            printDel = PrintNumber;
            printDel += PrintMoney;
            printDel(20);

            //Anonymous methods
            Anonymous anonymous = delegate
            {
                Console.WriteLine("Anonymous method");
            };

            anonymous();

            //delegates as method parameters
            // some  time we need some function call based on some condition at that time this will help
            DoOperation(10, 2, Multiply);
            DoOperation(10, 2, Divide);

            Console.ReadKey();

        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
        static void DoOperation(int x, int y, Arithm del)
        {
            int z = del(x, y);
            Console.WriteLine(z);
        }

        //Generic Delegates Func, Action, and Predicate

        //Func can contains 0 to 16 input parameters and must have one return type.
        // Func<int,int, int> add = Sum;

        //Action can contain 1 to 16 input parameters and does not have any return type.
        // Action<int> printActionDel = ConsolePrint;

        //Predicate delegate should satisfy some criteria of method and must have one input parameter and one Boolean return type either true or false.
        //Predicate<string> isUpper = IsUpperCase;
    }
}
