namespace MustDoItNow.Application.List_T_
{

    // Khi nào sử dụng:
    // Khi cần danh sách có thể thay đổi kích thước.
    // Khi thứ tự phần tử quan trọng.
    // Khi thường xuyên cần truy xuất phần tử theo chỉ số (O(1)).
    // Thuật toán:
    // Thêm (Add): O(1) hoặc O(n) nếu cần mở rộng mảng.
    // Xóa (Remove): O(n).
    // Tìm kiếm (Contains): O(n).
    public class ExampleList
    {
        private List<int> _ListMember;
        public ExampleList()
        {
            _ListMember = new List<int> { 1, 2, 3, 4, 5 };
        }

        public void AddListMember(int value)
        {
            _ListMember.Add(value);
        }

        public void RevemoListMember(int value)
        {
            _ListMember.Remove(value);
        }

        public bool ExcistListMember(int value)
        {
            return _ListMember.Contains(value);
        }

        public void PrintListMember()
        {
            foreach (var item in _ListMember)
            {
                Console.WriteLine(item);
            }
        }





    }
}