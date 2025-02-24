namespace MustDoItNow.Advanced.Array_String
{
    public class b3
    {
        public int RemoveDuplicate(int[] nums)
        {
            // Cho một mảng số nguyên numsđược sắp xếp theo thứ tự không giảm , hãy xóa các phần tử trùng lặp tại chỗ sao cho mỗi phần tử duy nhất chỉ xuất hiện một lần . Thứ tự tương đối của các phần tử phải được giữ nguyên . Sau đó trả về số phần tử duy nhất trongnums .
            // Hãy xem xét số lượng phần tử duy nhất của numsto be k, để được chấp nhận, bạn cần thực hiện những điều sau:
            // Thay đổi mảng numssao cho kcác phần tử đầu tiên của numschứa các phần tử duy nhất theo thứ tự numsban đầu. Các phần tử còn lại của numskhông quan trọng cũng như kích thước của nums.
            // Trở lại k.
            // nums = [1, 1, 2, 3, 3]
            // Lặp qua mảng:
            // - i = 1: nums[1] = 1, nums[0] = 1 ⇒ Giống nhau (Bỏ qua)
            // - i = 2: nums[2] = 2, nums[1] = 1 ⇒ Khác nhau (Lưu lại)
            // - i = 3: nums[3] = 3, nums[2] = 2 ⇒ Khác nhau (Lưu lại)
            // - i = 4: nums[4] = 3, nums[3] = 3 ⇒ Giống nhau (Bỏ qua)

            if (nums.Length == 0) return 0; 
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            Console.WriteLine($"result: {k}");
            return k;
        }
    }
}