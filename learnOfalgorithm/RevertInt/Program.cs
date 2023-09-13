namespace RevertInt
{

    //给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            Console.WriteLine(new Solution().Reverse(x));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int Reverse (int x)
        {
            int res = 0;
            int ge = 0;
            while(x!=0)
            {
                if(res>int.MaxValue/10 ||res<int.MinValue/10)
                {
                    res=0; return res;

                }
                ge=x%10;
                x=x/10;
                res=res*10+ge;
            }
            return res;
        }
    }
}