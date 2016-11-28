using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.LinkedList
{
    /*
    * Given a linked list and a value x, partition it such that all nodes
    * less than x come before nodes greater than or equal to x.
    * You should preserve the original relative order of the nodes
    * in each of the two partitions.
    *
    * Given 1->4->3->2->5->2 and x = 3,
    * return 1->2->2->4->3->5.
    */
    class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            // solution 1:
            // one point to  the node which value is smaller than x
            // travel the list , find the node which value is smaller than x
            // cut the node and link to the node
            // solution 2:
            // travel the linked list and seprate to two different linked list
        }
    }
}
