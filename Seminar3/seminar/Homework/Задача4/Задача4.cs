// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Введите число");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
int numberC = 0;
int numberD = numberB;

while(numberD > 0)
{
    numberA = numberD % 10;
    numberD = numberD / 10;
    numberC = numberC * 10;
    numberC = numberC + numberA;
}
if (numberC == numberB)
{
    Console.WriteLine(numberB + " - Число является полиндромом");
}
else
{
    Console.WriteLine(numberB + " - Число НЕ является полиндромом");
}
