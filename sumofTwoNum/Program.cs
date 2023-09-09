namespace sumofTwoNum
{
    internal class Program
    {
        //简单题：求数组中两数之和等于target的数
        static void Main(string[] args)
        {
            int[] array = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = sumofTwo(array, target);
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
        //暴力法，得到结果后立即return来节约时间
        public static int[] sumofTwo(int[] array,int target)
        {
            for (int i = 0; i<array.Length; i++)
            {
                for (int j = i+1; j<array.Length; j++)
                {
                    if (array[i] +array[j]==target)
                        return new int[] { i,j };
                }
            }
            return null;
        }
    }
}