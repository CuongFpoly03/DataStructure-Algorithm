namespace MustDoItNow.Application.Queue
{
    public class PriorityQueue
    {
        // Khi nào sử dụng:
        // Khi cần xử lý theo mức độ ưu tiên.
        private PriorityQueue<string, int> _queue;
        public PriorityQueue() {
            _queue = new PriorityQueue<string, int>();
        }

        public void AddQueue(string value, int priority) {
            _queue.Enqueue(value, priority);
        }

        public void RemoveQueue() {
            _queue.Dequeue();
        }

        public void PrintQueue() {
            foreach(var item in _queue.Dequeue()) {
                Console.WriteLine(item);
            }
        }
    }
}