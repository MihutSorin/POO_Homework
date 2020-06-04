using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Names nume = new Names();
            nume.Print();
            nume.Add("carmen ");
            nume.Add("natalia teodora ");
            nume.Print();
            Console.ReadKey();
        }
    }
}
