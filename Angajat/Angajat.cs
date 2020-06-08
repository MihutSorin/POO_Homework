using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    public class Angajati<T>
    {
        public List<Persoana> list = new List<Persoana>();
        public Angajati()
        {

        }
        public Angajati(Persoana angajat)
        {
            this.list.Add(angajat);
        }
        public void Add(Persoana angajat)
        {
            this.list.Add(angajat);
        }

        public void Remove(Persoana angajat)
        {
            this.list.Remove(angajat);
        }
        public void SortByName()
        {
            IComparer<Persoana> myComparer = new SortAlphabetically();
            this.list.Sort(myComparer);
        }
        public void Vechime()
        {
            IComparer<Persoana> myComparer = new SortByVechime();
            this.list.Sort(myComparer);
        }
    }

    internal class SortByVechime : IComparer<Persoana>
    {
        public int Compare(Persoana x, Persoana y)
        {
            int anulAngajarii = x.data.Year.CompareTo(y.data.Year);
            if (anulAngajarii == 0)
            {
                return x.data.Month.CompareTo(y.data.Month);
            }
            return anulAngajarii;
        }
    }

    internal class SortAlphabetically : IComparer<Persoana>
    {
        public int Compare(Persoana x, Persoana y)
        {
            int nume = x.nume.CompareTo(y.nume);
            if (nume == 0)
            {
                return x.prenume.CompareTo(y.prenume);
            }
            return nume;
        }
    }
}
