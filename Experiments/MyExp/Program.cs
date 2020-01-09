using System;

namespace MyExp
{
    class Program
    {
        static void f()
        {
            int i=3;
            if(i==1)
            Console.WriteLine("one");
            else if(i==2)
            Console.WriteLine("two");
            else 
            Console.WriteLine("three");
            

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int x=3;
            f();
            switch(x)
            {
                case 1: Console.WriteLine("one");break;
                case 2: Console.WriteLine("two");break;
                case 3: Console.WriteLine("three");break;
                /*case 4: Console.WriteLine("four");break;
                case 5: Console.WriteLine("five");break;
                case 6: Console.WriteLine("six");break;
                case 7: Console.WriteLine("seven");break;*/
            }
            Console.ReadLine();
        }
    }
}
