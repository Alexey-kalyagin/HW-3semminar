// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.



Console.WriteLine ("Введите числа массива через пробел");
string elem = Console.ReadLine();
int []array = GetArrayFromString(elem);
Console.WriteLine (string.Join(" ", GetArrayFromString(elem)));
int subzero = 0;
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int [] res = new int [nums.Length];
    for (int i=0; i<nums.Length; i++)
    {
        res [i] = int.Parse(nums[i]);
    }  
return res;
}

for (int i=0; i<array.Length; i++)
{
    if (array[i]<0)
    {
        subzero=subzero+1;
    }
    
}
Console.WriteLine(subzero);