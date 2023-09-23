namespace RandomNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 0.5f;
            Console.WriteLine(new Solution().Test1(x)); 
            Console.WriteLine(new Solution().Test0(x));
            Console.WriteLine(Math.Pow(x,2));
        }
    }

    public class Solution
    {
        public double Test0(float x)
        {
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                float temp = (float)(new Random().NextDouble());
                if (temp<x)
                {
                    count++;
                }
            }
            return count/1000f;
        }

        public double Test1(float x)
        {
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(RandomNum()<x)count++;
            }
            return count/1000f;
        } 
      
        public double RandomNum()
        {
            Random random = new Random();
            return  Math.Max(random.NextDouble(),random.NextDouble());
        }
    }

}