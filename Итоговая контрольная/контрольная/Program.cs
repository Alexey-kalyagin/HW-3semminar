// Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длинна которого менее или равна 3 символа. Первоначально массив можно ввести с 
// клавиатуры либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// примеры: ["hello", "2", "world", ":-)"] -> ["2",":-)"] 

using System;


    Console.WriteLine ("Введите массив из строк через пробел");
    string text = Console.ReadLine();
    string [] array = text.Split(' ');
   
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    { 
        string text2 = array[i];
        
        if (text2.Length < 4)
        {
            for (int j = 0; j < text2.Length-1; j++)
            {
                
                Console.Write(text2[j]);
            }
            Console.Write(text2[text2.Length-1] + ", "); 
        }
        
    } 
    Console.Write("]"); 
    
                

 