namespace MustDoItNow.Advanced.Array_String
{
    public class b4
    {
        public int RemoveDuplicates(int[] nums) {
            if(nums.Length <= 2) {
                return nums.Length;
            }
            // {1,1,1,2,2,3}
            int count = 1;
            int index = 1;
            for(int i =1; i< nums.Length; i++) {
                if (nums[i] == nums[i - 1]) {
                    nums[count] = nums[i];
                    count++;
                }else {
                    count = 1;
                }

                if(count <= 2) {
                    nums[index] = nums[i];
                    index++;
                }

            }
            Console.WriteLine($"result count: {count}");
            Console.WriteLine($"result index: {index}");
            return index;
        }
    }
}