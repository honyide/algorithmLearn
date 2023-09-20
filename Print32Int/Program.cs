namespace Print32Int
{
    //把一个整数输出为32位二进制
    internal class Program
    {
        static void Main(string[] args)
        {
             new Solution().Print32Int(1);
           Console.ReadKey();
        }
    }

    public class Solution
    {
        public void Print32Int(int num)
        {
            for(int i=31; i>=0; i--)
            {
                Console.Write((num&(1<<i)) ==0 ? '0' : '1');
            }
            Console.WriteLine();
        }
    }
}