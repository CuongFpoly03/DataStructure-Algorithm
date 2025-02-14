using System.Collections.Concurrent;

namespace MustDoItNow.Application.Dictionary
{
    public class ConcurrentDictionary
    {
        // Khi nào sử dụng:
        // Khi cần xử lý dữ liệu trong môi trường đa luồng.
        private ConcurrentDictionary<int, string> _concurrentDictionary;

        public ConcurrentDictionary()
        {
            _concurrentDictionary = new ConcurrentDictionary<int, string>();
        }

        public void AddConcurrentDictionary(int key, string value)
        {
            _concurrentDictionary.TryAdd(key, value); // add
        }

        public void RemoveConcurrentDictionary(int key)
        {
            _concurrentDictionary.TryRemove(key, out _); // remove
        }

        public void PrintConcurrentDictionary()
        {
            foreach (var item in _concurrentDictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}