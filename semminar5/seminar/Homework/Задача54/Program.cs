// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int [,] array = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4},
                 {5,2,6,7}};

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

void FirstSort (int [,]array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {              
            for ( i = 0; i < array.GetLength(0); i++)
            {   
                for (j = 0; j < array.GetLength(1); j++)
                {
                    int maxPos = j;
                    for (int l = j+1; l < array.GetLength(1); l++)
                    {
                                        
                        if (array[i,l]>array[i,maxPos]) maxPos=l;
                    
                    }
                    int temp = array[i,j];
                    array[i,j] = array[i,maxPos];
                    array[i,maxPos] = temp;
                }
            }        
        }
    }
}


PrintArray(array);
Console.WriteLine();
FirstSort (array);
PrintArray(array);


