using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    public class Persoana
    {
        public string nume;
        public string prenume;
        public DateTime data;
        public Persoana(string nm, string pnm,DateTime data)
        {
            this.nume = nm;
            this.prenume = pnm;
            this.data = data;
        }
       

    }
}
