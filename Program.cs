public class Solution
{
    public string IntToRoman(int num)
    {
        Dictionary<char, int> d = new Dictionary<char, int>
        {
            {'M',1000}, {'D',500}, {'C',100},
            {'L',50}, {'X',10}, {'V',5}, {'I',1},
        };
        var s = ""; var counter = 0; var tracker = 0;
        while (num > 0)
        {
            if (num >= d.Values.ElementAt(counter))
            {
                s += d.Keys.ElementAt(counter);
                num -= d.Values.ElementAt(counter);
                tracker++;
                if (tracker > 3)
                {
                    if (s.Length >= tracker + 1 && s[s.Length - tracker - 1].ToString() == d.Keys.ElementAt(counter - 1).ToString())
                    {
                        s = s.Remove(s.Length - tracker - 1, 5);
                        s += d.Keys.ElementAt(counter).ToString() + d.Keys.ElementAt(counter - 2).ToString();
                        tracker = 0;
                    }
                    else
                    {
                        s = s.Remove((s.Length - tracker), 4);
                        s += d.Keys.ElementAt(counter).ToString() + d.Keys.ElementAt(counter - 1).ToString();
                        tracker = 0;
                    }
                }
                continue;
            }
            if (d.Values.ElementAt(counter) > num)
            {
                counter++;
                tracker = 0;
            }
        }
        return s;
    }
}