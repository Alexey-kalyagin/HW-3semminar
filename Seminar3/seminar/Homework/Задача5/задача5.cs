// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [numberN];
int g = 0;

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i <= count; i++)
    {
        for(int g = numberN; g <= 0; numberN = numberN - 1)
        {
        array[i] = g;
        
        }
    g = g - 1;
    Console.WriteLine(array[i]);
    } 

}
PrintArray(arr);
