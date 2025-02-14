namespace MustDoItNow.Application.Queue
{
    public class Example
    {
        // Khi nào sử dụng:
        // Khi cần xử lý theo thứ tự FIFO (First-In-First-Out).
        private Queue<string> _queue;
        public Example() {
            _queue = new Queue<string>();
        }

        public void AddQueue(string value) {
            _queue.Enqueue(value); // add
        }

        public void RemoveQueue() {
            _queue.Dequeue(); // xoá
        }

        public void PrintQueue() {
            foreach(var item in _queue) {
                Console.WriteLine(item);
            }
        }
    }
}