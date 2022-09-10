
using System;

int [] array = {1,6,8,5,10,7};

void PrintArray (int [] array)
{   
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} {" "}");
    }
    Console.WriteLine();
}


void SelectionSort (int[] array)
{   
    int count = array.Length;
    for (int i = 0; i < count-1; i++)
    {
        int maxPos = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]>array[maxPos]) maxPos=j;
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}

PrintArray (array);
Console.WriteLine();
SelectionSort(array);
Console.WriteLine();
//PrintArray (array);
