namespace IsValid
{
    internal class Program
    {

        //给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsValid("()"));
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                }
                else
                {
                    if ((c==')' && stack.Peek()=='(')||(c==']' && stack.Peek()=='[')||(c=='}' && stack.Peek()=='{'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push((char)c);
                    }
                }
            }

            if(stack.Count == 0)return true; else return false;
        }
    }
}