using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void Add3Test()
        {
            LinkedListApp.DoubleLinkedList<int> list = new LinkedListApp.DoubleLinkedListClass<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            int count = 0;
            for (var cur = list.First; cur != null; cur = cur.Next)
                count++;
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void AddMethodTest()
        {
            LinkedListApp.DoubleLinkedList<int> list = new LinkedListApp.DoubleLinkedListClass<int>();
            list.AddLast(1);
            list.AddFirst(2);
            Assert.AreNotEqual(list.First, list.Last);
        }

        [TestMethod]
        public void ReverseTest()
        {
            LinkedListApp.DoubleLinkedList<int> list = new LinkedListApp.DoubleLinkedListClass<int>();
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);
            list.AddFirst(6);
            list.Reverse();
            Assert.AreEqual(list.First.Value,3);
            Assert.AreEqual(list.Last.Value, 6);
        }
        [TestMethod]
        public void ReverseEmptyTest()
        {
            LinkedListApp.DoubleLinkedList<int> list = new LinkedListApp.DoubleLinkedListClass<int>();
            list.Reverse();
            // no exceptions
            Assert.IsTrue(true);
        }
    }
}
