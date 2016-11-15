
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
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }

        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if(m >= n || head == null) {
                return head;
            }

            //Find the m-1 Node
            
            //reverse the mth to nth Node
                return null;
        }

        private bool ReverseNNodeAfterThisNode(ListNode thisNode, int size)
        {
            if(thisNode == null || size < 1) {
                return true;
            }
            var previousNode = thisNode;
            var count = size;
            while(count > 1) {
                var currentNode = previousNode.next;
                var tmpNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = tmpNode;
                count--;
            }
            return true;
        }
    }
}
