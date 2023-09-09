namespace maxLenOfchildStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcabcbb";
            Solution solution = new Solution();
            Console.WriteLine(solution.LengthOfmaxChildstr(s));

        }
    }

    //求字符串s的无重复字符的最大字串长度
    public class Solution
    {
        //使用暴力法解决，两层for循环，且使用list类开销较大
        public int LengthOfmaxChildstr( string s)
        {
            int maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                List<char> list = new List<char>();
                for(int j=i;j < s.Length; j++)
                {
                    if (list.Contains(s[j])==false)
                    {
                        list.Add(s[j]);
                        if (list.Count > maxLength) maxLength = list.Count;
                    }
                    else break;
                }
            }
            return maxLength;
        }
    }
}