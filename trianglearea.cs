using System;

namespace Class_Work{
    class triangleArea{
        static int triangle(){
            float a=8;
            float b=5;
            float c=12;
            if (a+b>c && b+c>a && c+a>b){
                float s = (a+b+c)/2;
                float area=(float) Math.Sqrt(s*(s-a)*(s-b)*(s-c));
                Console.WriteLine($"The area of Tringle is: {area}");
            }
            else{
                Console.WriteLine("The triangle is not possible!!!");
            }
            return 0;
        }
        
    }

}