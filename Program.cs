//  Задача 25:
//  Console.WriteLine ("Введите два числа через запятую:");
// string n =Console.ReadLine();
// string[] array = n.Split(',');
// Int32 length=array.Length;
// if (length==2) {
//     if (array[0]=="0"|| array[1]=="0"){Console.WriteLine ("0");}
//     else{
//         Int32.TryParse(array[0], out Int32 number1);
//      Int32.TryParse(array[1], out Int32 number2);
//      if(number1>0 && number2>0){
//         double result= Math.Pow(number1,number2);
//         Console.WriteLine (result);
//         }
//         else{ Console.WriteLine ("Ошибка");}
        
//         }   
//    }
// else{ Console.WriteLine ("Ошибка");}

// Задача 27

// Console.WriteLine ("Введите число:");      
// var n =Console.ReadLine();
// if (n=="0") {
//     Console.WriteLine("0");
// }
// else
// {
//     Int32.TryParse(n, out Int32 number);
//     if (number>0){
//         if(number>0){
//         Int32 result=0;

//         while (number!=0){
//             Int32 ost=number%10;
//             number=number/10;
//              result= result+ost;
             
//              }
//              Console.WriteLine (result);
//         }
//     }
//     else { Console.WriteLine ("Ошибка");}
// }

// Задача 29

//  Console.WriteLine ("Введите восемь чисел через запятую:");
// string n =Console.ReadLine();
// string[] array = n.Split(',');

// Int32 length=array.Length;
// if (length==8) {
//     Int32 err=0;
//     foreach (string i in array){
//         if (i!="0"){
//             Int32.TryParse(i, out Int32 number);
            
//             if (number==0){ Console.WriteLine ("Ошибка");
            
//                 err=1;
//                 }
               

//         }


//     }
//     if (err==0){Console.WriteLine( "["+String.Join(",",array)+"]");}
//     else {Console.WriteLine ("Ошибка");}

    
//    }
// else{ Console.WriteLine ("Ошибка");
// }

