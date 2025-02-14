using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MustDoItNow.Application.Stacks
{
    public class Example
    {
        // Khi nào sử dụng:
        // Khi cần cấu trúc LIFO (Last-In-First-Out).
        // Khi dùng cho bài toán đệ quy hoặc undo/redo.
        private Stack<string> _stack;

        public Example() {
            _stack = new Stack<string>();
        }

        public void AddStack(string value) {
            _stack.Push(value); // add
        }

        public void RemoveStack() {
            _stack.Pop(); // xoá
        }


        // lấy danh sách còn tồm tại
        public string PeelStack() {
            return _stack.Peek();
        }
        public void PrintStack() {
            foreach(var item in _stack) {
                Console.WriteLine(item);
            }
        }
        
    }
}