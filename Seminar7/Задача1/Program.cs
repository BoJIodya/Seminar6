// создеть двумерный массив
// спирально заполнить его:
// -сначала внешний периметр, затем внутренний и т.д.


int[,] FillArray(int[,] array)
{
    int i = array.GetLength(0);
    int j = array.GetLength(1);
    int s = 1;

    for (int y = 0; y < j; y++) //заполняет строчку 0,j (+)
    {
        array[0, y] = s;
        s++;
    }

    for (int y = 1; y < i; y++) // заполняет столбец 0,j (+)
    {
        array[y, j - 1] = s;
        s++;
    }
    {
        for (int x = j - 2; x >= 0; x--) //заполняет строчку i,j (+)
        {
            array[i - 1, x] = s;
            s++;
        }
    }
    for (int y = i - 1; y > 0; y--) // заполняет столбец 0,j (+)
    {
        array[y, 0] = s;
        s++;
    }                               // периметр заполнен

    int k = 1, o = 1;

    while (array[k, o + 1] == 0) //заполняется строка(+)
    {
        array[k, o] = s;
        s++;
        o++;
    }

    while (array[k + 1, o - 1] == 0) //заполняется столбец
    {
        array[k, o] = s;
        s++;
        k++;
    }
    while (array[k, o] == 0) //заполняется строка, нижняя
    {
        array[k, o] = s;
        s++;
        o--;
        Console.WriteLine(array[k, o]);
    }

    while (array[k-1, o+1] == 0) //заполняется столбец, левый
    {
        array[k-1, o+1] = s;
        s++;
        o++;
        Console.WriteLine(array[k, o]);
    }

    return array;

}
void PrintArray(int[,] array) //печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}


int[,] array = new int[5, 5];

array = FillArray(array);
PrintArray(array);