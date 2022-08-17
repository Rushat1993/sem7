Console.Write("Введите размер массива m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива n ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс позиции i ");
int iI = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс позиции j ");
int iJ = Convert.ToInt32(Console.ReadLine());

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

if (iI > m || iJ > n)
{
    Console.WriteLine("Элемент отсутствует");
}
else
{
    Console.WriteLine("Элемент равен " + arr[iI, iJ]);
}
