
namespace LeetCodeTests.LeetCode.LinkedList
{
    public class ReverseLinkedList
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
        public ListNode ReverseList(ListNode head)
        {
            if(head == null) {
                return null;
            }
            var previousNode = head;
            var currentNode = head.next;
            head.next = null;
            while(currentNode != null) {
                var tmpNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = tmpNode;
            }
            return previousNode;
        }
    }
}
