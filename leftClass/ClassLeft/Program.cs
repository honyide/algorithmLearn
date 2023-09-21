namespace SimpleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution=new Solution();
            solution.Show(solution.BubbleSort(new int[] { 1,5,6,9,8,3,4}));
            solution.Show(solution.SelectSort(new int[] { 1,5,6,9,8,3,4}));
            solution.Show(solution.InsertSort(new int[] { 1,5,6,9,8,3,4}));
        }
    }
    public class Solution
    {
        public void Show(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write(i);
            }
            Console.WriteLine();

        }

        public void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        //选择排序
        public int[] SelectSort(int[] a)
        {
           
            if(a==null ||  a.Length<2)
            {
                return a;
            }
            for(int i = 0; i < a.Length; i++)
            {
                int minValueIndex = i;
                for(int j = i+1; j < a.Length; j++)
                {
                    minValueIndex=a[j]<a[minValueIndex] ? j : minValueIndex;
                }
                swap(a,i,minValueIndex);
            }
            return a;
        }

       //冒泡排序
       public int[] BubbleSort(int[] a)
        {
            if(a==null || a.Length<2)
            {
                return a;
            }
            for(int i=a.Length-1; i>=0; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    if (a[j]<a[j-1]) swap(a,j,j-1);
                }
            }
            return a;
        }

        public int[] InsertSort(int[] a)
        {
            if (a==null ||  a.Length<2)
            {
                return a;
            }
            for (int end = 1; end<a.Length; end++)
            {
                int NewNumIndex = end;
                while(end-1>=0 &&  a[NewNumIndex-1]>a[NewNumIndex])
                {
                    swap(a,NewNumIndex-1,NewNumIndex);
                    NewNumIndex--;

                }
            }
            return a;
        }
    }
}