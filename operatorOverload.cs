using System;

namespace operatorOverload
{
    class office{
        double salary;
        public office(){
            salary = 0;
        }

        public office(double sal){
            salary=sal;
        }
        public void display(){
            Console.WriteLine(salary);
        }
        public static office operator +(office o, office ob){
            office obj = new office();
            obj.salary = o.salary+ob.salary;
            return obj;
        }
        static void Main_func(){
            office a = new office(1200);
            office b = new office(7880);
            office accountant;
            accountant = a+b;
            accountant.display();
        }
    }
}