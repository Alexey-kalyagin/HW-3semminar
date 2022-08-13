// Задача2


Console.WriteLine("Введите трехзначное число ");

int numberB = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
int numberC = 0;

while (numberB > 0)
{
    numberA = numberB % 10;
    numberB = numberB / 10;
    numberC = (numberC * 10);
    numberC = numberC + numberA;
}
Console.WriteLine(numberC);

void Array(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        if(collection[index] == 2);
                
        index++;
    }

}
