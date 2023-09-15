namespace MaxAreaOfVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(new Solution().MaxArea(ints));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length-1;
            int area = 0;
            while (left < right)
            {
                int tempArea = (right-left)*(int)MathF.Min(height[right], height[left]);
                if (tempArea > area) { area = tempArea; }
                if (height[left] <height[right]) { left++; }
                else { right--; }
            }

            return area;
        }
    }
}