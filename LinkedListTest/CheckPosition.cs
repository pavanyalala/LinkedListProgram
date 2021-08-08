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
        [Test]
        public void TestIfElement_IsInserted_OrNot()
        {
            LinkedList.List list = new LinkedList.List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int searchNode = list.Search(30);
            list.InsertAtParticularPosition(searchNode + 1, 40);
            int actualNode = list.Search(40);
            Assert.AreEqual(2, actualNode);
        }
}