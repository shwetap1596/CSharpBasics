using System;

namespace Polymorphism
{
    //We can override virutual, abstract, override method and method return type, name, argument must be same.
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A ab = new B();
            B b = new B();
            a.method1();
            ab.method1();
            b.method1();
        }
    }

    #region overriding
    public class A
    {
        public virtual void method1()
        {
            Console.WriteLine("Class A - Method 1");
        }
    }

    public class B : A
    {
        public override void method1()
        {
            Console.WriteLine("Class B - Method 1");
        }
    }
    #endregion

    //#region simple
    //public class A
    //{
    //    public void method1()
    //    {
    //        Console.WriteLine("Class A - Method 1");
    //    }
    //}

    //public class B : A
    //{
    //    public void method1()
    //    {
    //        Console.WriteLine("Class B - Method 1");
    //    }
    //}
    //#endregion

    #region overhidding
    //public class A
    //{
    //    public virtual void method1()
    //    {
    //        Console.WriteLine("Class A - Method 1");
    //    }
    //}

    //public class B : A
    //{
    //    public new void method1()
    //    {
    //        Console.WriteLine("Class B - Method 1");
    //    }
    //}
    #endregion


    //#region methodOverloading

    //public class A
    //{
    //    public void method1(int i)
    //    {

    //    }
    //    public string method1(int i)
    //    {
    //        return "";
    //    }
    //}
    //#endregion
}
