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

int[,] ProizvedMatrix(int[,] arrayA, int[,] arrayB)
{
    int o = arrayA.GetLength(0);
    int k = arrayB.GetLength(1);
    int[,] arrayResult = new int[o, k]; // размер матрицы зависит от множителей

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int h = 0; h < arrayB.GetLength(0); h++)
            {
                arrayResult[i, j] += arrayA[i, h] * arrayB[h, j];

            }
        }

    }
    return arrayResult;
}



int[,] arrayA = new int[5, 3]; // число столбцов той матрицы должно быть
int[,] arrayB = new int[3, 5]; // равно числу строк в этой
int o = arrayA.GetLength(0);
int k = arrayB.GetLength(1);
int[,] arrayResult = new int[o, k]; //размер матрицы должен зависеть от произведения двух матриц 


RandomArray(arrayA);
RandomArray(arrayB);
PrintArray(arrayA);
Console.WriteLine(); //раздедитель между матрицами
PrintArray(arrayB);

arrayResult = ProizvedMatrix(arrayA, arrayB); //произведение матриц

Console.WriteLine(); //раздедитель между матрицами
PrintArray(arrayResult);
