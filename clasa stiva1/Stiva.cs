using System;

namespace clasa_stiva1
{
    class Stiva<T>
    {
        private T[] m_ItemsArray;

        private int m_Index = 0;
        public const int MAX_SIZE = 100;
        public Stiva() { m_ItemsArray = new T[MAX_SIZE]; }
        public T Pop()
        {
            if (m_Index == 0)
                throw new InvalidOperationException("Nu putem extrage un element dintr - o stiva vida.");
            return m_ItemsArray[--m_Index];
        }
        public void Push(Object item)
        {
            if (m_Index == MAX_SIZE)
                throw new StackOverflowException("Nu se poate adauga un element:stiva este plina.");

            m_ItemsArray[m_Index++] = (T)item;
        }
    }
}
