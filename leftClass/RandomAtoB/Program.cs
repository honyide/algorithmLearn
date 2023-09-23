namespace RandomAtoB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints=new int[8];
            for (int i = 0; i<=10000; i++)
            {
                int temp = new Solution().RandomCtoD();
                ints[temp]++;
            }
            for(int i = 0;i<ints.Length;i++)
            {
                Console.WriteLine(i+":"+ints[i]);
            }
        }
    }

    public class Solution
    {
        //有一个返回0-5随机数的黑盒函数
        public int RandomAtoB()
        {
            return (int)(new Random().NextDouble()*5+1);
        }
        //把黑盒函数的随机数变为0/1
        public int SimplifyRandom()
        {
            int temp = 0;
            do
            {
                temp=RandomAtoB();
            } while (temp==3);
            return temp<3?0:1;
        }

        //利用简化后的黑盒把随机数变为0-7
        public int PreCtoD()
        {
            return (SimplifyRandom()<<2)+(SimplifyRandom()<<1)+(SimplifyRandom()<<0);        
        }
        //缩小随机数范围
        public int RandomCtoD()
        {
            int temp = 0;
            do
            {
                temp=PreCtoD();
            } while (temp==0);
            return temp;
        }

    }
}