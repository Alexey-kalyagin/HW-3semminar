// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] array = {{01,02,03,11},
                 {04,12,08,05},
                 {16,07,14,13},
                 {06,10,15,09}};

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
                    int maxPos1 = j;
                    int maxPos2 = i;
                    for (int l = j+1; l < array.GetLength(1); l++)
                    {
                        for (int k = i+1; k < array.GetLength(0); i++)
                        {
                            if (array[k,l]>array[maxPos2,maxPos1]) 
                            {
                                maxPos2=k;
                                maxPos1=l;           
                            }
                        }
                    int temp = array[i,j];
                    array[i,j] = array[maxPos2,maxPos1];
                    array[maxPos2,maxPos1] = temp;
                    }                
                }
            }        
        }
    }
}
PrintArray(array);
Console.WriteLine();
FirstSort (array);
PrintArray(array);