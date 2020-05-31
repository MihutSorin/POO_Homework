using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher
{
    public delegate void iteratie(int i);     // declarare tip delegat atasat evenimentului


    class Program
    {
        static void Main(string[] args)
        {
            Publisher pb = new Publisher();
            SubscriberA SBa = new SubscriberA();
            SubscriberB SBb = new SubscriberB();

            pb.eveniment += SBa.metodaClasaSubscriber;
            pb.eveniment += SBb.metodaClasaSubscriber;

            pb.DeclansareEveniment();

            Console.ReadKey();

        }
    }
}
