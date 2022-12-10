// Ср. арифметическое элементов в каждом столбце двумерного массива
void FillRondedArray()
{
    Console.WriteLine("Задайте двумерный массив");
    Console.WriteLine("Введите количество строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [m, n];
    FillCustomArray(array);
    PrintCustomArray(array);
    ArithmeticMean (array);
}  
FillRondedArray();

static void FillCustomArray (int [,] array, int minValue = -20, int maxValue = 20)
{
    maxValue++;
    Random rand = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = rand.Next (minValue, maxValue);
        }
    }
}
static void PrintCustomArray (int [,] array, string massage = "Двумерный массив")
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write ($"{array [i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
static void ArithmeticMean (int [,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int j = 0; j < n; j++)
    {
        double srAr = 0;
        for (int i = 0; i < m; i++)
        {
            srAr += array [i, j];
        }
        srAr = srAr/m;
        Console.Write ($"{srAr}\t");
    }
}
