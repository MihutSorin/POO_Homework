using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatii_matrici
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Matrice m1 = new Matrice(3, 3);
            m1.RandomInit(-20, 10);
            Console.WriteLine(m1);
            Matrice m2 = new Matrice(3, 3);
            m2.RandomInit(-10,10);
            Console.WriteLine(m2);

            Matrice m3 = m1 * m2;
            Matrice m4 = m1 + m2;
            Console.WriteLine(m4);
            Console.WriteLine(m3);
            Console.ReadLine();
        }
    }
}
