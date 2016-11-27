using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeTests.LeetCode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode.LinkedList.Tests
{
    [TestClass()]
    public class ReverseLinkedListIITests
    {
        [TestMethod()]
        public void ReverseBetweenTest()
        {
            // arrange
            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);
            var node6 = new ListNode(6);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            var target = new ReverseLinkedListII();
            // act
            
            var head = target.ReverseBetween(node1, 2, 5);
            var actual1 = target.FindNthNode(head, 1);
            var actual2 = target.FindNthNode(head, 2);
            var actual3 = target.FindNthNode(head, 3);
            var actual4 = target.FindNthNode(head, 4);
            ShowAllNodes(head);
            // assert
            Assert.AreEqual(1, head.val);
            Assert.AreEqual(5, actual1.val);
            Assert.AreEqual(4, actual2.val);
            Assert.AreEqual(3, actual3.val);
            Assert.AreEqual(2, actual4.val);
        }

        private void ShowAllNodes(ListNode head)
        {
            var tmpNode = head;
            var size = 0;
            while(tmpNode != null && size < 100) {
                Console.WriteLine($"{tmpNode.val}");
                tmpNode = tmpNode.next;
                size++;
            }
        }
    }
}
