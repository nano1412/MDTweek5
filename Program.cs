using System;

namespace costomname {
     class Program {            
          static void Main(string[] args) {
               //carinterest();
               //iif();
               //twopositive();
               //mod();
               ifelse();
          }
          
          static void carinterest(){
               int car,down,rate,interest,total;

               Console.Write("car price:");
               car = int.Parse(Console.ReadLine());
               Console.Write("front payment price:");
               down = int.Parse(Console.ReadLine());
               Console.Write("rate(%):");
               rate = int.Parse(Console.ReadLine());

               interest = ((car-down) * (rate/100) * 4);
               total = (car-down) + interest;
               Console.WriteLine("payment per month = {0} THB", total/12);
          }
          static void iif(){
               Console.Write("Number:");
               int num = int.Parse(Console.ReadLine());
               if (num > 0){Console.WriteLine("positive");}
          }
          static void twopositive(){
               Console.Write("Number1:");
               int num1 = int.Parse(Console.ReadLine());
               Console.Write("Number2:");
               int num2 = int.Parse(Console.ReadLine());
               if(num1>0 || num2>0){
                    Console.WriteLine("positive");
               }
          }

          static void mod(){
               Console.Write("Number:");
               int num = int.Parse(Console.ReadLine());
               if (num %9 != 0){Console.WriteLine("not divisible");}
          }
          static void ifelse(){
               double num1,num2;
               Console.Write("num1:");
               num1 = double.Parse(Console.ReadLine());
               Console.Write("num2:");
               num2 = double.Parse(Console.ReadLine());
               if(num2 > 0){
                    Console.WriteLine(num1+num2);
               }
               else{
                    Console.WriteLine(num1*num2);
               }
          }
     }
}