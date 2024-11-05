public class Solution 
{
    public ListNode InsertGreatestCommonDivisors(ListNode head) 
    {
        if (head.next == null)
        {
            return head;
        }
        ListNode nextNode = head.next;
        int nextVal = head.next.val;
        ListNode additionalNode= new ListNode(GCD(head.val,nextVal), nextNode);
        head.next = additionalNode;
        InsertGreatestCommonDivisors(nextNode);
        return head;
    }

    public int GCD(int firstVal, int secondVal)
    {
        if (firstVal == 0)
            return secondVal;

        return GCD(secondVal % firstVal, firstVal);
    }
}
