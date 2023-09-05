namespace maxChildArray
{
    internal class Program
    {
        //最大子数组

        static void Main(string[] args)
        {
             int[] array = { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
             int[] change = new int[array.Length-1];//存储数组中相邻数据的差值
            for (int i = 1; i < array.Length; i++)
            {
                change[i-1]= array[i]-array[i-1];
            }
            foreach (int i in change)
            {
                Console.WriteLine(i);
            }
            //result lastResult = simpleMethod(change);
            result lastResult = divideMethod(change,0,change.Length-1);

            Console.WriteLine(lastResult.indexMin+" "+lastResult.indexMax+" "+lastResult.total);
            Console.ReadKey();
           
        }

        public struct result
        {
            public int indexMin;
            public int indexMax;
            public int total;
        }

        //暴力法：用三重for循环枚举出所有子数组并比较大小
        public static result simpleMethod(int[] change)
        {
            int templeTotal = 0;
            result result1;
            result1.total = 0;
            result1.indexMin = 0;
            result1.indexMax = 0;
            for (int i = 0; i < change.Length; i++)
            {
                for(int j = i;j< change.Length; j++)
                {
                    for(int index=i;index<j+1; index++)
                    {
                        templeTotal += change[index];
                        if (templeTotal>result1.total)
                        {
                            result1.total = templeTotal;
                            result1.indexMin = i;
                            result1.indexMax = index;
                        }
                    }
                    templeTotal = 0;
                }
            }
            return result1;
        }


        //使用分治法解决，把change数组分为两部分 [low,mid],[mid+1,high]
        ////此时结果有三种情况： 1. indexMin和indexMax都在左边这部分 2. indexMin和indexMax都在左边这部分 3. indexMin在左边这部分indexMax在右边部分
        //1、2 这两种情况的处理方法相同，继续在相应区间求出最大子数组即可
        //情况3表明最大子数组是左右两区间的最大子数组的和，而此时左右两边的最大子数组为[indexMin, mid],[mid+1,high]

        public static result divideMethod(int[] change,int indexMin,int indexMax)
        {
            int mid=(indexMin+indexMax)/2;
            result result1;
            result result2;
            result result3;
            result3.total= 0;
            result3.indexMax = 0;
            result3.indexMin=0;
            if (indexMin==indexMax)
            {
                result1.total=change[indexMin];
                result1.indexMin = indexMin;    
                result1.indexMax = indexMax;
                return result1;
            }
            result1 = divideMethod(change,indexMin,mid);
            result2 =divideMethod(change,mid+1,indexMax);
            int templeTotalOne = change[mid];
            int temp = 0;
            result3.indexMin=mid;

            for (int i=mid;i>=indexMin;i--)
            {
                temp+=change[i];
                if (temp>templeTotalOne)
                {
                    templeTotalOne=temp;
                    result3.indexMin = i;
                }
            }
            int templeTotalTwo = change[mid+1];
            temp=0;
            result3.indexMax=mid+1;
            for (int j = mid+1; j<=indexMax; j++)
            {
                 temp+= change[j];
                if (temp>templeTotalTwo)
                {
                    templeTotalTwo=temp ;
                    result3.indexMax = j;   
                }
            }
            result3.total=templeTotalOne+templeTotalTwo;
            if(result1.total>result2.total && result1.total>result3.total)
            {
                return result1;
            }
            else if (result2.total>result1.total && result2.total>result3.total)
            {
                return result2;
            }
            else
            {
                return result3;

            }


        }

    }
}