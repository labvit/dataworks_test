using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    internal class DoubleLinkedListNodeClass<T> : DoubleLinkedListNode<T>
    {
        private T _Value;

        public T Value { get => _Value; set => _Value = value; }
        public DoubleLinkedListNode<T> Next { get; set; }
        public DoubleLinkedListNode<T> Prev { get ; set ; }
    }

}
