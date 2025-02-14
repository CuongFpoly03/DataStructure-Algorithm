
namespace MustDoItNow.Application.HashSet
{
    public class SortedSet
    {
        // Khi nào sử dụng:
        // Khi cần danh sách không trùng lặp nhưng có thứ tự (O(log n)).
        private SortedSet<int> _sortedSet;

        public SortedSet() {    
            _sortedSet = new SortedSet<int>();
        }

        public void AddSortedSet(int value) {
            _sortedSet.Add(value);
        }

        public void PrintSortedSet() {
            foreach (var item in _sortedSet) {
                Console.WriteLine(item);
            }
        }
    }
}