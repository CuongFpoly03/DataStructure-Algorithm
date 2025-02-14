namespace MustDoItNow.Application.Dictionary
{
    public class SortedDictionary
    {
        // Khi nào sử dụng:
        // Khi cần dữ liệu có thứ tự theo khóa.
        // Khi cần truy xuất nhanh (O(log n)).
        private SortedDictionary<string, int> _sortedDictionary;
        public SortedDictionary() {
            _sortedDictionary = new SortedDictionary<string, int>();
        }

        public void AddSortedDictionary(string key, int value) {
            _sortedDictionary.Add(key, value);
        }

        public void PrintSortedDictionary() {
            foreach (var item in _sortedDictionary)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}