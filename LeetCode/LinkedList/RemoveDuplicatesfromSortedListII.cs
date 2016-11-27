
namespace LeetCodeTests.LeetCode.LinkedList
{
    /*
     *  For example,
     *  Given 1->2->3->3->4->4->5, return 1->2->5.
     *  Given 1->1->1->2->3, return 2->3.
     */
    public class RemoveDuplicatesfromSortedListII
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
                    // find the node don't need to remove or find null
                    var value = head.next.val;
                    var tmp = head.next.next;
                    while(tmp.next != null && tmp.next.val == value) {
                        tmp = tmp.next;
                    }
                    // delete all duplicate element
                    head.next = tmp.next;
                } else {
                    // moveToNextNode
                    head = head.next;
                }
            }

            return dummyHead.next;
        }
    }
}
