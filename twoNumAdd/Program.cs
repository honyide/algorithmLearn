namespace twoNumAdd
{
    //两数相加
    //给定两个 非空链表 l1和 l2 来代表两个非负整数。数字最高位位于链表开始位置。它们的每个节点只存储一位数字。将这两数相加会返回一个新的链表。

    //可以假设除了数字 0 之外，这两个数字都不会以零开头 l1 = [7,2,4,3], l2 = [5,6,4]
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1=new ListNode(7,new ListNode(2,new ListNode(4,new ListNode(3))));
            ListNode l2=new ListNode(5,new ListNode(6,new ListNode(4)));
            Solution solution = new Solution();
            ListNode result= solution.addTwoNum(l1,l2);
            while(result!=null)
            {
                Console.WriteLine(result.val);
                result=result.next;
            }
            Console.ReadKey();
        }
    }
    //链表类，用于存储两个数
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0,ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {

        //暴力法
        public ListNode addTwoNum(ListNode l1,ListNode l2) 
        {
            ListNode result = null;
            ListNode root = null;
            int ten = 0;
        while (l1 != null || l2!=null ||ten!=0)
            {
                int sum = 0;
                sum+=ten;
                if (l1!=null)
                {
                    sum+= l1.val;
                    l1=l1.next;
                }
                if (l2!=null)
                {
                    sum+= l2.val;
                    l2=l2.next;
                }
                 ten=sum/10;
                sum-=ten*10;
                ListNode newnode = new ListNode(sum);
                if (root==null)
                {
                    root = newnode;
                    result=newnode;
                }
                else
                {
                    result.next=newnode;
                    result=newnode;
                }
                

                
            }

            return root;

        }
    }
}