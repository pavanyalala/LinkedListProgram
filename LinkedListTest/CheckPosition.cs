using LinkedList;
using NUnit.Framework;
using System.Collections.Generic;

namespace LinkedListTest
{
    public class Tests
    {
        LinkedList.List list = new LinkedList.List();
        [Test]
        public void SearchElement_WhenFound_ShouldReturnNode()
        {
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int actualNode = list.Search(30);
            Assert.AreEqual(1, actualNode);
        }
    }
}