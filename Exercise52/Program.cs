// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int[,] sampleArray)
{
    for (int i=0; i<sampleArray.GetLength(0); i++){
        for(int j=0; j<sampleArray.GetLength(1); j++){
            sampleArray[i, j] = new Random().Next(1, 10);
            Console.Write($"{string.Join(",", sampleArray[i,j])}; ");
        }
        Console.WriteLine();
    }
    return sampleArray;
}

double[] Mean(int[,] arrayToCalc)
{
    int length0 = arrayToCalc.GetLength(0);
    double sum = 0;
    double mean = 0;
    double[] resultArray = new double[] {};
    for (int i=0; i<arrayToCalc.GetLength(1); i++)
    {
        for (int j=0; j<arrayToCalc.GetLength(0); j++)
        {
            sum = sum + arrayToCalc[j, i];
            if (j == (length0-1))
            {
                mean = sum/length0;
                sum = 0; 
                resultArray = resultArray.Append(mean).ToArray();
            }
        }
    }
    return resultArray;
}

Console.Clear();
Console.Write("Please indentify the size of the matrix: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
Console.WriteLine($"\nHere are the means: {string.Join("; ", Mean(FillArray(array)))}");; 