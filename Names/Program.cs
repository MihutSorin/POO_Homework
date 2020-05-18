using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Names nume = new Names();
            nume.Print();
            nume.Add("carmen ");
            nume.Add("natalia teodora mihut");
            nume.Print();
            Console.ReadKey();
        }
    }
}
