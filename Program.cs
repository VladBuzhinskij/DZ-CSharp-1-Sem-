Int32[] InputCheck()
{
    string str = Console.ReadLine();
    string[] stri = str.Split(',');
    Int32[] result = new Int32[(stri.Length) + 1];
    Int32 number;
    for (int i = 0; i < stri.Length; i++)
    {
        if (stri[i] == "0")
        {
            result[i + 1] = 0;
        }
        else
        {
            Int32.TryParse(stri[i], out number);
            if (number != 0) { result[i + 1] = Convert.ToInt32(stri[i]); }
            else
            {
                result[0] = 1;
            }
        }
    }
    return result;
}
// Int32[] result = InputCheck();

void Outputting(double[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {

        for (int j = 0; j < InputArray.GetLength(1); j++)
        {

            Console.Write(InputArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void OutputtingInt(Int32[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {

        for (int j = 0; j < InputArray.GetLength(1); j++)
        {

            Console.Write(InputArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Задача 47. Введите размер массива, максимальное и минимальное значение элемента массива через запятую'm,n,max,min'");
Int32[] Input = InputCheck();
if (Input[0] == 0 && Input.Length == 5)
{
    Double[,] array = new Double[Input[1], Input[2]];
    Int32 max = Input[3];
    Int32 min = Input[4];
    for (int i = 0; i < Input[1]; i++)
    {

        for (int j = 0; j < Input[2]; j++)
        {
            array[i, j] = (new Random().NextDouble()) * (max - min) + min;
        }
    }
    Outputting(array);
}
else
{
    Console.WriteLine("Ошибка");
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
Console.WriteLine("Задача 50. Введите позицию элемента в массиве'строка,столбец'");
Int32[] Input50 = InputCheck();
if (Input50[0] == 0 && Input50.Length == 3)
{
    Int32[,] array = new Int32[new Random().Next(1, 10), new Random().Next(1, 10)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 30);
        }
    }
    OutputtingInt(array);
    if (Input50[1] < array.GetLength(0) && Input50[2] < array.GetLength(1))
    {
        Console.WriteLine(array[Input50[1] - 1, Input50[2] - 1]);
    }
    else
    {
        Console.WriteLine("такого числа в массиве нет");
    }

    //     Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


    Console.WriteLine("Задача 52.");
    OutputtingInt(array);

    double average;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Int32 sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        average = Convert.ToDouble(sum) / array.GetLength(0);
        Console.Write(average + "  ");
    }
}
else
{
    Console.WriteLine("Ошибка");
}
