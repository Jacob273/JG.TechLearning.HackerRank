namespace H
{
    /// <summary>
    /// Time complexity: Big_O(n), three separate reversal operations where each take Big_O(n).
    /// </summary>
    public static class RotatorV2
    {
        public static void RotateLeft(int[] array, int d)
        {
            int n = array.Length;
            d = d % n;
            // three traversals
            Reverse(array, startIndex: 0, endIndex: d - 1);
            Reverse(array, startIndex: d, endIndex: n - 1);
            Reverse(array, startIndex: 0, n - 1);
        }

        public static void RotateRight(int[] array, int d)
        {
            int n = array.Length;
            d = d % array.Length;

            // three traversals
            Reverse(array, startIndex: 0, endIndex: n - d - 1);
            Reverse(array, startIndex: n - d, endIndex: n - 1);
            Reverse(array, startIndex: 0, n - 1);
        }

        public static void Reverse(int[] array, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                int temp = array[i];
                array[i] = array[endIndex];
                array[endIndex] = temp;
                endIndex--;
            }
        }
    }
}
