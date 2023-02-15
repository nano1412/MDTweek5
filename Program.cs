using System;

namespace costomname {
     class Program {            
          static void Main(string[] args) {
          carinterest();
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
     }
}