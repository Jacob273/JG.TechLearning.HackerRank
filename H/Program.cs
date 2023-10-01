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