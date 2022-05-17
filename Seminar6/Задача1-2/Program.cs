// ввод нового массива и заполение его рандомно
// печать массива, для понятия исходника
// перевод массива в линейный
// подсчет одинаковых чисел
// вывод результата

void RandomArray(int[,] array) //заполнение массива рандомно
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) //печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }

}

void PrintLineArray(int[] array) // печать линейного массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] LineArray(int[,] array) // перевод массива в линейный
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int i = 0;
    foreach (int item in array)
    {
        result[i] = item;
        i++;
    }
    return result;
}


int[,] array = new int[3, 3];
RandomArray(array);
PrintArray(array);
Console.WriteLine(); // пустая строка для отделения напечатанного массива

int[] result = new int[array.GetLength(0) * array.GetLength(1)]; //линейный массив ёмкостью как двумерный

result = LineArray(array);
PrintLineArray(result);

