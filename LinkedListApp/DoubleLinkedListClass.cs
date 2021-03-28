using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class DoubleLinkedListClass<T> : DoubleLinkedList<T>
    {
        DoubleLinkedListNode<T> _First = null;
        DoubleLinkedListNode<T> _Last = null;

        public DoubleLinkedListNode<T> First { get => _First; private set => _First = value; }
        public DoubleLinkedListNode<T> Last { get => _Last; private set => _Last = value; }

        public void AddFirst(T value)
        {
            if (_First != null)
            {
                _First.Prev = new DoubleLinkedListNodeClass<T> { Value = value, Next = _First};
                _First = _First.Prev;
            }
            else // add first element
            {
                _First = new DoubleLinkedListNodeClass<T> { Value = value };
                _Last = _First ;
            }
        }

        public void AddLast(T value)
        {
            if(_Last != null)
            {
                _Last.Next = new DoubleLinkedListNodeClass<T> { Value = value , Prev = _Last};
                _Last = _Last.Next;
            }
            else // add first element
            {
                _Last = new DoubleLinkedListNodeClass<T> { Value = value };
                _First = _Last ;
            }
        }


        public void Reverse()
        {
            var current = _First;
            while (current != null)
            {
                var temp = current.Next;
                current.Next= current.Prev;
                current.Prev= temp;
                current = temp;
            }
            var tempFirst = _Last;
            _Last = _First;
            _First = tempFirst;
        }
    }
}
