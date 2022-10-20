// See https://aka.ms/new-console-template for more information

using System;

string [] a =  { "   *** ***   ",
                "   *  ***  *   ",
                "  *         *  ",
                " *           * ",
                "*     ***     *",
                "*    *   *    *",
                "*    *   *    *",
                "*    *   *    *",
                "*    *   *    *",
                "*    *   *    *",
                "*     ***     *",
                "*             *",
                "***************"};

void Func (char[][] b, int x, int y)
{
    b[y][x] = 'X';
    if(b[y - 1][x] == ' ') Func(b,x,y-1);
    if(b[y][x + 1] == ' ') Func(b,x+1,y);
    if(b[y + 1][x] == ' ') Func(b,x,y+1);
    if(b[y][x - 1] == ' ') Func(b,x-1,y);
}

void Print (char[][] b)
{
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b[i].Length; j++)
        {
            Console.Write(b[i][j]);
            if (b [i][j] == ' ') Console.BackgroundColor = ConsoleColor.Green;
            if (b [i][j] == '*') Console.BackgroundColor = ConsoleColor.Yellow;
            if (b [i][j] == 'X') Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

char[][] b = new char[a.Length][];
for (int i = 0; i < a.length; i++)
{
    b[i] = a[i].ToCharArray();
}
Func(b,6,8);
Print(b);