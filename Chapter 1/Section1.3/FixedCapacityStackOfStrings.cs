using System.Diagnostics.CodeAnalysis;

namespace Section1._3
{
    internal class FixedCapacityStackOfStrings<T>
    {
        private T[] _elements;
        private int _N;


        public FixedCapacityStackOfStrings(int max)
        {
            _N = 0;
            _elements = new T[max];

        }

        public void Push(T item)
        {
            _elements[_N++] = item;
        }

        public void PushStrings(String[] StringArray)
        {
           
                foreach (String str in StringArray)
                {
                    Push((T)(object)(str));
                }
            
        }

        public T Pop()
        {
            return _elements[--_N];
        }

        public bool isEmpty()
        {
            return _N == 0;
        }

        public bool isFull()
        {
            return _N == _elements.Length;
        }
    }
}
