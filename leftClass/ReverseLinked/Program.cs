namespace ReverseLinked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Node
    {
        public int mValue;
        public Node nextNode;
        public Node(int value) {mValue = value;}  
    }
    public class DoubleNode
    {
        public int mValue;
        public DoubleNode nextNode;
        public DoubleNode preNode;
        public DoubleNode(int value) { mValue = value;}
    }

    public class Solution
    {
        public Node ReverseLinked(Node head)//单链表的翻转
        {
            Node pre = null;
            Node next = null;
            while (head != null)
            {
                next=head.nextNode;
                head.nextNode = pre;
                pre = head;
                head=next;
            }
            return pre;
        }
        public DoubleNode ReverseDoubleLinked(DoubleNode node)
        {
            DoubleNode pre = null;
            DoubleNode next = null;
            while (node != null)
            {
                next=node.nextNode;
                node.nextNode=pre;
                pre = node;
                node.preNode = next;
                node=next; 
            }
            return pre;
        }
    }

}