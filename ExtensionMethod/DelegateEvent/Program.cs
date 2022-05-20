using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {

        static void Main(string[] args)
        {
            FEvent fe = new FEvent();
            //fe.FiveEvent += new OnFiveHandler(Callback);
            fe.FiveEvent += Callback;//Here Callback is event handler and event handler has the same signature as the delegate

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int rn = random.Next(6);

                Console.WriteLine(rn);

                if (rn == 5)
                {
                    fe.OnFiveEvent();
                }
            }
            Console.ReadKey();
        }
        public static void Callback(object sender, EventArgs e)
        {
            Console.WriteLine("Five Event occured");
        }
    }
}
