Console.WriteLine("Программа для проверки является ли первое число квадратом второго. Введите два числа.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine($"Число {firstNumber} является квадратом {secondNumber}");
}
else
{
    Console.WriteLine($"Число {firstNumber} не является квадратом {secondNumber}");
}