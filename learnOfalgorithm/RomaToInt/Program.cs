namespace RomaToInt
{
    //罗马数字转整数
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

public class Solution
    {
    int romanToInt(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };
            int res = 0;
            for(int i=0;i<s.Length;i++)
            {  
                if(i<s.Length-1 && dic[s[i]] < dic[s[i + 1]])
                {
                    res -= dic[s[i]];
                }
                else
                {
                    res += dic[s[i]];
                }
            }
            return res;
        }
    };
}