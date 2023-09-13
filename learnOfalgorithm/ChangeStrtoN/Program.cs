using System.Text;

namespace ChangeStrtoN
{
    //将一个给定字符串 s 根据给定的行数 numRows ，以从上往下、从左到右进行 Z 字形排列。
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "paypalishiring";
            Solution solution = new Solution();
            string result=solution.Convert(s, 3);

            foreach (char c in result)
            {
                Console.Write(c);
            }
        }
    }

    public class Solution
    {
        public string Convert(string s , int numRows)
        {
            if (numRows == 1) return s;
            bool isDown = true;
            char[,] sArray=new char[numRows,s.Length];

            int i = 0;
            int j = 0;
            foreach (char c in s)
            {
                sArray[i, j]=c;
                if(isDown)
                {
                    i++;
                    if (i==numRows-1)
                    {
                       isDown = false;
                    }
                }
                else
                {
                    i--;
                    j++;
                    if (i==0)
                    {
                        isDown = true;
                    }
                }

            }

            StringBuilder sb = new StringBuilder(s.Length);
            for(int rank = 0;rank<numRows;rank++)
            {
                for(int row = 0; row<s.Length; row++)
                {
                    if (sArray[rank, row]!=0)
                    {
                        sb.Append(sArray[rank, row]);
                    }
                }
            }
            return sb.ToString();
        }
    }
}