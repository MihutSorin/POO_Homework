using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_interfete
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerc c = new Cerc();
            Patrat p = new Patrat();

            Aria(c);
            Aria(p);
            Console.WriteLine();
            LungimeaFrontierei(c);
            LungimeaFrontierei(p);
            Console.ReadKey();
        }
        public static void Aria(IForma2D arie)
        {
            arie.Aria(4);
        }
        public static void LungimeaFrontierei(IForma2D lf)
        {
            lf.LungimeaFrontierei(2);
        }
    }
}
