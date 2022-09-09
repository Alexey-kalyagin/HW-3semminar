// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

int [,] array = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4},
                 {5,2,6,7}};

int sum1 = 0;
int sum2 = 0;
int sum3 = 0;
int sum4 = 0;

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} {" "}");
        } 
        Console.WriteLine();
    }
} 
    
int FirstSum (int sum1)
{    
    for (int i = 0; i < 1; i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {              
            sum1 = sum1 + array[i,j];
        }        
    }
    return sum1;
}

int SecondSum (int sum2)
{   
    for (int i = 1; i < 2; i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {             
            sum2 = sum2 + array[i,j];
        }        
    }
    return sum2;
}

int ThirdSum (int sum3)
{   
    for (int i = 2; i < 3; i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {         
            sum3 = sum3 + array[i,j];
        }        
    }
    return sum3;
}

int FourthSum (int sum4)
{   
    for (int i = 3; i < 4; i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {         
            sum4 = sum4 + array[i,j];
        }        
    }
    return sum4;
}

PrintArray(array);

int String1 = Convert.ToInt32(FirstSum (sum1));
int String2 = Convert.ToInt32(SecondSum(sum2));
int String3 = Convert.ToInt32(ThirdSum (sum3));
int String4 = Convert.ToInt32(FourthSum(sum4));
int Min = String1;

if (String2<Min) 
{
    Min=String2;
    Console.WriteLine("сумма второй строки минимальна");
    if (String3<Min)
    {
         Min=String3;
         Console.WriteLine("сумма третьей строки минимальна");
         if (String4<Min) 
        {
             Min=String4; 
             Console.WriteLine("сумма четвертой строки минимальна");
        }
    }
}
else
{
    Console.WriteLine("сумма первой строки минимальна"); 
}

Console.WriteLine(Min);