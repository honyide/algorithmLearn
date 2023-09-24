using RandomMachine;


namespace HalfSearch

{

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<20; i++)
            {
                new Solution().test0();

            }
        }
    }

    public class Solution
    {
        public void test0()
        {
            int[] temp = new RandomMachine.Solution().LengthRandomValueRandom(30,50);
            Array.Sort(temp);
            int[] copy=new RandomMachine.Solution().CopyArray(temp);
            int num = 20;
            bool result=false;
            foreach (int i in temp)
            {
                if(i==num)result = true;
            }
            if(result==SimpleHalfSearch(temp,num))
            {
                Console.WriteLine("成功");
            }
            else {  
                Console.WriteLine("失败了");
                foreach (int i in copy)
                {
                    Console.Write(i);
                    Console.WriteLine();
                }
            
            }
        }
        public bool SimpleHalfSearch(int[] a, int num)
        {
            if(a.Length == 0 || a==null)return false;   
            int left=0, right=a.Length-1,mid=(left+right)/2;
            while (left <= right)
            {
                if (a[mid]<num)
                {
                    left = mid+1;
                    mid = (left+right)/2;
                }else if (a[mid]>num)
                {
                    right = mid-1;
                    mid= (right+left)/2;
                }
                else { return true; }
            }
            return false;
        }

        public int FindMinLeft(int[] a,int num)//在有序数组中找到大于等于num的最小位置
        {
            int left = 0, right = a.Length-1,mid=0;
            int answer = -1;
            while (left <= right)
            {
                mid = (mid+right)/2;
                if (a[mid]<num)
                {
                    left= mid+1;
                }
                else
                {
                    answer = mid;
                    right= mid-1;
                }
            }
            return answer;
        }
    }
}