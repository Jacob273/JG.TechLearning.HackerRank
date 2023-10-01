namespace H
{
    public static class Printer
    {
        public static void PrintArr(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
