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

void PrintArray(int[,] array) //печать массива
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

int[,] FreqDictionary(int[,] array) //перебор всех элементов массива и подсчет подобных
{
    double ind = array.GetLength(0) * array.GetLongLength(1);
    int[,] result = new int[2, (int)ind]; //в первой строке запись значения, во второй частота повтора
    int count = 0; //переменная для ввода в новый массив данных

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // int number = array[i, j];
            foreach (int number in array)
                if (number == array[i, j])
                {
                    result[0, count] = number;
                    result[1, count] += 1;
                    Console.WriteLine($"number = {number}");
                    Console.WriteLine($"count = {count}");
                    count++;
                }

        }
    }
    return result;

}



int[,] array = new int[3, 3];
RandomArray(array);
PrintArray(array);
Console.WriteLine(); // пустая строка для отделения напечатанного массива
//int count = FreqDictionary(array);
double j = array.GetLength(0) * array.GetLongLength(1);
int[,] result = new int[2, (int)j];
result = FreqDictionary(array);
FreqDictionary(array);
PrintArray(result); // печать массива результата