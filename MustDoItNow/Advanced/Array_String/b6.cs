namespace MustDoItNow.Advanced.Array_String
{
    public class b6
    {
        // Phần tử	count[num]	maxCount
        // 1	{1: 1}	            maxCount = 1
        // 2	{1: 1, 2: 1}	    maxCount = 1
        // 3	{1: 1, 2: 1, 3: 1}	maxCount = 1
        // 4	{1: 1, 2: 1, 3: 1, 4: 1}	maxCount = 1
        // 5	{1: 1, 2: 1, 3: 1, 4: 1, 5: 1}	maxCount = 1
        // 6	{1: 1, 2: 1, 3: 1, 4: 1, 5: 1, 6: 1}	maxCount = 1
        // 7	{1: 1, 2: 1, 3: 1, 4: 1, 5: 1, 6: 1, 7: 1}	maxCount = 1
        // 7	{7: 2} (tăng thêm 1 lần cho 7)	maxCount = 2
        // 7	{7: 3}	maxCount = 3
        // 7	{7: 4}	maxCount = 4
        public List<int> MostFrequent(int[] nums)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            int max = 0;
            foreach (var num in nums)
            {
                count[num] = count.ContainsKey(num) ? count[num] + 1 : 1;
                max = Math.Max(max, count[num]);
            }

            List<int> result = new List<int>();
            foreach (var item in count)
            {
                if (item.Value == max)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine($"max: {max}");
            Console.WriteLine($"cac so xuat hien nhieu nhat: {string.Join(",", result)}");
            return result;
        }

    }
}