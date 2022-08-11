void example01()
{
    int random = new Random().Next(10, 100);
    Console.WriteLine(random);
    int firstNumber = random / 10;
    int secondNumber = random % 10;

    if(firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}
example01();
Console.WriteLine();

int example02()
{
    int random = new Random().Next(10, 100);
    Console.WriteLine(random);
    int firstNumber = random / 10;
    int secondNumber = random % 10;

    if(firstNumber > secondNumber)
    {
        return (firstNumber);
    }
    else
    {
        return (secondNumber);
    }
}
Console.WriteLine(example02());
Console.WriteLine();

    string example03()
{
    string res = String.Empty;
    int random = new Random().Next(10, 100);
    int firstNumber = random / 10;
    int secondNumber = random % 10;
    res = Convert.ToString(random);
    if(firstNumber > secondNumber)
    {
        res = res + " " + Convert.ToString(firstNumber);
    }
    else
    {
        res = res + " " + Convert.ToString(secondNumber);
    }
    return res;
}
Console.WriteLine(example03());
Console.WriteLine();

int example04(int random)
{
    int firstNumber = random / 10;
    int secondNumber = random % 10;
    if(firstNumber > secondNumber)
    {
        return (firstNumber);
    }
    else
    {
        return (secondNumber);
    }
}
int num = new Random().Next(10,100);
Console.WriteLine(num);
Console.WriteLine(example04(num));