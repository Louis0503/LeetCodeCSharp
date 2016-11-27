
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
                ReverseNode(ref previousNode,ref  currentNode);
            }
            return previousNode;
        }
        // A(previousNode)->B(currentNode)->C->D->E
        // ==> B(previousNode)->A C(currentNode)->D->E
        // ==> C(previousNode)->B->A D(currentNode)->E
        private void ReverseNode(ref ListNode previousNode, ref ListNode currentNode)
        {
            var tmpNode = currentNode.next; // C
            currentNode.next = previousNode; // B->A
            previousNode = currentNode; //B
            currentNode = tmpNode;//C
        }
    }
}
