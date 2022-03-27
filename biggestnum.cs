using System;

namespace Class_Work{
    class bigestOfThemAll{
        static int big(){
            int a=8;
            int b=5;
            int c=4;
            if (a>b && a>c){
                Console.WriteLine($"The Biggest number is: {a}");
            }
            else if(b>c && b>a){
                Console.WriteLine($"The Biggest number is: {b}");
            }
            else if(c>a && c>b){
                Console.WriteLine($"The Biggest number is: {c}");
            }
            return 0;
        }
        
    }

}