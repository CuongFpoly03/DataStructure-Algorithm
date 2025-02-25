namespace MustDoItNow.Advanced.Hashmap
{
    public class b2
    {
        // Cho hai chuỗi ransomNotevà magazine, trả về truenếu ransomNotecó thể được xây dựng bằng cách sử dụng các chữ cái từ magazinevà falsenếu không .
        // Mỗi chữ cái trong magazinechỉ có thể được sử dụng một lần trong ransomNote.
        public bool CanconStruct(string ransomNote, string magaZine)
        {
            if (ransomNote.Length > magaZine.Length)
            {
                bool result = false;
                return result;
            }
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char m in magaZine)
            {
                if (!map.ContainsKey(m))
                {
                    map[m] = 1;
                }
                else
                {
                    map[m]++;
                }
            }
            foreach (char r in ransomNote)
            {
                if (!map.ContainsKey(r) || map[r] == 0)
                {
                    bool result = false;
                    return result;
                }
                map[r]--;
            }
            bool results = true;
            return results;
        }
    }
}