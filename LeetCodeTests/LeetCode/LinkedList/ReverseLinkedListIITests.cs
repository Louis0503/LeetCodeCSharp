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
            target.ReverseBetween(node1, 2, 4);
            // assert
            var node = node1;
            while(node != null) {
                Console.WriteLine($"{node.val}");
                node = node.next;
            }
            Assert.AreEqual(1, node1.val);
        }

        [TestMethod()]
        public void FindNthNodeTest()
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
            var dummyHead = new ListNode(0);
            dummyHead.next = node1;
            var target = new ReverseLinkedListII();
            var expect = 5;
            // act
            var actual = target.FindNthNode(dummyHead, 5);
            // assert
            Assert.AreEqual(expect, actual.val);
        }

        [TestMethod()]
        public void ReverseNNodesTest()
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
            var dummyHead = new ListNode(0);
            dummyHead.next = node1;
            var target = new ReverseLinkedListII();
            // act
            ShowAllNodes(dummyHead);
            target.ReverseNNodes(dummyHead,2);
            Console.WriteLine($"11111111");
            //ShowAllNodes(dummyHead);
            Console.WriteLine($"2222222");
            var actual = target.FindNthNode(dummyHead, 1);
            //assert
            Assert.AreEqual(1, actual.val);
        }

        private void ShowAllNodes(ListNode head)
        {
            var node = head;
            while(node != null) {
                Console.WriteLine($"{node.val}");
                node = node.next;
            }
        }
    }
}
