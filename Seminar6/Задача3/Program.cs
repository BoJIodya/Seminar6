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
            int print = Faktorial(i) / (Faktorial(c) * (Faktorial(i - c)));
            if (print % 2 != 0) Console.Write(print); // проверка на нечетность
            else Console.Write($"  ");
        }
        Console.WriteLine(); // отступ между строк
        Console.WriteLine(); // отступ между строк
    }
}

int n = 3; // число строк
if (n <= 2)
{
    Console.WriteLine($"Нужно число побольше!");
    
}
else PaskalTriangle(n);