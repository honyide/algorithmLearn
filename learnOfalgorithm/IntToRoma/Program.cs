using System.Text;

namespace IntToRoma
{

    //给你一个整数，将其转为罗马数字。
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public string IntToRoman(int num)
        {
            int[] nums = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] chars = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            StringBuilder sb = new StringBuilder();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                while (num>=nums[i])
                {
                    num-=nums[i];
                    sb.Append(chars[i]);
                }
            }
            return sb.ToString();
        }
    }
}