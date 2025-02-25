using MustDoItNow.Advanced.Hashmap;

class Program
{
  static void Main()
  {
    b3 b3 = new b3();
    string s = "foo";
    string t = "bar";
    bool result = b3.IsIsomorphic(s, t);
    Console.WriteLine($"result : {result}");
  }
}