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
        public static List<Angajat> _angajati = new List<Angajat>();
        static void Main(string[] args)
        {
           
            Load(@"..\..\DataBase.txt");
            view();
            Console.ReadKey();
        }
        static void Load(string filename)
        {
            TextReader dataload = new StreamReader(filename);
            int n = int.Parse(dataload.ReadLine());

            for (int i = 0; i < n; i++)
            {
                _angajati.Add(new Angajat(dataload.ReadLine()));
            }
        }
        static void view()
        {
            foreach (Angajat ang in _angajati)
            {
                Console.WriteLine(ang.ToString());
            }
        }
       
    }
}
