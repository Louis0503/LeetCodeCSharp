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
            var dummyHead = new ListNode(0);
            dummyHead.next = head;

            //Find the m-1th Node
            var startNode = FindNthNode(dummyHead, m - 1);

            //reverse the mth to nth Node
            ReverseNNodes(startNode, n-m);
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

        public void ReverseNNodes(ListNode startNode, int size)
        {
            if(startNode == null || size < 1) {
                return ;
            }
            var previousNode = startNode;
            var currentNode = previousNode.next;
            var count = size;
            while(count > 0) {
                ReverseNode(previousNode, currentNode);
                count--;
            }
        }
        // A(previousNode)->B(currentNode)->C->D->E
        // ==> B(previousNode)->A C(currentNode)->D->E
        // ==> C(previousNode)->B->A D(currentNode)->E
        public void ReverseNode(ListNode previousNode, ListNode currentNode)
        {
            if(currentNode != null) {
                var tmpNode = currentNode.next; // C
                currentNode.next = previousNode; // B->A
                previousNode = currentNode; //B
                currentNode = tmpNode;//C
            }
        }
    }
}
