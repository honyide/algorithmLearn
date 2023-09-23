namespace RangeSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a= { 1, 2, 3 };
            Solution solution = new Solution();
            Console.WriteLine(solution.RangeSum2(a,0,1));
        }
    }

    public class Solution
    {
        public int RangeSum1(int[] a,int start,int end)
        {
            int[,] arraySum=new int[a.Length,a.Length];
            for (int i = 0; i < a.Length; i++) 
            {
            for(int j=i; j < a.Length; j++)
                {
                    if(j==i) arraySum[i,j]= a[j];
                    else arraySum[i,j]= arraySum[i,j-1]+ a[j];
                }
            }
            return arraySum[start, end];
        }

        public int RangeSum2(int[] a,int start,int end)
        {
            int[] preSum=new int[a.Length];
            for(int i = 0;i < a.Length; i++)
            {
                if (i==0) preSum[i]= a[i];
                else preSum[i] =preSum[i-1]+ a[i];
            }
            return start==0 ? preSum[end] :preSum[end]- preSum[start];
        }

       
    }
}