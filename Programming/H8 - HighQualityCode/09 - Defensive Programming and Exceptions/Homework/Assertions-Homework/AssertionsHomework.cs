﻿using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is null!");
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        // Asseration for sorted array
        for (int i = 1; i < arr.Length; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i - 1]) >= 0, "Array is not sorted!");
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is null!");
        Debug.Assert(startIndex >= 0, "Incorrect start index!");
        Debug.Assert(endIndex <= arr.Length, "Incorrect end index!");
        Debug.Assert(startIndex <= endIndex, "Incorrect assign of start and end index!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        // Asseration for minimal element index
        for (int i = startIndex; i < endIndex; i++)
		{
		    Debug.Assert(arr[minElementIndex].CompareTo(arr[i]) <= 0, "That is not minimal element index!");
		}

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null");
        for (int i = 1; i < arr.Length; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i - 1]) >= 0, "Array is not sorted!");
        }
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is null!");
        Debug.Assert(startIndex >= 0, "Incorrect start index!");
        Debug.Assert(endIndex <= arr.Length, "Incorrect end index!");
        Debug.Assert(startIndex <= endIndex, "Incorrect assign of start and end index!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        Debug.Assert(!arr.Contains(value), String.Format("Array contain {0}", value));
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
