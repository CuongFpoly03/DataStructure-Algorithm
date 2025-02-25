namespace MustDoItNow.Advanced.TwoPointers
{
    public class b1
    {
        public bool IsPalindrome(string s)
        {
            string cleanString = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
            Console.WriteLine($"haha {cleanString}");
            string compare = new string(cleanString.Reverse().ToArray());
            bool result = cleanString == compare;
            Console.WriteLine($"result: {result}");
            return result;
        }
    }
}