using System;

namespace LinkedListApp
{
    public interface DoubleLinkedListNode<T>
    {
        T Value { get; set; }
        DoubleLinkedListNode<T> Next { get; set; }
        DoubleLinkedListNode<T> Prev { get; set; }

    }
}
