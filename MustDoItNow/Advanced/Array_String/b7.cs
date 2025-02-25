namespace MustDoItNow.Advanced.Array_String
{
    public class b7
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            // reverse the whole array
            reverse(nums, 0, n - 1);
        }
        private void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
                Console.WriteLine($"start: {start}, end: {end}");

            }
        }
    }
}