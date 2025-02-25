namespace MustDoItNow.Advanced.Hashmap
{
    public class b3
    {
        // Cho hai chuỗi svà t, xác định xem chúng có đẳng cấu hay không .
        // Hai chuỗi svà tlà đẳng cấu nếu các ký tự trong scó thể thay thế được để có được t.
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                bool rs = false;
                return rs;
            }
            Dictionary<char, char> saveS = new Dictionary<char, char>();
            Dictionary<char, char> saveT = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];
                if (saveS.ContainsKey(sChar))
                {
                    if (saveS[sChar] != tChar)
                    {
                        bool rs = false;
                        return rs;
                    }
                }
                else
                {
                    saveS[sChar] = tChar;
                }

                if (saveT.ContainsKey(tChar))
                {
                    if (saveT[tChar] != sChar)
                    {
                        bool rs = false;
                        return rs;
                    }
                }
                else
                {
                    saveT[tChar] = sChar;
                }
            }
            bool rss = true;
            return rss;
        }
    }
}