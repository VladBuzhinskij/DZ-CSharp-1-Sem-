//Задача 2

Console.WriteLine("Введите первое число:");
Int32 number1, number2;
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{Console.WriteLine(number1 + ">" + number2);}
else
{
    if (number1<number2)
 {Console.WriteLine(number1 + "<" + number2);}
 else
 {Console.WriteLine(number1 + "=" + number2);}
 }

// Задача 4

Console.WriteLine("Введите первое число:");
Int32 numb1, numb2, numb3;
numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
numb3 = Convert.ToInt32(Console.ReadLine());
if (numb1>numb2)
{if (numb1>numb3)
 {Console.WriteLine("Максимально число:" + numb1);}
else
 {Console.WriteLine("Максимально число:" + numb3);}
}
else
{if (numb2>numb3)
 {Console.WriteLine("Максимально число:" + numb2);}
else
 {Console.WriteLine("Максимально число:" + numb3);}
}

// Задача 6

Console.WriteLine("Введите число:");
Int32 num1;
float rem;
num1 = Convert.ToInt32(Console.ReadLine());
rem=num1%2;
if (rem==0)
{Console.WriteLine("Число: " + num1 +" - чётное");
}
else
{
    Console.WriteLine("Число: " + num1 +" - нечётное");
}

// Задача 8
Console.WriteLine("Введите число:");
Int32 num,i;
string res="Результат:";
num = Convert.ToInt32(Console.ReadLine());
i=2;
while (num>=i)
{
        res=res +"," + i.ToString();
        i=i+2;
}
Console.WriteLine(res);