namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsPalindrome(121));
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            int _x = x;
            bool isResult=false;
            if (x<0) return isResult;
            if (x/10==0) { isResult=true; return isResult; }
            int result = 0;
            while(x!=0)
            {
                int single = x%10;
                x /=10;
                result=result*10 + single;

            }
            if (result==_x) isResult=  true;
            return isResult;
        }
    }
}