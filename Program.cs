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
            Console.Write ($" {array[i,j]}");
        }
        Console.WriteLine();
    }

}

int[,] array = new int[3, 3];
RandomArray(array);
PrintArray(array);
Console.WriteLine(); // пустая строка для отделения напечатанного массива

