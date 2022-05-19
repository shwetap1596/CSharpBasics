using System;

namespace Exceptions
{
    //Single try have at least one catch or finally though it's outer or inner try block
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void method1()
        {
            try
            {
                try
                {

                }
                catch
                {

                }
            }
            catch
            {

            }

        }
    }
}
