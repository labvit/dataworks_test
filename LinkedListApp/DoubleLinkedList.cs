using System;

namespace LinkedListApp
{
    public interface DoubleLinkedList<T>
    {
        DoubleLinkedListNode<T> First { get;  }
        DoubleLinkedListNode<T> Last { get; }

        void AddLast(T value);

        void AddFirst(T value);
        void Reverse();
    }
}
