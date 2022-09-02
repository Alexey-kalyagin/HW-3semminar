// Задача2


Console.WriteLine("Введите число ");

int numberB = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
int numberC = 0;
int[] array = new int[1];
while (numberB > 0)
{
    numberA = numberB % 10;
    numberB = numberB / 10;
    numberC = (numberC * 10);
    numberC = numberC + numberA;
    void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = numberA;
            index++;
        }
    }
    void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        } 
    }
    FillArray(array);
    PrintArray(array); 
}
Console.WriteLine(numberC);

