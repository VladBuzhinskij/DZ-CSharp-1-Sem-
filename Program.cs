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
