using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;

namespace hw
{

    public class Visitor{
        public string Name { get; set; }
        public bool HasReservation { get; set; }
        
    }
    public class Cafe
    {
          Queue<Visitor> visitors = new Queue<Visitor>();
          public int Capacity { get; set; } = 5;
          System.Timers.Timer timer;

         public void StartCafe(){
            visitors.Enqueue(new Visitor() { Name = "Tom" });
            visitors.Enqueue(new Visitor() { Name = "Bill" });
            visitors.Enqueue(new Visitor() { Name = "John" });
            visitors.Enqueue(new Visitor() { Name = "Oleg" });
            visitors.Enqueue(new Visitor() { Name = "vanya" });
            
        
      
             
            

         }

     


         public void ShowCurrentQueue(){
              WriteLine("now in the queue {0} visitors", visitors.Count);
              foreach (Visitor v in visitors)
            {
              WriteLine(v.Name);
            }
         }

         public void AddVisitor(string name, bool hasReservation){
          if (hasReservation)
    {
        visitors = new Queue<Visitor>(new[] { new Visitor { Name = name } }.Concat(visitors));
        WriteLine($"{name} добавлен с приоритетом по резервации.");
    }
    else if (visitors.Count < Capacity)
    {
        visitors.Enqueue(new Visitor { Name = name });
        WriteLine($"{name} добавлен в очередь.");
    }
    else
    {
        WriteLine($"Извините, {name}, очередь заполнена.");
    }
         }

         public void DeleteVisitor(){
                var visitor = visitors.Dequeue(); // Удаляем первого посетителя из очереди
                WriteLine($"{visitor.Name} left the cafe.");
         }


        
    }
}