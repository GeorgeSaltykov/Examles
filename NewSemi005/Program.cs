// Задайте массив из N = 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите суммы отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29, сумма отрицательных равна - 20.

// void fillArray(int[] numberOf)
// {
//     for (int i = 0; i < numberOf.Length; i++)
//     {
//         numberOf[i] = new Random().Next(-9, 10);
//         System.Console.Write($"{numberOf[i]} ");
//     }
// }

// void sum(int[] someArray)
// {
//     int positive = new int();
//     int negative = new int();
//     for (int i = 0; i < someArray.Length; i++)
//     {
//         if(someArray[i] > 0) positive += someArray[i];
//         else negative += someArray[i];
//     }
//     System.Console.WriteLine($"sum of positive numbers {positive}, sum of negative numbers {negative}");
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// fillArray(array);
// System.Console.WriteLine();
// sum(array);

// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void fillArray(int[] numberOf)
// {
//     for (int i = 0; i < numberOf.Length; i++)
//     {
//         numberOf[i] = new Random().Next(-9, 10);
//         System.Console.Write($"{numberOf[i]} ");
//     }
// }

// void changePlace(int[] someArray)
// {
//     for (int i = 0; i < someArray.Length; i++)
//     {
//         someArray[i] = -someArray[i];
//         System.Console.Write($"{someArray[i]} ");
//     }
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// fillArray(array);
// System.Console.WriteLine();
// changePlace(array);


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 
// -3; массив [6, 7, 19, 345, 3] -> да

// void fillArray(int[] numberOf)
// {
//     for (int i = 0; i < numberOf.Length; i++)
//     {
//         numberOf[i] = new Random().Next(-9, 10);
//         System.Console.Write($"{numberOf[i]} ");
//     }
// }

// void find(int[] someArray, int userNumber)
// {
//     int find = 0;
//     for (int i = 0; i < someArray.Length; i++)
//     {
//         if(someArray[i] == userNumber) find = 1;
//     }
//     if(find == 1) System.Console.WriteLine("Число присутствует");
//     else System.Console.WriteLine("Числа в данном массиве нет");
// }
// System.Console.WriteLine("Введите размер массива");
// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// fillArray(array);
// System.Console.WriteLine();
// System.Console.WriteLine("Введите число от -9 до 9, оторое вы бы хотели найти");
// find(array, Convert.ToInt32(Console.ReadLine()));

// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значение которых лежат в отрезке [10, 99].
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void fillArray(int[] numberOf)
// {
//     for (int i = 0; i < numberOf.Length; i++)
//     {
//         numberOf[i] = new Random().Next(0, 200);
//         System.Console.Write($"{numberOf[i]} ");
//     }
// }

// void find(int[] someArray)
// {
//     int find = 0;
//     for (int i = 0; i < someArray.Length; i++)
//     {
//         if(someArray[i] >= 10 && someArray[i] <= 99) 
//         {
//             System.Console.WriteLine($"{find + 1} = {someArray[i]}"); 
//             find++;
//         }
//     }
//     System.Console.WriteLine(find);
// }
// System.Console.WriteLine("Введите размер массива");
// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// fillArray(array);
// System.Console.WriteLine();
// find(array);

// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент массива, второй и предпоследний и т. д.
// Результат запишите в новом массиве.
// [1, 2, 3, 4, 5] -> [5, 8, 3]
// [6, 7, 3, 6] -> [36, 21]

void fillArray(int[] numberOf)
{
    for (int i = 0; i < numberOf.Length; i++)
    {
        numberOf[i] = new Random().Next(1, 11);
        System.Console.Write($"{numberOf[i]} ");
    }
}

int[] multiply(int[] someArray)
{
    int length = new int();
    if(someArray.Length % 2 == 0) length = someArray.Length / 2;
    else length = someArray.Length / 2 + 1;
    int[] multiply = new int[length];
    int j = someArray.Length - 1;
    int i = 0;
    for (int index = 0; index <= j; index++)
    {
    if (i < j)
    {
        multiply[i] = someArray[i] * someArray[j];
        j--;
        i++;
    }
    else multiply[i] = someArray[i]; 
    }
    return multiply;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

System.Console.WriteLine("Введите размер массива");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
fillArray(array);
System.Console.WriteLine();
printArray(multiply(array));