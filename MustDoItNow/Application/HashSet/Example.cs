namespace MustDoItNow.Application.HashSet
{
    public class Example
    {
        // Khi nào sử dụng:

        // Khi cần danh sách không có phần tử trùng lặp.
        // Khi cần tìm kiếm nhanh (O(1)).
        private HashSet<string> _hashSet;
        public Example() {
            _hashSet = new HashSet<string>();
        }
        
        public void AddHashSet(string value) {
            _hashSet.Add(value);
        }
        
        public void RemoveHashSet(string value) {
            _hashSet.Remove(value);
        }

        public void PrintHashset() {
            foreach(var item in _hashSet) {
                Console.WriteLine(item);
            }
        }
    }

}