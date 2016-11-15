using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

 // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            this.val = x;
        }
    }
 
    public class _19_Remove_Nth_Node_From_End_of_List
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int length = CountTheLengthOfList(head);
            return RemoveTheNthFromHead(head, length - n);
        }
        #region Help Methods

        private int CountTheLengthOfList(ListNode head)
        {
            int count = 0;
            ListNode tmpNode = head;
            while (tmpNode != null) {
                count++;
                tmpNode = tmpNode.next;
            }
            return count;
        }

        private ListNode RemoveTheNthFromHead(ListNode head, int n)
        {
            int count = 0;
            ListNode frontNode = new ListNode(0);
            frontNode.next = head;
            ListNode tmpNode = frontNode;
            while (count < n){
                count++;
                tmpNode = tmpNode.next;
            }
            tmpNode.next = tmpNode.next.next;
            return frontNode.next;
        }
        #endregion
    }
}

