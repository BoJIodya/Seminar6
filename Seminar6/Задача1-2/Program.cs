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
    int[] ArrayLine = new int[array.GetLength(0) * array.GetLength(1)];
    int i = 0;
    foreach (int item in array)
    {
        ArrayLine[i] = item;
        i++;
    }
    return ArrayLine;
}

int[,] ScoreNumber(int[] array) //подсчет одинаковых
{
    int[,] score = new int[2, array.Length]; //запись в 0 строке числа, в 1 строке количество повторов

    for (int j = 0; j < array.Length; j++)
    {
        score[0, j] = array[j];
    }
    //score[1, 0] = 1;
    foreach (int item in array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (score[0, i] == item)
            {
                score[1, i] += 1;
            }
            //else score[0, i] = item;
        }
    }

    Console.WriteLine("двумерный массив Score:");
    PrintArray(score);
    return score;
}

int[,] SortResult(int[,] array) // сортировка результата
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (temp == array[0, j]) array[1, j] = 0;
        }

    }

    Console.WriteLine($"Массив после сортировки:");
    PrintArray(array);
    return array;
}

void PrintResult(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
    }
}

int[,] array = new int[3, 3];
RandomArray(array);
PrintArray(array);
Console.WriteLine(); // пустая строка для отделения напечатанного массива

int[] ArrayLine = new int[array.GetLength(0) * array.GetLength(1)]; //линейный массив ёмкостью как двумерный

ArrayLine = LineArray(array); //заполенение линейного массива из двумерного
PrintLineArray(ArrayLine);

Console.WriteLine(); // пустая строка для отделения 
int[,] score = new int[2, ArrayLine.Length];
score = ScoreNumber(ArrayLine); //возврат массива с подсчетом частоты использования

score = SortResult(score); // сортировка результата

