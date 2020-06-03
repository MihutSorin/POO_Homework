using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Angajat
{
    class Program
    {
        public static List<Angajat> _angajat = new List<Angajat>();
        static void Main(string[] args)
        {
            _angajat = new List<Angajat>();

            TextReader dataLoad = new StreamReader(@"E:\POO_Homework\Angajat\DataBase.txt");
            string buffer = dataLoad.ReadToEnd();
            Console.WriteLine(buffer);
            
            Console.ReadKey();
        }
    }
}
