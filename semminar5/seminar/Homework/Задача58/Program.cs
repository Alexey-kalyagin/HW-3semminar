// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4    Результирующая матрица будет:   18 20
// 3 2 | 3 3                                    15 18


int [,] firstArray = {{2,4},
                      {3,2}};

int [,] secondArray = {{3,4},
                       {3,3}};

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


void ThirdArray (int [,]array)
{
    array[0,0]= firstArray[0,0]*secondArray[0,0]+firstArray[0,1]*secondArray[1,0];
    array[1,0]= firstArray[1,0]*secondArray[0,0]+firstArray[1,1]*secondArray[1,0];
    array[0,1]= firstArray[0,0]*secondArray[0,1]+firstArray[0,1]*secondArray[1,1];
    array[1,1]= firstArray[1,0]*secondArray[0,1]+firstArray[1,1]*secondArray[1,1];
}   


int [,] thirdArray = new int [2,2];

PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
ThirdArray(thirdArray);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(thirdArray);

