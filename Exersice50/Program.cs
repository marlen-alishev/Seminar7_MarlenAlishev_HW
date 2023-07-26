// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int[,] sampleArray)
{
    for (int i=0; i<sampleArray.GetLength(0); i++){
        for(int j=0; j<sampleArray.GetLength(1); j++){
            sampleArray[i, j] = new Random().Next(1,100);
            Console.Write($"{string.Join(",", sampleArray[i,j])}; ");
        }
        Console.WriteLine();
    }
    return sampleArray;
}

string SelectItem(int[,] arrayToTake, int[] arrayToGiveCoordinates) 
{
    if (arrayToGiveCoordinates[0]>=arrayToTake.GetLength(0) || arrayToGiveCoordinates[1]>=arrayToTake.GetLength(1))
        return "Please enter correct coordinates!";
    else
        return (arrayToTake[arrayToGiveCoordinates[0], arrayToGiveCoordinates[1]]).ToString();
}

Console.Clear();
Console.Write("Please indentify the size of the matrix: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];

Console.Write("Please indentify the item coordinates: ");
int[] item = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"\nThe result is: {string.Join(", ", SelectItem(FillArray(array), item))}");
//Console.WriteLine(array.GetLength(0) +"___"+ array.GetLength(1));