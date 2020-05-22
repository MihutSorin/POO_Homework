using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace operatii_matrici
{
    public class Matrice
    {
        private readonly int linie;
        private readonly int coloana;
        private int[,] data;
        public Matrice(int linie, int coloana)
        {
            this.linie = linie;
            this.coloana = coloana;
            data = new int[linie, coloana];
        }
        public int Linii { get => linie; }
        public int Coloane { get => coloana; }
        public int this[int linie, int coloana]
        {
            get
            {
                if (linie < 0 || coloana < 0 || linie >= Linii || coloana >= Coloane)
                    throw new ArgumentOutOfRangeException();
                return data[linie, coloana];
            }
            set
            {
                if (linie < 0 || coloana < 0 || linie > Linii || coloana > Coloane)
                    throw new ArgumentOutOfRangeException();
                data[linie, coloana] = value;
            }
        }

        public void RandomInit(int min, int max)
        {
            Random rnd = new Random(0);
            for (int i = 0; i < Linii; i++)
            {
                for (int j = 0; j < Coloane; j++)
                {
                    this[i, j] = rnd.Next(min, max + 1);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Linii; i++)
            {
                for (int j = 0; j < Coloane; j++)
                {
                    sb.AppendFormat("{0,4}", this[i, j]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        public static Matrice operator *(Matrice m1, Matrice m2)
        {
            if (m1.Coloane != m2.Linii)
            {
                throw new InvalidOperationException("Numarul de coloane a operandului din stanga nu este egal cu numarul de linii a opeandrului din dreapta");
            }
            Matrice result = new Matrice(m1.Linii, m2.Coloane);

            for (int i = 0; i < m1.Linii; i++)
            {
                for (int j = 0; j < m2.Coloane; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < m1.Coloane; k++)
                    {
                        suma += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = suma;
                }
            }
            return result;

        }
        public static Matrice operator +(Matrice m1, Matrice m2)
        {
            //if (m1.Coloane != m2.Linii)
            //{
            //    throw new InvalidOperationException("Numarul de coloane a operandului din stanga nu este egal cu numarul de linii a opeandrului din dreapta");
            //}
            Matrice result = new Matrice(m1.Linii, m2.Coloane);

            for (int i = 0; i < m1.Linii; i++)
            {
                for (int j = 0; j < m2.Coloane; j++)
                {
                    int suma = 0;
                   
                    
                        suma += m1[i, j] +m2[i, j];
                   
                    result[i, j] = suma;
                }
            }
            return result;
        }
    }
}