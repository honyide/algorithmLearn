namespace RemoveNthFromEnd
{

    //给你一个链表，删除链表的倒数第 n 个结点，并且返回链表的头结点。
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode result = new Solution().RemoveNthFromEnd(new ListNode(1, null), 1);
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            } 
        }
    }



public class ListNode
 {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
     {
         this.val = val;
         this.next = next;
              }
}

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 0;
            ListNode FirstNode = head;
            while(head != null)
            {
                head = head.next;
                count++;
            }
            if(count==n)
            {
                return FirstNode.next;
            }
            head=FirstNode;
            for(int i = 0;i<count;i++)
            {
                if(i==count-n-1) 
                { 

                head.next=head.next.next;
                    break;
                }
                head = head.next;
            }
            return FirstNode;
        }
    }

}