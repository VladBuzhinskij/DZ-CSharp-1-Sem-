// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Задача 41. Dведите числа через запятую:");
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
Int32[] result = InputCheck();
if (result[0] == 0)
{
    Int32 answer = 0;
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] > 0)
        {
            answer++;
        }
    }
    Console.WriteLine(answer);
}
else { Console.WriteLine("Ошибка"); }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Задача 43. Введите значения b1, k1, b2 и k2 через запятую:");
Int32[] result32 = InputCheck();
if (result32[0] == 0)
{
    if (result32[2] != result32[4])
    {
        Double X = (result32[3] - result32[1]) / (result32[2]! - result32[4]);
        Double Y = (result32[2] * X) + result32[1];
        Console.WriteLine("(" + X + ";" + Y + ")");
    }
    else { Console.WriteLine("Прямые не пересекаются"); }
}
else { Console.WriteLine("Ошибка"); }

