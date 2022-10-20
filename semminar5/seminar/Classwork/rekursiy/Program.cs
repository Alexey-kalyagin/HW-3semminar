using System;

// Вводим массивы:
string [,] one = {{"-","-","-"},
                  {" ","|"," "}, 
                  {" ","|"," "},
                  {" ","|"," "},
                  {"-","-","-"}};

string [,] two = {{"-","-","-"},
                  {"|"," ","|"}, 
                  {"|"," ","|"},
                  {"|"," ","|"},
                  {"-","-","-"}};

string [,] three ={{"-","-","-"},
                   {"|","|","|"}, 
                   {"|","|","|"},
                   {"|","|","|"},
                   {"-","-","-"}};

string [,] DoubleNumber = {{" "," "," "," "," "," "},
                           {" "," "," "," "," "," "}, 
                           {" "," "," "," "," "," "},
                           {" "," "," "," "," "," "},
                           {" "," "," "," "," "," "}};   

string[,] DoubleArray (string[,] array1, string[,] array2) 
{
    int indexSize = DoubleNumber.GetLength(1)/2;
    for (int i = 0; i < DoubleNumber.GetLength(0); i++)
    {
        for (int j = 0; j < indexSize; j++)
        {
            DoubleNumber [i,j] = array1[i,j];
            DoubleNumber [i, indexSize] = array2[i,j];
        }   
    }
    return DoubleNumber;
} 

// Создаем рекурсию:
void Timer(int index)
{
    switch (index)
    {
        case 1:
            WriteArray(one); break;
        case 2:
            WriteArray(two); break;
        case 3:
            WriteArray(three); break;
        default:
            index = 0; break;
        case 11:
            WriteArray(DoubleArray(one,two)); break;
    }
    if(index !=0)
    {
        index++;
        System.Threading.Thread.Sleep(1000);    // вводим счётчик отсчёта времени
        Timer (index);
    }
} 

// Выводим массивы
void WriteArray (string[,] array)
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }

}
Timer(11);       //В скобках значение кейса (case) с которого начинаем. 
                //Для обратного отсчёта вводим последний кейс 
                //и в строке увеличения индекса, ставим уменьшение (index--)