namespace MustDoItNow.Advanced.Array_String
{
    public class b2
    {
        // Cho một mảng số nguyên numsvà một số nguyên val, xóa tất cả các lần xuất hiện của valin nums -place . Thứ tự của các phần tử có thể thay đổi. Sau đó trả về số phần tử numskhông bằngval .
        // Xét số phần tử numskhông bằng valbe k, để được chấp nhận, bạn cần thực hiện những điều sau:
        // Thay đổi mảng numssao cho kcác phần tử đầu tiên của numschứa các phần tử không bằng val. Các phần tử còn lại của numskhông quan trọng cũng như kích thước của nums.
        // Trở lại index
        public void RemoveElement(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            Console.WriteLine($"result: {index}");
        }
    }
}