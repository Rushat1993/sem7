Console.Write("Введите размер массива m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().Next(0, 100);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
double sum = 0;
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        sum = sum + arr[i, j];
    }
    Console.Write($"{sum / m} ");
}
Console.WriteLine();