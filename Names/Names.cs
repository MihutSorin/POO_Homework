using System;
using System.Collections.Generic;

namespace Names
{
    public class Names
    {
        private List<string> names;
        public Names()
        {
            names = new List<string>();
            names.Add("Sorin Daniel");
        }
        public void Add(string newname)
        {
            names.Add(newname);
        }
        public string this[int index]
        {
            get
            {
                if (index<names.Count)
                {
                    return names[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index<names.Count)
                {
                    names[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public void Print()
        {
            foreach (var n in names)
            {
                Console.WriteLine(n.ToUpper()+" ");
            }
            Console.WriteLine();
        }
    }
}
