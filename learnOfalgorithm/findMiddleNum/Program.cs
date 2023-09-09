namespace findMiddleNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2, 3 };
            Solution solution = new Solution();
            Console.WriteLine(solution.FindMedianSortedArrays(nums1, nums2));

        }
        //给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。
    }
    public class Solution
    {
        //暴力法解决
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();

            for(int i=0;i<nums1.Length; i++)
            {
                list.Add(nums1[i]);
            }
            for(int j=0;j<nums2.Length;j++) { list.Add(nums2[j]); }
            list.Sort();
            if (list.Count%2==0)
            {
                return (list[list.Count/2]+list[list.Count/2-1])/2.0;
            }
            else
            {
                return list[list.Count/2];

            }
        }
    }
}