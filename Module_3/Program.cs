using System;

class MainClass
{
    public static void Main(string[] args)
    {
        /* string Name = "PKNZ";
         Byte age = 38;
         const bool pet = true;
         float noga = 41.5f;
         Console.WriteLine("Меня зовут {0} ",Name);
         Console.WriteLine("мне {0} лет",age);
         Console.WriteLine("у меня есть питомец? " + pet);
         Console.WriteLine("\nмой размер ноги " + noga);
         Console.ReadKey();*/

        //  Console.WriteLine("байтMin {0} ", byte.MinValue);
        //  Console.WriteLine("байтMax {0} ", byte.MaxValue);

        /*         enum DaysOfWeek : byte
         {
             Monday = 1,
             Tuesday, 
             Wednesday,
             Thursday,
             Friday,
             Saturday,
             Sunday,

         }*/
        /*
        Semaphore svetofore;

        svetofore = Semaphore.Yellow;

        Console.WriteLine(svetofore);
    }

    enum Semaphore : short
    {
        Red = 100,
        Yellow = 200,
        Green = 300,

    }
    



        int counter = 9;
        Console.WriteLine("Value: {0} decrement: {1}", counter, --counter);

        int counter1 = 9;
        Console.WriteLine("Value : {0} Increment: {1}", counter1, counter1++);


        int k = -7;
        int b = 10;
       int Result = b - k;

        int olddata = 6;
        string data = olddata.ToString();

        Console.WriteLine(data);

        Console.WriteLine(olddata);

        Console.ReadKey();

        

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        Console.WriteLine("каков твой любимый день?");
        int day = 1;
        string daystr = day.ToString();
        Console.WriteLine("day");


        Console.ReadKey(); */


        Console.Write("Введите имя: ");
           var name = Console.ReadLine();
        Console.Write("Введите возраст: ");
           var age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваше имя {0}, и вам {1} лет", name, age);
        Console.Write("введите дату вашего рождения: ");
           var birthdate = Console.ReadLine();
        Console.Write("дата вашего рождения: {0}",birthdate);





    }
}


