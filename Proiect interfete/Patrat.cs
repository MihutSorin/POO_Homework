using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_interfete
{
    public class Patrat : IForma2D
    {
        public string Denumire => throw new NotImplementedException();

        public double Aria(double r)
        {
            double a = r * r;
            Console.WriteLine("Aria patratului avand raza r={0} este A={1:#.##}", r, a);
            return a;
        }

        public float LungimeaFrontierei(float r)
        {
            float a = 4 * r;
            Console.WriteLine("Lungimea frontierei patratului avand raza r={0} este A={1:#.##}", r, a);
            return a;
        }
    }
}



