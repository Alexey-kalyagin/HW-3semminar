//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double [] arr1 = new double[3];
double [] arr2 = new double[3];
double sum = 0;

Console.WriteLine("Введите координаты первой точки");
for (int i = 0; i < 3; i++)
{
    arr1[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите координаты второй точки");
for (int i = 0; i < 3; i++)
{
    arr2[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < 3; i++)
{
    sum+= Math.Pow((arr1[i] - arr2[i]),2);
}
Console.WriteLine(Math.Sqrt(sum));
