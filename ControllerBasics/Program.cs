using System;

namespace ControllerBasics
{//If you define any constructor then you have to define default else it will not take default constructor like it will do when you don't define any constructor.
 //Constructor have access modifer
 //If you constructor in static then access modifier is not allowed , static constructor must be parameter less , class have only one static constructor,
 //If you have static constructor , you can also define default constructor. 
 //Static constructor called once when 1st object of that class is created.
 //By this you can call same class constructor from other constructor
 //By Base you can call parent class  constructor from child class constructor, if you don't define then default constructor of parent class will be called.
 //A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
 //A constructor can not be abstract, final, and Synchronized.
 //Types of Constructor : Default Constructor Parameterized Constructor Copy Constructor Private Constructor Static Constructor
 //Private constructor : stop class inheritance, singleton class implementation, stop initialization of class object out side of class

    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //A a1 = new A(1, 2);
            //A str = new A("Private");
            //B b = new B(1);

            #region Destructor
            {
                A a = new A();
                Console.WriteLine("Inside loop");
            }
            Console.WriteLine("Out side loop");
            #endregion

            Console.ReadKey();
        }

        public class A
        {
            //static int i = 0;
            //static A()
            //{
            //    i = 1;
            //    Console.WriteLine("static constructor");
            //}

            //public A()
            //{
            //    Console.WriteLine("default constructor");

            //}
            //public A(int a, int b) : this(1)
            //{
            //    Console.WriteLine("Multi Paraeterised constructor");
            //}
            //public A(int a)
            //{
            //    Console.WriteLine("Paramerised constructor");
            //}

            //A(string str)
            //{
            //    Console.WriteLine("Private constructor");
            //}

            //A str = new A("Private");

            ~A()
            {
                Console.WriteLine("Destructor");
            }

        }

        public class B : A
        {
            //public B() : base(1)
            //{
            //    Console.WriteLine("Default constructor");
            //}
            ////public B(string str):base("private")
            ////{
            ////    Console.WriteLine("Private constructor of base class");
            ////}
            //public B(int a)
            //{
            //    Console.WriteLine("Parameterized constructor");
            //}
        }
    }
}
