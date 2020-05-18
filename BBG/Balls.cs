using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBG
{
    public  class Balls
    {
        private int x, y;
        private int raza;
        private int pozitie;
        private string type;
       
        public Balls(int x, int y, int raza,int pozitie,string type)
        {
            this.x = x;
            this.y = y;
            this.raza = raza;
            this.pozitie = pozitie;
            this.type = type;

        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int R
        {
            get
            {
                return raza;
            }
            set
            {
                raza = value;
            }
        }
        public int poz
        {
            get
            {
                return pozitie;
            }
            set
            {
                pozitie = value;
            }
        }
        public string Color
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}
