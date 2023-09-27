namespace SimpleDataStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Node<T>
    {
        public T Value;
        public Node<T> NodeNext;
        public Node(T value)
        {
            Value = value;
            NodeNext=null;
        }
    }
    public class Queue<T>//单链表实现队列
    {
        Node<T> head;
        Node<T> tail;
        private int size;
        private Queue()
        {
            head=null;
            tail=null;
            size=0;
        }


        public bool IsEmpty()
        {
            return size==0;
        }

        public void Offer(T value) 
        {
        Node<T> temp=new Node<T>(value);
            if(size==0)
            {
                head=temp;
                tail=temp;
            }
            else
            {
                tail.NodeNext=temp;
                tail=temp;
            }

            size++;
        }

        public T Poll()
        {
            T ans;
            if (head!=null)
            {
                ans=head.Value;
                head=head.NodeNext;
                size--;
            }
            else
            {
                tail=null;
                ans=default(T);
            }
            return ans;

        }

        public T Peek()
        {
            T ans=default(T);
            if (head!=null)
            {
                ans=head.Value;
            }
            return ans;
        }

    }

    public class Stack<T>//单链表实现栈
    {
        public Node<T> head;
        private int size;
        public Stack()
        {
            head=null;
            size=0;
        }

        public bool IsEmpty() { return size==0; }
        public void Push(T value)
        {
            Node<T> temp=new Node<T>(value);
            if (head==null)
            {
                head=temp;
            }
            else
            {
                temp.NodeNext=head;
                head=temp;
            }

            size++;

        }
        public T Pop()
        {
            T ans=default(T);
            if (head!=null)
            {
                ans=head.Value;
                head=head.NodeNext;
                size--;
            }
            return ans;
        }
        public T Peek()
        {
            return head==null?head.Value:default(T);
        }
    }

    public class DNode<T>
    {
        public T value;
        DNode<T> pre;
        DNode<T> next;
        DNode(T value)
        {
            this.value=value;
            next=null;
            pre=null;
        }

        public class DQueue<T> //使用双向链表实现双端队列
        {
            public DNode<T> head;
            public DNode<T> tail;
            public T Value;
            public int size = 0;
            DQueue(T value)
            {
                Value=value;
                head=null;
                tail=null;
            }

            public bool IsEmpty()
            {
                return size==0;
            }

            public void PushHead(T value)
            {
                DNode<T> temp=new DNode<T>(value);
                if (head==null)
                {
                    head=temp;
                    tail=temp;
                }
                else
                {
                    temp.next=head;
                    head.pre=temp;
                    head=temp; 
                }
                size++;
            }
            public void PushTail(T Value)
            {
                DNode<T> temp = new DNode<T>(Value);
                if (tail==null)
                {
                    head=temp;
                    tail=temp;
                }
                else
                {
                    tail.next=temp;
                    temp.pre=tail;
                    tail=temp;
                }
                size++;
            }

            public T PopHead()
            {
                T ans=default(T);
                if (head==null)
                {
                    return ans;
                }
                size--;
                ans=head.value;
                if(head==tail)
                {
                    head=null;
                    tail=null;
                }
                else
                {
                    head=head.next;
                    head.pre=null;
                }
                return ans;

            }

            public T PopTail()
            {
                T ans=default(T);
                if (tail==null)
                {
                    return ans;
                }
                size--;
                ans=head.value;
                if (head==tail)
                {
                    head=null;
                    tail=null;
                }
                else
                {
                    tail=tail.pre;
                    tail.next=null;
                }
                return ans;
            }

        }


    }



}