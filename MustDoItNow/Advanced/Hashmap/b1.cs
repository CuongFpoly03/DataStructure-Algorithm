namespace MustDoItNow.Advanced.Hashmap
{
    public class b1
    {
        // Cho một mảng các số nguyên nums và một số nguyên target, trả về chỉ số của hai số sao cho tổng của chúng bằngtarget .
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i =0; i< nums.Length; i++) {
                int complement = target - nums[i];
                if(map.ContainsKey(complement)) {
                    return new int[] {map[complement], i};
                }

                if(!map.ContainsKey(nums[i])) {
                    map[nums[i]] = i;
                }
            }
            throw new ArgumentException("no two sum solution");
        }
    }
}