﻿int Square(int number)
{
    int square = number * number;
    return square;
}
Console.WriteLine(Square(Convert.ToInt32(Console.ReadLine())));
Console.WriteLine();

void SquareTwo(int numFirst, int numSecond)
{
    if(numFirst == numSecond * numSecond)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
SquareTwo(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();

void comparing(int numF, int numS)
{
    if(numF > numS)
    {
        int max = numF;
        int min = numS;
        Console.WriteLine($"Max = {max}, Min = {min}.");
    }
    else if(numS > numF)
    {
        int max = numS;
        int min = numF;
        Console.WriteLine($"Max = {max}, Min = {min}.");
    }
    else if(numF == numS)
    {
        Console.WriteLine("They are equal");
    }
}
comparing(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();

string Week(int numDay)
{
    string [] week = {"Sunday", "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Saturday"};
    return week[numDay - 1];
}
Console.WriteLine(Week(Convert.ToInt32(Console.ReadLine())));
Console.WriteLine();
