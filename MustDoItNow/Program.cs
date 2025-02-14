
using MustDoItNow.Application.HashSet;

class Program {
    static void Main() {
       SortedSet sortedSet = new SortedSet();
       sortedSet.AddSortedSet(2);
       sortedSet.AddSortedSet(1);
       sortedSet.AddSortedSet(3);
       sortedSet.PrintSortedSet();
    }
}