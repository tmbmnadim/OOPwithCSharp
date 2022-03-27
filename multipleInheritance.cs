using System;

namespace Class_Work{
    class grandfather
    {
        public void grandfather_func(){
            Console.WriteLine("Grandfather...");
        }
    }

    class father:grandfather
    {
        public void father_func(){
            Console.WriteLine("Father...");
        }
    }

    class son:father
    {
        public void son_func(){
            Console.WriteLine("Son...");
        }
    }
    class multipleInheritance
    {
        static int Main_func()
        {
            son son = new son();
            son.grandfather_func();
            son.father_func();
            son.son_func();
            return 0;
        }
        
    }

}