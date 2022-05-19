using System;

namespace DOT_NET_BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.AddNumbers(5, 5));

            B b = new B();
            b.ToString();
            Console.ReadKey();
        }
    }

    public class A
    {
        public int AddNumbers(int x, int y, int z = 0)
        {
            return x + y + z;
        }
        public int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
    public class B
    {

    }

}
