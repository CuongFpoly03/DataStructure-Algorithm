using MustDoItNow.Advanced.Hashmap;

class Program
{
  static void Main()
  {
    b2 b2 = new b2();
    string one = "lephucuongg";
    string two = "ellephucuong";
    bool result = b2.CanconStruct(one, two);
    Console.WriteLine($"result: {result}");
  }
}