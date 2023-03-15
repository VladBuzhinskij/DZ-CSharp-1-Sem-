/// <summary>
/// Метод читает строку из консоли, разбивает ее на массив элементов и проверяет являются ли элементы целыми числами
/// </summary>
/// <returns> возвращяет массив чисел. Если элемент[0] равен 1, значит преобразовать не получилось </returns>
Int32[] InputCheck()
{
    string str = Console.ReadLine();
    string[] stri = str.Split(',');
    Int32[] result = new Int32[(stri.Length) + 1];
    Int32 number;
    for (int i = 0; i < stri.Length; i++)
    {
        if (stri[i] == "0") result[i + 1] = 0;
        else
        {
            Int32.TryParse(stri[i], out number);
            if (number != 0) { result[i + 1] = Convert.ToInt32(stri[i]); }
            else result[0] = 1;         
        }
    }
    return result;
}

/// <summary>
/// Метод заполняет строку значениями лежащими между M и N
/// </summary>
/// <param name="M"> первая граница ряда</param>
/// <param name="N"> вторая граница ряда</param>
/// <returns> Возвращяет строку целых чисел лежащих между границами</returns>
String NumbersString (Int32 M, Int32 N)
{
    if (M<N) return $"{M} "+NumbersString(M+1,N);
    else return String.Empty+N;

}
/// <summary>
/// Метод вычисляет сумму между элементами
/// </summary>
/// <param name="M"> первая граница </param>
/// <param name="N"> вторая граница ряда </param>
/// <returns> Возвращяет сумму чисел </returns>
Int32 NumbersSum (Int32 M, Int32 N)
{
    if (M<N) return M+NumbersSum(M+1,N);
    else return N;

}
/// <summary>
/// Метод вычисляет функцию Акермана
/// </summary>
/// <param name="n"> Параметр n функции Акермна</param>
/// <param name="m">Параметр m функции Акермна</param>
/// <returns> Возвращает значении функции Акермана</returns>
Int32 Akerman (Int32 n, Int32 m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akerman(n - 1, 1);
    else
      return Akerman(n - 1, Akerman(n, m - 1));
}


// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Задача 54. Введите значения M и N (M, N)");
Int32[] Input = InputCheck();
if (Input[0] == 0 && Input.Length == 3&&Input[1]>=0&&Input[2]>=0)
{
    String Result=String.Empty;
    if (Input[1]<Input[2]) Result=NumbersString(Input[1],Input[2]);    
    else Result=NumbersString(Input[2],Input[1]);
    Console.WriteLine($"{Result}");
}
else Console.WriteLine("Ошибка");



//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Задача 66. Введите значения M и N (M, N)");
Int32[] Input66 = InputCheck();
if (Input[0] == 0 && Input.Length == 3 &&Input66[1]>=0&&Input66[2]>=0)
{
    Int32 Result;
    if (Input[1]<Input[2]) Result=NumbersSum(Input66[1],Input66[2]);    
    else Result=NumbersSum(Input66[2],Input66[1]);
    Console.WriteLine($"{Result}");
}
else Console.WriteLine("Ошибка");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа n и m.
Console.WriteLine("Задача 68. Введите значения n и m (n, m)");
Int32[] Input68 = InputCheck();
if (Input[0] == 0 && Input68.Length == 3 &&Input68[1]>=0&&Input68[2]>=0)
{
    Int32 Result;
    Result = Akerman(Input68[1],Input68[2]);
    Console.WriteLine($"{Result}");
}
else Console.WriteLine("Ошибка");




// void OutputtingInt(Int32[,] InputArray)
// {
//     for (int i = 0; i < InputArray.GetLength(0); i++)
//     {

//         for (int j = 0; j < InputArray.GetLength(1); j++)
//         {

//             Console.Write(InputArray[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// Int32[,] BuildArray(Int32 y, Int32 x)
// {
//     Int32[,] Array = new Int32[y, x];

//     for (int i = 0; i < y; i++)
//     {
//         for (int j = 0; j < x; j++)
//         {
//             Array[i, j] = new Random().Next(0, 20);
//         }
//     }
//     return Array;
// }
// Int32[] SortArray(Int32[] array)
// {
//     Int32 TimeVariable = 0;
//     Int32 j = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         j = i;
//         while ((j > 0) && (array[j] > array[j - 1]))
//         {
//             TimeVariable = array[j - 1];
//             array[j - 1] = array[j];
//             array[j] = TimeVariable;
//             j = j - 1;
//         }
//     }
//     return array;
// }
// Int32[] CutArray(Int32[,] array, Int32 Line)
// {
//     Int32[] Result = new Int32[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         Result[i] = array[Line, i];
//     }
//     return Result;
// }



// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.WriteLine("Задача 54. Введите размер массива (Столбцы, Строки)");
// Int32[] Input = InputCheck();
// if (Input[0] == 0 && Input.Length == 3)
// {
//     Int32[,] ResultArray = new Int32[Input[1], Input[2]];
//     Int32[,] Array = BuildArray(Input[1], Input[2]);
//     Int32[] TimeArray = new Int32[Array.GetLength(1)];

//     OutputtingInt(Array);
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         TimeArray = CutArray(Array, i);
//         TimeArray = SortArray(TimeArray);
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             ResultArray[i, j] = TimeArray[j];
//         }
//     }
//     OutputtingInt(ResultArray);
// }
// else
// {
//     Console.WriteLine("Ошибка");
// }

// //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("Задача 56. Введите размер массива (Столбцы, Строки)");
// Int32[] Input56 = InputCheck();
// if (Input56[0] == 0 && Input56.Length == 3)
// {
//     Int32 PrevSum = 0;
//     Int32 Result = 0;
//     Int32[,] Array = BuildArray(Input56[1], Input56[2]);
//     Int32[] TimeArray = new Int32[Array.GetLength(1)];
//     OutputtingInt(Array);
//     Int32 Sum = 0;
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         Sum = 0;
//         TimeArray = CutArray(Array, i);
//         for (int j = 0; j < TimeArray.Length; j++)
//         {
//             Sum = Sum + TimeArray[j];
//         }
//         if (Sum < PrevSum)
//         {
//             Result = i;
//         }
//         PrevSum = Sum;
//     }
//     Console.WriteLine(Convert.ToString(Result));
// }
// else
// {
//     Console.WriteLine("Ошибка");
// }



// //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.WriteLine("Задача 56. Введите размер массива (Столбцы Матрицы А, Строки Матрицы А, толбцы Матрицы Б, Строки Матрицы Б)");
// Int32[] Input58 = InputCheck();
// if (Input58[0] == 0 && Input58.Length == 5 && Input58[1] == Input58[4])
// {
//     Int32[,] ArrayA = BuildArray(Input58[1], Input58[2]);
//     Int32[,] ArrayB = BuildArray(Input58[3], Input58[4]);
//     Int32[,] Result = new Int32[Input58[1], Input58[4]];
//     OutputtingInt(ArrayA);
//     OutputtingInt(ArrayB);
//     for (int i = 0; i < ArrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < ArrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < ArrayB.GetLength(0); k++)
//             {
//                 Result[i, j] += ArrayA[i, k] * ArrayB[k, j];
//             }
//         }
//     }

//     OutputtingInt(Result);

// }
// else
// {
//     Console.WriteLine("Ошибка");
// }







