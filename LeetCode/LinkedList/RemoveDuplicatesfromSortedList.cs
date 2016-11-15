
namespace LeetCodeTests.LeetCode.LinkedList
{
    
    public class RemoveDuplicatesfromSortedList
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            var dummyHead = new ListNode(0);
            dummyHead.next = head;
            head = dummyHead;

            while(head.next != null && head.next.next != null) {
                if(head.next.val == head.next.next.val) {
                    // removeNextNode
                    head.next = head.next.next;
                } else {
                    // moveToNextNode
                    head = head.next;
                }
            }

            return dummyHead.next;
        }
    }
}
