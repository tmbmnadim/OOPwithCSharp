using System;
namespace one2hundread
{
    class Adder
    {
        static void Main_func(){
            int sumis = 0;
            for(int i = 0; i<=100;i++)
            {
                sumis+=i;
            }
            Console.WriteLine("The sum of 1 to 100 is {0}", sumis);
            return;
        }
    }
}