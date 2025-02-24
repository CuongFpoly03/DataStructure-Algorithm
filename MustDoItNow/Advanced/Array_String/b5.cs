namespace MustDoItNow.Advanced.Array_String
{
    public class b5
    {
        public int MajorityElement(int[] nums)
        {
            // Mảng: [2, 10, 10, 2, 10, 10, 10]
            // Bước 1: candidate = 2, count = 1
            // Bước 2: So sánh 10 với 2 → khác nhau → count = 0 → Đổi candidate thành 10
            // Bước 3: 10 == 10 → count = 1
            // Bước 4: 2 != 10 → count = 0 → Đổi candidate thành 2
            // Bước 5: 10 != 2 → count = 0 → Đổi candidate thành 10
            // Bước 6: 10 == 10 → count = 1
            // Bước 7: 10 == 10 → count = 2
            int candidate = nums[0];
            int count = 0;
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }
            Console.WriteLine($"count: {count}");
            Console.WriteLine($"candidate: {candidate}");
            return candidate;
        }
    }
}