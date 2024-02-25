namespace _692._Top_K_Frequent_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] s = { "love", "love", "I", "leetcode", "coding", "I" };
            // I - 2
            // love - 2
            // coding - 1 (alfabetik önce geliyor)
            Console.WriteLine(string.Join("",solution.TopKFrequent(s, 3)) );
        }
    }
    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            // En çok tekrar eden K adet kelime dönecek
            Dictionary<string, int> d = new Dictionary<string, int>();

            foreach (string item in words)
            {
                if (d.Keys.Contains(item)) d[item]++;
                else d.Add(item, 1);
            }
            var values = d.OrderBy(x => x.Key);
            IList<string> final = new List<string>();
            var counter = 0;
            foreach (KeyValuePair<string,int> item in values.OrderByDescending(x => x.Value))
            {
                final.Add(item.Key);
                counter++;
                if (counter == k) break;
            }
            return final;
    }
    }
}