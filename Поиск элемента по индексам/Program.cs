// Принимает индексы элементы и выводит его либо указывает на его отсутствие
void SearchIndex()
{
    int rows = 8;
    int columns = 8;
    int [,] array = new int [rows, columns];
    
    FillCustomArray(array);
    PrintCustomArray(array);    
    
    Console.WriteLine("Введите индекс строки i: ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца j: ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());
    
    if (rowIndex >=0 && rowIndex < rows && columnIndex >= 0 && columnIndex < columns)
        {
            Console.WriteLine($"Элемент с индексами [{rowIndex}, {columnIndex}] = " 
            + array[rowIndex, columnIndex]);
        }
    else
        {
            Console.WriteLine("Такого элемента нет");
        }
}  
SearchIndex();

static void FillCustomArray (int [,] array, int minValue = -11, int maxValue = 11)
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

