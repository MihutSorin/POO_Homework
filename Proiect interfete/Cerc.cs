using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_interfete
{
    public class Cerc : IForma2D
    {
        public string Denumire => throw new NotImplementedException();

        public double Aria(double r)
        {
            double A = 4 * (Math.Atan(1)) * r * r;
            Console.WriteLine("Aria cercului avand raza r={0} este A={1:#.##}", r, A);
            return A;
        }

        public float LungimeaFrontierei(float r)
        {
            float a = 2 * r * (float)Math.PI;
            Console.WriteLine("lungimea frontierei cercului avand raza r={0} este A={1:#.##}", r, a);
            return a;
        }
    }
}
