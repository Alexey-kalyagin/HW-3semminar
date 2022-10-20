// Задача 3

int[] array = {1, 2, 3, 4, 5, 6, 7};
int n = array.Length;
int sataday = 6;
int sunday = 7;
int index = 0;

Console.WriteLine("Введите число");

int day = Convert.ToInt32(Console.ReadLine());
   
if (day == sunday)
{
    
    Console.WriteLine("Выходной");
    
} 
else
{

    if (day == sataday)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
       Console.WriteLine("Рабочий день"); 
    }
}    