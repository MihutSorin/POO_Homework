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
           Stiva<int> s1 = new Stiva<int>(); //creaza o stiva de intregi
                s1.Push(1234); //adauga un intreg in stiva t
            int numar = s1.Pop(); //extrage un element din stiva, nu mai estenecesar cast
            Console.WriteLine("Valoarea extrasa din stiva de intregi este{0}",numar);
            Stiva<string> s2 = new Stiva<string>(); //creaza o stiva de stringuri
            s2.Push("exemplu"); //adauga un string in stiva
                string s = s2.Pop(); //extrage un string din stiva
             Console.WriteLine("Valoarea extrasa din stiva de stringuri este'{0}'",s);
            Console.ReadLine();

        }
    }
}
