// определяем кол-во строк в треугольнике Паскаля (переменной)
// метод подсчета факториала
// выводить только нечетные (сделать проверку)
// что бы вывести треугольник, нужно сделать отступы. Нижний угол будет самый левый, значит там будет n чисел, отступ n/2 (округлить до целого бОльшего)



int Faktorial(int n) //считает факториал
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

void PaskalTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c < (n - i); c++)
        {
            Console.Write(" "); //отступ
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write("  "); // создаём пробелы между элементами треугольника
            Console.Write(Faktorial(i) / (Faktorial(c) * (Faktorial(i - c))));
        }
        Console.WriteLine(); // отступ между строк
        Console.WriteLine(); // отступ между строк
    }
}

int n = 8; // число строк
//Faktorial(n);
PaskalTriangle(n);