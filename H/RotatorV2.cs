namespace H
{
    /// <summary>
    /// Time complexity: Big_O(n).
    /// </summary>
    public static class RotatorV2
    {
        public static void RotateLeft(int[] array, int d)
        {
            var newD = d % array.Length;

            // three traversals (first from 0 do d -1)
            Reverse(array, startIndex: 0, endIndex: d - 1);

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
