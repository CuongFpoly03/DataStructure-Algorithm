namespace MustDoItNow.Application.Dictionary
{
    public class Example
    {
        // Khi nào sử dụng:
        // Khi cần tìm kiếm nhanh theo khóa (O(1)).
        // Khi dữ liệu không cần sắp xếp.
        // Thuật toán:
        // Tìm kiếm (ContainsKey): O(1).
        // Thêm/Xóa (Add / Remove): O(1).
        private Dictionary<string , int> _dictionary;
        public Example() {
            _dictionary = new Dictionary<string, int>();
        }

        public void AddDictionary(string key, int value) {
            _dictionary.Add(key, value);
        }

        public void RemoveDictionary(string key) {
            _dictionary.Remove(key);
        }

        public void PrintDictionary() {
            foreach (var item in _dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}