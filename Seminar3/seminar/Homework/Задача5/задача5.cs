// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


      
          
Console.WriteLine("Введите число");

int number1 = Convert.ToInt32(Console.ReadLine());


for(int number2 = 1; number2 <= number1; number2++)
    {
    
    Console.Write(Math.Pow (number2,3) + " ");
    } 
Console.WriteLine(" ");


