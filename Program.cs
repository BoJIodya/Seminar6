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

int Chastot(int[,] array) //перебор всех элементов массива и подсчет подобных
{
    //int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int c = 0;
    int[] result = new int[array.GetLength(0) * array.GetLongLength(1) * 2]; //массив для записи повторяющихся эл-ов
    //int[] result1 = new int[array.Length]; // массив для подсчета повторов
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            foreach (int element in array)
                if (array[i, j] == element)
                {
                    double index = array.GetLength(0) * array.GetLongLength(1) * 2 + c;
                    result[c] = element; //запись эл-та
                    result[(int)index] += 1; //счет записи во второй половине массива
                    c += 1;
                }
            //Console.WriteLine(count);
        }
    }
    return result[array.GetLength(0) * array.GetLongLength(1) * 2];

}

void PrintArrayResult(int[] result)
{
    int c = result.Length / 2;
    for (int i = 0; i < result.Length / 2; i++)
    {
        Console.WriteLine($"{result[i]} встречается {result[result.Length / 2 + c]} раз");
        c += 1;
    }
}

int[,] array = new int[3, 3];
RandomArray(array);
PrintArray(array);
Console.WriteLine(); // пустая строка для отделения напечатанного массива
//int count = Chastot(array);
int[] result = new int[(Chastot(array))];
PrintArrayResult(result);