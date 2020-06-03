using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    public class Angajat:Persoana
    {
        private int anulAngajarii;
        public Angajat(string nm, string pnm, int anang): base(nm, pnm)
        {
            this.anulAngajarii = anang;
        }
    }
}
