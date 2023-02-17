//Задача 10

Console.WriteLine ("Введите трехзначное число:");
Int32.TryParse(Console.ReadLine(), out Int32 number);

    if (number>99 && number<1000)
    {
        number =(number/10)%10;
        Console.WriteLine(number);

    }
    else
   
    {
       Console.WriteLine("Ошибка"); 
    }



//Задача 13

Console.WriteLine ("Введите семизначное число:");
Int32.TryParse(Console.ReadLine(), out Int32 numbe);

    if (numbe>=1000000 && numbe<10000000)
    {
        Int32 numbeRigth=(numbe/10000)%10;
        Int32 numbeleft=(numbe/100)%10;
        Console.WriteLine("Третье число слева: "+numbeRigth);
        Console.WriteLine("Третье число слева: "+numbeleft);   
    }
    else
   
    {
       Console.WriteLine("Ошибка"); 
    }



//Задача 15

Console.WriteLine ("Введите цифру обозначающее день недели:");
Int32.TryParse(Console.ReadLine(), out Int32 numb);
    if (numb>0 && numb<=7)
    {
        if (numb>5)
        {
           Console.WriteLine("Да"); 
        }
        else
        {
            Console.WriteLine("Нет");
        }
        

    }
    else
   
    {
       Console.WriteLine("Ошибка"); 
    }