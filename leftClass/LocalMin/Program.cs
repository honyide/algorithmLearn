namespace LocalMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            for (int i = 0; i<30; i++)
            {
                int[] temp = solution.RandomArray(20, 20);
                int[] copy = solution.CopyArray(temp);
                Console.WriteLine(solution.Test(temp, solution.LocalMin(temp)));
                if (!solution.Test(temp, solution.LocalMin(temp)))
                {
                    foreach (int n in copy)
                    {
                        Console.Write(n+" ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }

    public class Solution
    {
        public int LocalMin(int[] a)
        {
            int L = 0;
            int R = a.Length-1;
            int mid = 0;
            if (a == null ||a.Length==0)
            {
                return -1;
            }
            int len = a.Length;
            if (len==1)
            {
                return 0;
            }
            if (a[0]<a[1]) return 0;
            if (a[len-1]<a[len-2]) return len-1;
            while (L<R-1)
            {
                mid = (L+R)/2;

                if (a[mid]<a[mid-1] &&a[mid]<a[mid+1])
                {
                    return mid;
                }

                if (a[mid]<a[mid-1])
                {
                    L = mid+1;
                    continue;
                }
                else
                {
                    R = mid-1;
                    continue;
                }
            }
            return a[L]<a[R] ? L : R;

        }

        public int[] RandomArray(int mLen,int mValue)
        {
            int len=(int)(new Random().NextDouble()*mLen);
            int[] a = new int[len]; 
            if (len>0)
            {
                a[0]=(int)(new Random().NextDouble()*mValue);
                for(int i=1; i<len; i++)
                {
                    do
                    {
                        a[i]=(int)(new Random().NextDouble()*mValue);
                    } while (a[i]==a[i-1]);
                }
            }
            return a;

        }
        public bool Test(int[] a,int minIndex)
        {
            if(a.Length==0){
                return minIndex==-1;
            }
            bool L= minIndex-1>0? a[minIndex-1]>a[minIndex] : true;
            bool R = minIndex+1<a.Length ? a[minIndex+1]>a[minIndex] : true;
            return L&&R;
        }
        public int[] CopyArray(int[] a)
        {
            int[] ints = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                ints[i] = a[i];
            }
            return ints;
        }
    }

   
}