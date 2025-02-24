namespace MustDoItNow.Advanced.Array_String
{
    public class b1
    {
        // Bạn được cung cấp hai mảng số nguyên nums1 và nums2, được sắp xếp theo thứ tự không giảm và hai số nguyên m và n, biểu diễn số phần tử trong nums1và nums2tương ứng.
        // Gộp nums1 và nums2 tạo thành một mảng duy nhất được sắp xếp theo thứ tự không giảm dần .
        // Mảng được sắp xếp cuối cùng không nên được trả về bởi hàm, mà thay vào đó được lưu trữ bên trong mảngnums1 . Để phù hợp với điều này, nums1có độ dài là m + n, trong đó mcác phần tử đầu tiên biểu thị các phần tử cần được hợp nhất và ncác phần tử cuối cùng được đặt thành 0và nên bị bỏ qua. nums2có độ dài là n.
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

            while (j > 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }

            foreach (var item in nums1)
            {
                Console.WriteLine($"result: {item}");
            }
        }
    }
}