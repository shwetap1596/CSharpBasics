using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {

        private static string result;

        static void Main()
        {
            SaySomething();
            Console.WriteLine(result);
        }
        static async Task<string> SaySomething()
        {
            Thread.Sleep(5);
            //await Task.Delay(5);
            result = "Hello world!";
            return "Something";
        }



    }
}
