using System.Text;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        }
    }
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int minLength = strs[0].Length;
            int minIndex = 0;
            int index = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length<minLength)
                {
                    minLength = strs[i].Length;
                    minIndex = i;
                }
            }
            if (minLength<=0) return "";
            while (index < minLength) 
            {
                for (int i = 0; i<strs.Length; i++)
                {
                    if (strs[i][index]!=strs[minIndex][index])
                    {
                        return sb.ToString(); 
                    }else if(i==strs.Length-1) { sb.Append(strs[i][index]); index++; }
                }
            }
           



            return sb.ToString();
        }
    }

}