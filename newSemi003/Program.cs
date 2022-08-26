void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);

        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int [] matrix2 = new int [10];

FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

// int converting(int array1)
// {
//     Console.WriteLine("Введите 10 целых чисел через пробел");
//     string userArray = $"{Console.ReadLine()}";
//     string find = " ";
//     for(int i = 0; i < userArray.Length; i++)
//     {
//         if(userArray[i])
//         {

//         }
//     }
// }

// void plus()
// {
//     for (int i = 0; i < 10; i++)
//     {
//         int result = array[i] + matrix2[i];
//         Console.Write($"{result} ");
//     }
// }

// plus();
