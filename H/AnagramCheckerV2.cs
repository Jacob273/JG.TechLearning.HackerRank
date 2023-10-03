namespace H
{
    /// <summary>
    /// This class checks whether word is anagram.
    /// An anagram is a word or phrase formed by rearranging the letters of another.
    /// Time complexity: Big_O(n)
    /// </summary>
    public static class AnagramCheckerV2
    {

        public static bool IsAngram(string str1, string str2)
        {
            var frequencies1 = new Dictionary<char, int>();
            CountChars(str1, frequencies1); // iterating over each character, Big_O(n)

            var frequencies2 = new Dictionary<char, int>();
            CountChars(str2, frequencies2); // iterating over each character, Big_O(n)

            foreach (var kvp1 in frequencies1) // iterating over each frequency registered, Big_O(n)
            {
                if(frequencies2.TryGetValue(kvp1.Key, out int freqCount) && freqCount == kvp1.Value)
                {
                    continue;
                }
                return false;
            }

            return true;
        }

        private static void CountChars(string str1, Dictionary<char, int> frequencies1)
        {
            foreach (var c1 in str1)
            {
                if (frequencies1.TryGetValue(c1, out _))
                {
                    frequencies1[c1]++;
                }
                else
                {
                    frequencies1.Add(c1, 1);
                }
            }
        }
    }
}
