string sum = "+", diff = "-", multiplication = "*", division = "/", ostatok = "%";
double result = 0;
Console.WriteLine("Для сложения введите: '+'. Для вычитания введите: '-'. Для умножения введите: '*'. Для деления введите: '/'. Для нахождения остатка при делении %");
string userSimbol = Console.ReadLine();
string End = "something";
while(End.ToLower() != "end")
{
    Console.WriteLine("Введите первое число ");
    string userNumberOne = Console.ReadLine();
    Console.WriteLine("Введите второе число ");
    string userNumberTwo = Console.ReadLine();
    if(userSimbol == sum)
    {
        result = Convert.ToDouble(userNumberOne) + Convert.ToDouble(userNumberTwo);
    };
    if(userSimbol == diff)
    {
        result = Convert.ToDouble(userNumberOne) - Convert.ToDouble(userNumberTwo);
    };
    if(userSimbol == multiplication)
    {
        result = Convert.ToDouble(userNumberOne) * Convert.ToDouble(userNumberTwo);
    };
    if(userSimbol == division)
    {
        result = Convert.ToDouble(userNumberOne) / Convert.ToDouble(userNumberTwo);
    };
    if(userSimbol == ostatok)
    {
        result = Convert.ToDouble(userNumberOne) % Convert.ToDouble(userNumberTwo);
    };
    Console.WriteLine("Результат равен: " + result);
    Console.WriteLine("Для продолжения нажмите 'Enter', для завершения введите: 'end', затем нажмите 'Enter'.");
    End = Console.ReadLine();
    Console.WriteLine("Для сложения введите: '+'. Для вычитания введите: '-'. Для умножения введите: '*'. Для деления введите: '/'.");
    userSimbol = Console.ReadLine();
}