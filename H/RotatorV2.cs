namespace H
{
    /// <summary>
    /// Time complexity: Big_O(n), three separate reversal operations where each take Big_O(n).
    /// </summary>
    public static class RotatorV2
    {
        public static void RotateLeft(int[] array, int d)
        {
            d = d % array.Length;

            // three traversals
            Reverse(array, startIndex: 0, endIndex: d - 1);
            Reverse(array, startIndex: d, endIndex: array.Length - 1);
            Reverse(array, startIndex: 0, array.Length - 1);
        }

        public static void RotateRight(int[] array, int d)
        {
            d = d % array.Length;

            // three traversals
            Reverse(array, startIndex: 0, endIndex: array.Length - d - 1);
            Reverse(array, startIndex: array.Length - d, endIndex: array.Length - 1);
            Reverse(array, startIndex: 0, array.Length - 1);
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
