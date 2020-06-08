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
        public static Angajati<Persoana> _angajati = new Angajati<Persoana>();
        static void Main(string[] args)
        {
           
            Load(@"..\..\DataBase.txt");
            _angajati.SortByName();
            
            LoadtoDB(@"E:\POO_Homework\Angajat\Databaseinfo.txt");
            _angajati.Vechime();
            LoadtoDBVechime(@"E:\POO_Homework\Angajat\DBVechime.txt");
            Console.ReadKey();
        }
        static void Load(string filename)
        {
            _angajati = new Angajati<Persoana>();
            StreamReader dataLoad = new StreamReader(filename);
            string line = dataLoad.ReadLine();

            while (line != null)
            {
                string[] date = line.Split(' ');
                string nume = date[0];
                string prenume = date[1];
                string[] fullDate = date[2].Split('/');
                DateTime data = new DateTime(int.Parse(fullDate[0]), int.Parse(fullDate[1]), int.Parse(fullDate[2]));

                Persoana angajati = new Persoana(nume, prenume, data);
                _angajati.Add(angajati);

                line = dataLoad.ReadLine();
            }
        }
        private static void LoadtoDB(string filepath)
        {
            StreamWriter dataOutput = new StreamWriter(filepath);
            foreach (Persoana angajat in _angajati.list)
            {
                dataOutput.WriteLine($"{angajat.nume} {angajat.prenume} ");
            }
            dataOutput.Close();
        }
        private static void LoadtoDBVechime(string filepath)
        {
            StreamWriter dataOutput = new StreamWriter(filepath);
            foreach (Persoana angajat in _angajati.list)
            {
                int vechime = (DateTime.Now.Year - angajat.data.Year) * 12 + (DateTime.Now.Month - angajat.data.Month);
                dataOutput.WriteLine($"{angajat.nume} {angajat.prenume} :are o vechime de: " +
                    $"{vechime / 12} ani and " +
                    $"{vechime % 12} luni");
            }
            dataOutput.Close();
        }
    }
}
