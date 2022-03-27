using System;

namespace Class_Work{
    class quadraticEquation{
        static int Main_func(){
            float a=2;
            float b=3;
            float c=1;
            float d = (b*b)-(4*a*c);
            if(d>0)
            {  
                float rootD=(float) Math.Sqrt(d);
                float x1 = (-b+rootD)/(2*a);
                float x2 = (-b-rootD)/(2*a);
                Console.WriteLine($"Roots are: {x1}, {x2}");
            }
            else if(d==0)
            {
                float x =(-b)/(2*a);
                Console.WriteLine($"Unique Root: {x}");
            }
            else
            {
                Console.WriteLine("The Roots are not real!");
            }
            return 0;
        }
        
    }

}