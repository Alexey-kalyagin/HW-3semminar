// Задача2

Console.WriteLine("Введите трехзначное число ");

int numberB = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
int numberC = 0;
int numberX = 0;

int [] array = {};  
int index = 0;
if (numberB < 100)
{
    Console.WriteLine("Третьей цифры нет");
} 

while (numberB > 0)
{
    numberA = numberB % 10;
    array[index] = numberA;
    index++;  
    numberB = numberB / 10;
    numberC = (numberC * 10);
    numberC = numberC + numberA;
}
Console.WriteLine(numberC);
Console.WriteLine(array[2]);
