using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    public class Angajat:Persoana
    {
        private int anulAngajarii;
        public const int nr_max = 10; 
        public static int nr_angajati = 0; 
        public static Angajat[] angajati = new Angajat[nr_max]; 
        public static void adaug_angajat(Angajat a) 
        {
            angajati[nr_angajati++] = a;
            if (nr_angajati == nr_max)
                throw new Exception("Prea multi angajati");
        }
        public Angajat(string nm, string pnm, int anang): base(nm, pnm)
        {
            this.anulAngajarii = anang;
        }

        public Angajat()
        {

        }

        public override string ToString()
        {
            return "angajatul:"+nume+" "+prenume+" "+ anulAngajarii.ToString();
        }
    }
}
