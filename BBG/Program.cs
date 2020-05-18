using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBG
{
    class Program
    {
        static void Main(string[] args)
        {
            Balls b1 = new Balls(2, 4, 5, 6,"regular");
            Balls b2 = new Balls(2, 2, 2, 2, "monster");
            Balls b3 = new Balls(2, 2, 2, 2, "repelent");
            Console.WriteLine(b2.Color);

            Console.ReadLine();
        }
    }
}
