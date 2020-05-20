using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasa_stiva1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stiva stiva = new Stiva();
             stiva.Push(1234);
                int numar = (int)stiva.Pop();
                Console.WriteLine(numar);
                Console.ReadLine();

        }
    }
}
