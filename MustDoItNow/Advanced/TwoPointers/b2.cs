namespace MustDoItNow.Advanced.TwoPointers
{
    public class b2
    {
        // Quy trình: Input: s = "abc", t = "ahbgdc"
        // So sánh a với a (trùng) → i = 1, j = 1
        // So sánh b với h (không trùng) → j = 2
        // So sánh b với b (trùng) → i = 2, j = 3
        // So sánh c với g (không trùng) → j = 4
        // So sánh c với d (không trùng) → j = 5
        // So sánh c với c (trùng) → i = 3
        // Kết quả: i == s.Length → 3 == 3 → true
        public bool IsSubSequence(string s, string t)
        {
            Console.WriteLine($"s: {s.Length}, t: {t.Length}");
            int i = 0;
            int j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            var result = i == s.Length;
            var result2 = j == t.Length;
            Console.WriteLine($"result cuongcute: {result}");
            Console.WriteLine($"result cuoncute2: {result2}");
            return result;
        }
    }
}