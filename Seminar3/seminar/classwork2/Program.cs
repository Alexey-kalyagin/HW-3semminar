 static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length-1; i++)
        {
            Console.Write(i+1 + " - " + namesArray[i] + ",");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length-1] + ".");
    }