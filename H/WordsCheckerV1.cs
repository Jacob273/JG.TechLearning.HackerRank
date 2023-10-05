namespace H
{
    public static class WordsCheckerV1
    {
        private static HashSet<string> _dic = new()
        {
            "i",
            "am",
            "you",
            "are",
            "he",
            "is",
            "she",
            "butterfly",
            "johhny",
            "macaron",
            "dead",
            "mom",
            "dad",
            "brother"
        };

        public static bool BruteForceCheck(string input)
        {
            var ranges = GatherRanges(input);
            var result = WordsOnly(ranges, 0, input.Length);
            return result;
        }

        private static bool IsWord(string str)
        {
            return _dic.Contains(str);
        }

        private static int OuterLoopCounter = 0;
        private static int InnerLoopCounter = 0;
        private static List<List<RangeInfo>> GatherRanges(string input)
        {
            //Big_O(n * n/2), e.g for n= 10 it gives 50~ iteration
            var rangeInfoList = new List<List<RangeInfo>>();
            for (int i = 0; i < input.Length; i++)
            {
                OuterLoopCounter++;
                string currentWord = "";
                var subList = new List<RangeInfo>();
                for (int j = i; j < input.Length; j++)
                {
                    currentWord += input[j];
                    bool isWord = IsWord(currentWord);
                    if (isWord)
                    {
                        subList.Add(new RangeInfo(i, j, isWord));
                    }
                    InnerLoopCounter++;
                }

                if(subList.Count > 0)
                {
                    rangeInfoList.Add(subList);
                }
            }
            //iterations
            Console.WriteLine(OuterLoopCounter + InnerLoopCounter);
            return rangeInfoList;
        }

        private static bool WordsOnly(List<List<RangeInfo>> rangeInfoLists, int startIndex, int maxIndex)
        {
            if (startIndex >= maxIndex)
            {
                //we have to the end, words only !
                return true;
            }

            var matchingRanges = rangeInfoLists.SelectMany(infoList => infoList)
                                               .Where(info => info.StartIndex == startIndex)
                                               .ToList();

            foreach (var range in matchingRanges)
            {
                if (range.IsWord)
                {
                    // we go further
                    if (WordsOnly(rangeInfoLists, range.EndIndex + 1, maxIndex))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public class RangeInfo
        {
            public int StartIndex { get; }
            public int EndIndex { get; }
            public bool IsWord { get; }

            public RangeInfo(int start, int end, bool isWord)
            {
                StartIndex = start;
                EndIndex = end;
                IsWord = isWord;
            }
        }
    }
}
