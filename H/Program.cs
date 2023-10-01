// See https://aka.ms/new-console-template for more information
using H;
using Microsoft.VisualStudio.TestTools.UnitTesting;


int[] arr = { 1, 2, 3, 4, 5 };
Rotator.RotateRight(arr, 1);
Assert.IsTrue(new int[] { 5, 1, 2, 3, 4 }.SequenceEqual(arr), "Not equal");
Rotator.RotateRight(arr, 1);
Assert.IsTrue(new int[] { 4, 5, 1, 2, 3 }.SequenceEqual(arr), "Not equal");
Rotator.RotateRight(arr, 3);
Assert.IsTrue(new int[] { 1, 2, 3, 4, 5 }.SequenceEqual(arr), "Not equal");


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

    public static class Rotator
    {
        public static void RotateLeft(int[] array, int d)
        {
            var newD = d % array.Length;
            for (int i = 0; i < newD; i++)
            {
                int first = array[0];
                for(int j = 1; j < array.Length; j++)
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
