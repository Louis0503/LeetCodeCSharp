
namespace LeetCodeTests.LeetCode.LinkedList
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
    /*
     *  For example,
     *  Given 1->1->2, return 1->2.
     *  Given 1->1->2->3->3, return 1->2->3.
     */
    public class RemoveDuplicatesfromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if(head == null) {
                return null;
            }
            var dummyHead = new ListNode(0);
            dummyHead.next = head;
            head = dummyHead;

            while(head.next != null && head.next.next != null) {
                if(head.next.val == head.next.next.val) {
                    // remove Duplicates
                    head.next = head.next.next;
                } else {
                    // move to next Node
                    head = head.next;
                }
            }
            return dummyHead.next;
        }
    }
}
