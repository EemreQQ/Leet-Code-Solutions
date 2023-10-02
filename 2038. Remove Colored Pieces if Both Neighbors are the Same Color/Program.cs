public class Solution
{
    public bool WinnerOfGame(string colors)
    {
        var A = 0; var B = 0;

        List<int> list = new List<int>();
        list.Add(A);
        list.Add(B);
        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i] == 'A')
            {
                B = 0;
                A++;
                if (A > 2)
                    list[0] += A;
            }
            else
            {
                A = 0;
                B++;
                if (B > 2)
                    list[1] += B;
            }
        }
        for (; ; )
        {
            if (list[0] > 2) list[0] -= 1;
            else return false;
            if (list[1] > 2) list[1] -= 1;
            else return true;
        }
    }
}