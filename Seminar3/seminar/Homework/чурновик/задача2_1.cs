// Задача2


Console.WriteLine("Введите число ");

int numberB = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
int numberC = 0;
int numberA1 = 0;
int numberB1 = 0;
int numberC1 = 0;

while (numberB > 0)
{
    numberA = numberB % 10;
    numberB = numberB / 10;
    numberC = (numberC * 10);
    numberC = numberC + numberA;
}
while (numberC > 0)
{
    numberA1 = numberC % 10;
    numberB1 = numberC / 10;
    numberC1 = (numberC1 * 10);
    numberC1 = numberC1 + numberA1;
    
    int[] array = new int[1];
    void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = numberA1;
            index++;
        }
    }
    
    FillArray(array);
    Console.WriteLine(array[2]);
    }





