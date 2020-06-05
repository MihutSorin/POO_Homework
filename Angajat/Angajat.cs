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
        private string v;
        private string[] date;

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

        public Angajat(string nm, string pnm, string v, string[] date) : base(nm, pnm)
        {
            this.v = v;
            this.date = date;
        }

        public Angajat(string data)
        {
            string[] tmp = data.Split(',');
            this.nume = tmp[0];
            this.prenume = tmp[1];
            this.anulAngajarii = int.Parse(tmp[2]);
        }

        public override string ToString()
        {
            return "angajatul:"+nume+" "+prenume+" "+ anulAngajarii.ToString();
        }
    }
}
