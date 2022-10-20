
int [,] number =    {{1, 2, 5, 79, 143},
                     {1, 3, 7, 9, 45},
                     {34, 6, 85, 189, 7},
                     {45, 8, 453, 15, 25}};
// int row = int.Parse(Console.ReadLine()); - для ввода количества строк с клавы
// int colomn = int.Parse(Console.ReadLine()); - для ввода количества столбцов с клавы
// int [,] = new int [row, colomn];
Console.WriteLine(number[2,3]); // - вывод элемента с второй строки пятой позиции
// для вывода массива в терминал
for(int i = 0; i<number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
    Console.Write(number [i,j] + " ");
    } 
    Console.WriteLine();
}