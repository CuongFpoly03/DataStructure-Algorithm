namespace MustDoItNow.Application.Array
{
    public class Example
    {
        // Khi nào sử dụng:
        // Khi biết trước số phần tử.
        // Khi cần truy xuất nhanh theo chỉ số (O(1)).
        private int[] _array;
        public Example() {
            _array = new int[] { 1, 2, 3, 4, 5 };
        }

        public void AddArray(int value) {
            _array[4] = value;
        }

        public bool ExcistArray(int value) {
            return _array.Contains(value);
        }

        public void PrintArray() {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }
    }
}