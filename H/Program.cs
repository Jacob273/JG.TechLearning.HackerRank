﻿// See https://aka.ms/new-console-template for more information
using H;
using Microsoft.VisualStudio.TestTools.UnitTesting;

WordsCheckerV1.BruteForceCheck("iamiamiamidead");

int[] arr = { 1, 2, 3, 4, 5 };
RotatorV1.RotateRight(arr, 1);
Assert.IsTrue(new int[] { 5, 1, 2, 3, 4 }.SequenceEqual(arr), "Not equal");
RotatorV1.RotateRight(arr, 1);
Assert.IsTrue(new int[] { 4, 5, 1, 2, 3 }.SequenceEqual(arr), "Not equal");
RotatorV1.RotateRight(arr, 3);
Assert.IsTrue(new int[] { 1, 2, 3, 4, 5 }.SequenceEqual(arr), "Not equal");



int[] arr2 = { 1, 2, 3, 4, 5 };
RotatorV2.Reverse(arr2, 0, 4);
Assert.IsTrue(new int[] { 5, 4, 3, 2, 1 }.SequenceEqual(arr2), "Not equal");

int[] arr3 = { 1, 2, 3, 4, 5 };
RotatorV2.RotateRight(arr3, 1);
Assert.IsTrue(new int[] { 5, 1, 2, 3, 4 }.SequenceEqual(arr3), "Not equal");
RotatorV2.RotateRight(arr3, 1);
Assert.IsTrue(new int[] { 4, 5, 1, 2, 3 }.SequenceEqual(arr3), "Not equal");
RotatorV2.RotateRight(arr3, 3);
Assert.IsTrue(new int[] { 1, 2, 3, 4, 5 }.SequenceEqual(arr3), "Not equal");


Assert.IsTrue(AnagramCheckerV1.IsAngram("listen", "silent"));
Assert.IsFalse(AnagramCheckerV1.IsAngram("listenn", "silent"));
Assert.IsFalse(AnagramCheckerV1.IsAngram("aabb", "ab"));
Assert.IsFalse(AnagramCheckerV1.IsAngram("ab", "aba"));
Assert.IsTrue(AnagramCheckerV1.IsAngram("abca", "bcaa"));


Assert.IsTrue(AnagramCheckerV2.IsAngram("listen", "silent"));
Assert.IsFalse(AnagramCheckerV2.IsAngram("listenn", "silent"));
Assert.IsFalse(AnagramCheckerV2.IsAngram("aabb", "ab"));
Assert.IsFalse(AnagramCheckerV2.IsAngram("ab", "aba"));
Assert.IsTrue(AnagramCheckerV2.IsAngram("abca", "bcaa"));
