// Задача 1

Console.WriteLine("Введите трехзначное число ");

int numberX = Convert.ToInt32(Console.ReadLine());

int a = numberX/100;
int b = (numberX % 100) / 10;
int c = numberX % 10;

Console.WriteLine(b + " - является второй цифрой этого числа");
