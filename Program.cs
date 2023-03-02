Console.WriteLine ("Задача 34");

        static Int32 WriteConsole(){
            Console.WriteLine ("Введите количество элементов:");
            Int32 number=0;
            var n =Console.ReadLine();
            if (n=="0") {
                Console.WriteLine("0");}
                else{
                Int32.TryParse(n, out number);
                if (number>0){
                     }
                else{Console.WriteLine ("Ошибка");
               
                }      
                     
        }
return number ;    
}
Int32 number=WriteConsole();
if (number>0){
    Int32[] array =new Int32[number];
    Int32 result=0;

    for (int i = 0; i < array.Length; i++){
       Random rnd = new Random();
       array[i]=rnd.Next(100,1000);
       Int32 ost=(array[i])%2;
       if (ost==0){
        result=result+1;
       }
       }
       Console.WriteLine( "["+String.Join(",",array)+"]");
       Console.WriteLine(result);
}
Console.WriteLine ("Задача 36");
number=WriteConsole();
if (number>0){
    Int32[] array =new Int32[number];
    Int32 result=0;
    for (int i = 0; i < array.Length; i++){
       Random rnd = new Random();
       array[i]=rnd.Next(-10000,10000);
        if ((i%2)!=0){
        result=result+array[i];
       }
       }
       Console.WriteLine( "["+String.Join(",",array)+"]");
       Console.WriteLine(result);
}


Console.WriteLine ("Задача 38");
number=WriteConsole();
if (number>0){
    Double[] array =new Double[number];
    Double max=0,min=1,result=0;
    for (int i = 0; i < array.Length; i++){
       Random rnd = new Random();
       array[i]=rnd.NextDouble();
        if (array[i]>max){max=array[i];}
        if (array[i]<min){min=array[i];}
       }
       result=max-min;

       Console.WriteLine( "["+String.Join(",",array)+"]");
       Console.WriteLine(result);
}

Console.WriteLine ("Доп");
number=WriteConsole();
if (number>0){
    Int32[] array =new Int32[number];
    for (int i = 0; i < array.Length; i++){
       Random rnd = new Random();
       array[i]=rnd.Next(-100,100);}
    if ((array.Length)%2==0){
        Int32[] ArrayResult=new Int32[(array.Length/2)];
        for (int i = 0; i < (array.Length)/2; i++){  
            ArrayResult[i]=array[i]*array[array.Length-i-1];
        }
         Console.WriteLine( "["+String.Join(",",array)+"]");
         Console.WriteLine( "["+String.Join(",",ArrayResult)+"]");
    }
    else{
        Int32[] ArrayResult=new Int32[(array.Length/2)+1];
        for (int i = 0; i < (array.Length)/2; i++){  
            ArrayResult[i]=array[i]*array[array.Length-i-1];
        }
        ArrayResult[(array.Length/2)]=array[(array.Length/2)];
        Console.WriteLine( "["+String.Join(",",array)+"]");
        Console.WriteLine( "["+String.Join(",",ArrayResult)+"]");

    }      
}

