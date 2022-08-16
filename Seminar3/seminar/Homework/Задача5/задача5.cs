// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");

int numberN = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [numberN];

int g = 1;


void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {   
        int [] arr = {i};              
        
        for(int j = 0; j < count; g = g++)
        {
          j = numberN - (numberN - g);  
          array[i] = j;
        }
    
    Console.WriteLine(array[3]);
    } 

}
PrintArray(arr);
