using System;

namespace Class_Work{
    class triangleArea{
        static int Main_func(){
            Console.WriteLine("Input the value of a");
            float a= float.Parse(Console.ReadLine());
            Console.WriteLine("Input the value of b");
            float b= float.Parse(Console.ReadLine());
            Console.WriteLine("Input the value of c");
            float c= float.Parse(Console.ReadLine());
            if (a+b>c && b+c>a && c+a>b){
                float s = (a+b+c)/2;
                float area=(float) Math.Sqrt(s*(s-a)*(s-b)*(s-c));
                Console.WriteLine("The area of Tringle is: {0}",area);
            }
            else{
                Console.WriteLine("The triangle is not possible!!!");
            }
            return 0;
        }
        
    }

}