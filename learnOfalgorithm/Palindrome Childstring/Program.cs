namespace Palindrome_Childstring
{
    //给你一个字符串 s，找到 s 中最长的回文子串。
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            Solution solution = new Solution();
            Console.WriteLine(solution.LongestPalindrome(s));
        }

        public class Solution
        {
            public string LongestPalindrome(string s)
            {
                int Length = 1;
                int iStart=0;
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j =i+1; j < s.Length; j++) 
                    {
                        if (isPalindrome(i,j,s))
                        {
                            int temp = j-i+1;
                            if(temp>Length)
                            {
                                Length = temp;
                                iStart = i;
                            }
                        }
                    }

                }
                return s.Substring(iStart, Length);
            }
            public bool isPalindrome(int startIndex,int endIndex,string s)
            {
                int count = 0;
                for(int i = startIndex; i < endIndex;i++)
                {
                    if (s[i] != s[endIndex-count])
                    {
                        return false;
                    }
                    count++;
                }
                return true;
            }
        }
    }
}