using System;  
  public class FactorialExample  
   {  
     public static void Main(string[] args)  
      {  
       int fact = 1;
       int number = 9;
       if(number<=1)
       {
           fact = 1;
       }else
       {
           for(int i = 1; i<=number;i++)
           {
               fact=fact*i;
           }
       }
       Console.Write("Factorial of " +number+" is: "+fact);    
     }  
  }  