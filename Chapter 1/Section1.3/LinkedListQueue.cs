using System.Collections;

namespace Section1._3
{
    public class LinkedListQueue<T> : IEnumerable<T>
    {
        private class Node<T>
        {
            public T item;
            public Node<T> next;
        }
        private Node<T> _first;
        private Node<T> _last;
        private int _size;

        public LinkedListQueue()
        {
            _first = null;
            _last = null;
            _size = 0;
        }
        public bool IsEmpty()
        {
            return _size == 0;
        }
        public int Size()
        {
            return _size;
        }

        public void Enqueue(T item)
        {
            Node<T> oldLast = _last;
            _last = new Node<T>();
            _last.item = item;
            _last.next = null;
            if (IsEmpty())
                _first = _last;
            else
                oldLast.next = _last;
            _size++;
        }

        public T Dequeue()
        {
            T item = _first.item;
            _first = _first.next;
            _size--;
            if (IsEmpty())
                _last = null;
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LLQueueEnumerator(_first);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LLQueueEnumerator : IEnumerator<T>
        {
            private Node<T> current;
            public LLQueueEnumerator(Node<T> _firstNode)
            {
                current = _firstNode;
            }

            public T Current => current.item;
            object IEnumerator.Current => Current;
            public bool MoveNext()
            {
                if (current == null)
                {
                    return false;
                }
                else
                {
                    current = current.next;
                    return true;
                }
            }
            public void Reset()
            {
                throw new NotSupportedException("Reset is not supported");
            }
            public void Dispose() { }
        }

    }
}
