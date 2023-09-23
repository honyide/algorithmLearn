namespace RandomMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {

        //生成对数器(生成随机样本自己比对)
        public int[] LengthRandomValueRandom(int maxLen, int maxValue)
        {
            int length= (int)(new Random().NextDouble()*maxLen+1);
            int[] ints = new int[length];
            for (int i = 0; i < length; i++)
            {
                ints[i]=(int)(new Random().NextDouble()*maxValue);
            }
            return ints;
        }
        //用于备份错误的数据，方便debug
        public int[] CopyArray(int[] a)
        {
            int[] ints = new int[a.Length]; 
            for (int i = 0;i < a.Length; i++)
            {
                ints[i] = a[i];
            }
            return ints;
        }

    }
}