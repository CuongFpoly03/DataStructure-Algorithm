namespace MustDoItNow.Application.List_T_
{
    public class LinkList
    {
        // Khi nào sử dụng:

        // Khi cần thêm/xóa phần tử ở giữa danh sách nhanh chóng.
        // Khi không cần truy cập theo chỉ số (O(n)).
        // Thuật toán:

        // Thêm (AddFirst / AddLast): O(1).
        // Xóa (Remove): O(1) nếu có node, O(n) nếu tìm node.
        private LinkedList<string> _linkList;
        public LinkList()
        {
            _linkList = new LinkedList<string>();
        }

        public void AddLinkListLast(string value)
        {
            _linkList.AddLast(value);
        }
        public void AddLinkListFirst(string value)
        {
            _linkList.AddFirst(value);
        }

        public void RemoveLinkListLast(string value)
        {
            _linkList.Remove(value);
        }

        public void PrintLinkList()
        {
            foreach (var item in _linkList)
            {
                Console.WriteLine(item);
            }
        }




    }
}