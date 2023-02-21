// Задача 19
// Console.WriteLine ("Введите число:");      
// var n =Console.ReadLine();
// if (n=="0") {
//     Console.WriteLine("Да");
// }
// else
// {
//     Int32.TryParse(n, out Int32 number);
//     if (number>10){
//         Int32 result=0;

//         while (number!=0){
//             Int32 ost=number%10;
//             number=number/10;
//              result= result*10+ost;

//         }
//         if (result==number){
//             Console.WriteLine("Да");
//         }
//         else{Console.WriteLine("Нет");}

       
//         }
//         else {
//             if (number==0){
//                 Console.WriteLine("Ошибка");
//             }
//             else{Console.WriteLine("Да");}


//         }
        
//     }


//Задача 21
// string []mass={"X","Y","Z"};
// Int32[]A= new int [3];
// string coord;
// for (int i = 0; i < 3; i++){
//     coord= mass[i];
//     Console.WriteLine ("Введите координату "+coord+" точки A:"); 
//     var n=Console.ReadLine();
//     if (n=="0"){  A[i]=Convert.ToInt32(n);}
//     else{ Int32.TryParse(n, out Int32 number);
//     if (number!=0){A[i]=Convert.ToInt32(n);}
//     else{ Console.WriteLine ("Ошибка");}
//     }
// }
// Int32[]B= new int [3];
// for (int ii = 0; ii < 3; ii++){
//     coord= mass[ii];
//     Console.WriteLine ("Введите координату "+coord+" точки B:"); 
//     var n=Console.ReadLine();
//     if (n=="0"){  B[ii]=Convert.ToInt32(n);}
//     else{ Int32.TryParse(n, out Int32 number);
//     if (number!=0){B[ii]=Convert.ToInt32(n);}
//     else{ Console.WriteLine ("Ошибка");}
//     }
// }

// double length=Math.Sqrt((B[0]-A[0])* (B[0]-A[0])+(B[1]-A[1])* (B[1]-A[1])+(B[2]-A[2])* (B[2]-A[2]));
// Console.WriteLine(length);

//Задача 23
//  Console.WriteLine ("Введите число:");
//  var n =Console.ReadLine();
//  if (n=="0") {
//     Console.WriteLine("Ошибка");
// }
// else
// {
//     Int32.TryParse(n, out Int32 number);
//     if (number==0){Console.WriteLine("Ошибка");}
//     else{
//         string result="1";
//         for (int i=2; i<=number; i++){
//             Int32 cube= i*i*i;
//             result=result+", "+cube;

//         }
//         Console.WriteLine(result);

//     }
// }

//Доп. задание №1:

//  Console.WriteLine ("Введите сумму вклада:");
//  var n =Console.ReadLine();
//  if (n=="0") {
//     Console.WriteLine("Ошибка");
// }
// else
// {
//     Int32.TryParse(n, out Int32 number);
//     if (number>0&&number<100){Console.WriteLine("Сумма вклада с процентами черезх год равна="+number*1.05);
//     }
//     if(number>=100 && number<=200){Console.WriteLine("Сумма вклада с процентами черезх год равна="+number*1.07);}
//     if(number>200){Console.WriteLine("Сумма вклада с процентами черезх год равна="+number*1.1);}
//     if(number==0){Console.WriteLine ("Ошибка");}
// }

// Доп. задание №2:

//  Console.WriteLine ("Введите число:");
//  var n =Console.ReadLine();
//  if (n=="0") {
//     Console.WriteLine("Число интересное");
// }
// else
// {
//     Int32.TryParse(n, out Int32 number);
//     if (((n.Length)%2)!=0){
//         if (number==0){Console.WriteLine("Ошибка");}
//     if (number>10){
//         int[] mass=new int[n.Length];
//         Int32 i=0;
//         while (number!=0){
//             Int32 ost=number%10;
//             mass[n.Length-i-1]=ost;
//             number=number/10;
//             i=i+1;     
           
//         }
        
//         if (((mass.Max())-(mass.Min()))==5){
//             Console.WriteLine("Число интересное");
//         }
//         else{Console.WriteLine("Число не интересное");}
//     }
//     if (number>0&&number<10){Console.WriteLine("Число интересное");}
//     }
    
    
// }
