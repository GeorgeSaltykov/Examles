// fist type

// void Method1 ()
// {
//     Console.WriteLine("Автор...");
// }
//Method1();

// second type

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
//Method2(msg: "Сообщение: бла, бла");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
//Method21(msg: "Сообщение", count: 4);
//Method21(count: 4, msg: "Сообщение");

// third type

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
//Console.WriteLine(Year);

// forth type

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
//Console.WriteLine(res);

// cycle within a cycle

// for (int i = 2; i <= 9; i++)
// {
//     for(int j = 2; j <= 9; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленьие буквы "к" заменить большими,
// а большие "с" заменить маленьими.

// Ясна ли задача?

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винцегероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s =  "qwerty"
//              012345
// s[3] // r

// string replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i ++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

SelectionSort2(arr);

PrintArray(arr);