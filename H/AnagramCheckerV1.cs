namespace H
{
    /// <summary>
    /// This class checks whether word is anagram.
    /// An anagram is a word or phrase formed by rearranging the letters of another.
    /// Time complexity: Big_O(nlog(n))
    /// </summary>
    public static class AnagramCheckerV1
    {

        public static bool IsAngram(string str1, string str2)
        {
            if (str1 == null || str2 == null || (str1.Length != str2.Length))
            {
                return false;
            }

            var strEnumerable1 = str1.OrderByDescending(x => x); // Big_O(nlog(n)) assuming its quicksort
            var strEnumerable2 = str2.OrderByDescending(y => y); // Big_O(nlog(n)) assuming its quicksort

            var enumerator2 = strEnumerable2.GetEnumerator();
            enumerator2.MoveNext();
            foreach (var char1 in strEnumerable1)
            {
                var char2 = enumerator2.Current;
                if (char1 != char2)
                {
                    return false;
                }
                enumerator2.MoveNext();
            }
            return true;
        }
    }
}
