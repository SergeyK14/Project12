// Двумерный массив с вещественными числами, округленными до одного знака
void FillRondedArray()
{
    Console.WriteLine("Задайте двумерный массив");
    Console.WriteLine("Введите количество строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double [,] array = new double [m, n];
    FillCustomArray(array);
    PrintCustomRoundedArray(array);
}  
FillRondedArray();

static void FillCustomArray (double [,] array, int minValue = -17, int maxValue = 17)
{
    maxValue++;
    Random rand = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = rand.Next (minValue, maxValue) + rand.NextDouble();
        }
    }
}
static void PrintCustomRoundedArray (double [,] array, string massage = "Двумерный массив")
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write ($"{Math.Round(array [i, j], 1)}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
