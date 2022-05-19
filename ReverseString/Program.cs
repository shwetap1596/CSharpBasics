using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput;
            Console.WriteLine("Insert string that should be reverse.: ");
            stringInput = Console.ReadLine();
            ReverseStringWithInbuiltMethod(stringInput);
            ReverseStringWithoutInbuiltMethod(stringInput);
            ReverseStringWithoutInbuildFunctionOptimized(stringInput);
            Console.ReadKey();
        }
        public static void ReverseStringWithoutInbuiltMethod(string stringInput)
        {
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            Console.WriteLine(reversestring);

        }
        public static void ReverseStringWithInbuiltMethod(string stringInput)
        {
            var resultstring = new string(stringInput.ToCharArray().Reverse().ToArray());
            Console.WriteLine(resultstring);
        }
        public static void ReverseStringWithoutInbuildFunctionOptimized(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            Console.WriteLine(new string(chars));

        }
    }

}
