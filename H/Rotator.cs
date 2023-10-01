namespace H
{
    /// <summary>
    /// Time complexity: Big_O(d * n).
    /// </summary>
    public static class Rotator
    {
        public static void RotateLeft(int[] array, int d)
        {
            var newD = d % array.Length;
            for (int i = 0; i < newD; i++)
            {
                int first = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }
                array[array.Length - 1] = first;
            }
        }

        public static void RotateRight(int[] array, int d)
        {
            var newD = d % array.Length;
            for (int i = 0; i < newD; i++)
            {
                int last = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = last;
            }
        }
    }
}
