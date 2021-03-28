using System;

namespace LinkedListApp
{


    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new DoubleLinkedListClass<int>();
            list.AddFirst( 3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.Reverse();
            for(var cur = list.First; cur != null; cur = cur.Next)
              Console.WriteLine(cur.Value);
        }
    }
}
