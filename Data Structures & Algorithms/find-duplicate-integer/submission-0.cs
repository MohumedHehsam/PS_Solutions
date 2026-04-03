public class Solution {
        public int FindDuplicate(int[] ar)
        {
            int l = ar.Length;
            for (int i = 0; i < l ; i++)
            {
                int p = Math.Abs(ar[i]);
                if (ar[p] < 0)
                    return p;
                else
                    ar[p] *= -1;
            }
            return -1;
        }
}
