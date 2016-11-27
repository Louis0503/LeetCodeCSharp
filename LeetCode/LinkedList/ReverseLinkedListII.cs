using System;
namespace LeetCodeTests.LeetCode.LinkedList
{
    /*
    * Reverse a linked list from position m to n. Do it in-place and in one-pass.
    * Given 1->2->3->4->5->NULL, m = 2 and n = 4,
    * return 1->4->3->2->5->NULL.
    * 
    * Note: 1 ≤ m ≤ n ≤ length of list.
    */
    public class ReverseLinkedListII
    {
        // [3,5], 1,2
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if(m >= n || head == null) {
                return head;
            }
            // create dummy head
            var dummyHead = new ListNode(0);
            dummyHead.next = head;

            // find the m-1th Node
            var startNode = FindNthNode(dummyHead, m - 1);

            // reverse the mth to nth Node
            ReverseNNodesAfterStartNode(startNode, n-m);

            return dummyHead.next;
        }

        public ListNode FindNthNode(ListNode head, int index)
        {
            var current = head;
            while(index > 0 && current.next != null) {
                index--;
                current = current.next;
            }
            return current;
        }

        private void ReverseNNodesAfterStartNode(ListNode startNode, int size)
        {
            if(startNode == null || size < 1) {
                return ;
            }
            
            var previousNode = startNode.next;
            var head = startNode.next;
            var currentNode = previousNode.next;
            var count = size;

            while((count > 0) && (currentNode != null)) {
                var tmpNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = tmpNode;
                count--;
            }
            startNode.next = previousNode;
            head.next = currentNode;
        }
    }
}
