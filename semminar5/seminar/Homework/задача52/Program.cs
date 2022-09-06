// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4

using System;

double [,] array = {{1,4,7,2},
                    {5,9,2,3},
                    {8,4,2,4}};

void PrintArray(double [,] array)
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

double sum1 = 0;
double diffrence1 = 0;
void FirstSum (double diffrence1)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < 1; j++)
        {              
            sum1 = sum1 + array[i,j];
        }        
    }
    diffrence1 = sum1/array.GetLength(0);
    Console.WriteLine(Math.Round(diffrence1,2));
}

double sum2 = 0;
double diffrence2 = 0;
void SecondSum (double diffrence2 = 0)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 1; j < 2; j++)
        {             
            sum2 = sum2 + array[i,j];
        }        
    }
    diffrence2 = sum2/array.GetLength(0);
    Console.WriteLine(Math.Round(diffrence2,2));
}

double sum3 = 0;
double diffrence3 = 0;
void ThirdSum (double diffrence3)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 2; j < 3; j++)
        {         
            sum3 = sum3 + array[i,j];
        }        
    }
    diffrence3 = sum3/array.GetLength(0);
    Console.WriteLine(Math.Round(diffrence3,2));
}

double sum4 = 0;
double diffrence4 = 0;
void FourthSum (double diffrence4)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 3; j < 4; j++)
        {         
            sum4 = sum4 + array[i,j];
        }        
    }
    diffrence4 = sum4/array.GetLength(0);
    Console.WriteLine(Math.Round(diffrence4,2));
}

PrintArray(array);
FirstSum (diffrence1);
SecondSum(diffrence2);
ThirdSum (diffrence3);
FourthSum(diffrence4);

