namespace Atoi
{
    //请你来实现一个 myAtoi(string s) 函数，使其能将字符串转换成一个 32 位有符号整数（类似 C/C++ 中的 atoi 函数）。
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "-91283472332";
            Console.WriteLine(new Solution().MyAtoi(s));
        }
    }
    public class Solution
    {
        public int MyAtoi(string s)
        {
            if(s.Length == 0) return 0;
            int index = 0;
            int symbol=1;
            int res = 0;
            while (s[index]==' '&& index<s.Length)
            {
                index++;
                if (index==s.Length) return 0;

            }

            if (s[index] == '-')
            {
                symbol=-1;
                index++;
            }else if (s[index] == '+')
            {
                symbol = 1;
                index++;
            }

            while(index<s.Length)
            {

                if (s[index]> '9' || s[index]<'0')
                {
                    return res;
                }
                if(symbol>0 &&(res >int.MaxValue/10||(res*10>=int.MaxValue-(s[index]-'0')))) {   return int.MaxValue; }
                if (symbol<0 &&(res <int.MinValue/10||(res*10<=int.MinValue+(s[index]-'0')))) {   return int.MinValue; }
                res=res*10+ (s[index]-'0')*symbol;
                index++;
            }
            return res;
        }
    }
}