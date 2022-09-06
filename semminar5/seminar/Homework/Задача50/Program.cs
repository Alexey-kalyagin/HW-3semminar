// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

using System;

int [,] array = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4}};

Console.Write("Введите число, которое требуется найти ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} {" "}");
    } 
    Console.WriteLine();
}

void FindNumber (int [,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int newi = 0;
            int newj = 0;    
            if (number==array[i,j])
            {   
                newi = newi+i;
                newj = newj+j;
                Console.WriteLine(array[i,j] + " находится в ячейке [" + (i,j) + "]");
            }                    
            else
            {
                Console.WriteLine("В ячейке [" + (i,j) + "] числа нет");
            }

        }    
    } 
}

FindNumber(array);
