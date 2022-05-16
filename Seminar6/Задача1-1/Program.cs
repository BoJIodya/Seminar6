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
    double ind = array.GetLength(0) * array.GetLongLength(1);
    Console.WriteLine($"ind = {ind}");
    int[,] result = new int[2, (int)ind]; //в первой строке запись значения, во второй частота повтора

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            foreach (int element in array)
                if (array[i, j] == element)
                {
                    result[0, c] = array[i, j];
                    result[1, c] += 1;
                    c += 1;

                    //double index = (array.GetLength(0) * array.GetLongLength(1) - 1) + c;
                    //Console.WriteLine($"index = {index}");
                    //result[c] = element; //запись эл-та
                    //result[(int)index] += 1; //счет записи во второй половине массива
                }
            //Console.WriteLine(count);
        }
    }
    return result[2, (int)ind];

}


int[,] array = new int[3, 3];
RandomArray(array);
PrintArray(array);
Console.WriteLine(); // пустая строка для отделения напечатанного массива
//int count = Chastot(array);
double j = array.GetLength(0) * array.GetLongLength(1);
int[,] result = new int[2, (int)j];
Chastot(array);
PrintArray(result); // печать массива результата