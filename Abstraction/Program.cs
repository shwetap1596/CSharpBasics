using System;

namespace Abstraction
{
    //abstract or virtual or override method can't be private, other can be private , protected, public , internal.
    //abstract class can't be static or sealed
    //Static method can't be abstract, virtual or override
    //Override method only can be sealed
    //Private method can't be accessible by child class but sealed method can.
    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //b.Print();
            C c = new C();
            c.Print1();
        }

        abstract class A
        {
            int a = 0;
            public A()
            {

            }

            ~A()
            {

            }

            public abstract void abstractPrint();
            void Print()
            {
                Console.WriteLine("Non abstract method");
            }
            public virtual void Print1()
            {
                Console.WriteLine("Non abstract virtual method");
            }

        }

        class B : A
        {
            public override void abstractPrint()
            {
                Console.WriteLine("Implemented abstract method");
            }
            public override sealed void Print1()
            {
                Console.WriteLine("Sealed method");
            }
        }

        class C : B
        {
            //public override void Print1()
            //{
            //    Console.WriteLine("Sealed method");
            //}
        }
    }
}
