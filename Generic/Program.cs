using System;
using System.Collections.Generic;

namespace Generic
{
    //Generic class can inherit concreate, abstract classed and interface.
    //Other non generic, generic, abstract class can inherit generic class.
    //If you call method with T , if your method take T arg then no need to mention like methodName<datatype> it will take from argument 
    //but if not use in argument then you have to mention datatype while calling
    class Program
    {
        static void Main(string[] args)
        {
            Csharp c = new Csharp();
            c.subject<int>("hi");
            c.subjectInt(20);
        }
    }

    public class Csharp
    {
        public void subject<S>(string arg)
        {
            Console.WriteLine(arg);
        }
        public void subjectInt<S>(S arg)
        {
            Console.WriteLine(arg);
        }
    }

}
