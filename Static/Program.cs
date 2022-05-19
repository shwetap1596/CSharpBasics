using System;

namespace Static
{
    //Static class can't be inherit, can't create object of static  class
    //Static class have only static membors and static methods
    //Static class don't have constructor, static class have only static constructor 
    //Static class can't inherit interface or class
    //You can't make any method virtual in sealed calss becasue selead class can't be inheritance so no need to override.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //static class A : I1
    //{
        static class A 
    {
        static int a = 0;

        static A()
        {

        }
        static void print()
        {

        }
    }

    class nonStatic
    {
        static nonStatic()
        {

        }

    }
    interface I1
    {

    }
    //class B:A
    //{

    //}

    sealed class C
    {
        //public virtual void print()
        //{

        //}
    }
}
