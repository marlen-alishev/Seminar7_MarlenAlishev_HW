// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillArray(double[,] sampleArray)
{
    for (int i=0; i<sampleArray.GetLength(0); i++){
        for(int j=0; j<sampleArray.GetLength(1); j++){
            sampleArray[i, j] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(1, 100);
            Console.Write($"{string.Join(",", sampleArray[i,j])}; ");
        }
        Console.WriteLine();
    }
    return sampleArray;
}

Console.Clear();
Console.Write("Please indentify the size of the array: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] array = new double[size[0], size[1]];

FillArray(array);