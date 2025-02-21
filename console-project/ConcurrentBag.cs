using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Csharp
{
    class ConcurrentBag
    {
        
      static  ConcurrentBag<int> CB = new ConcurrentBag<int>();
        public static void ConOps()
        {
            //Adding the element 
            Parallel.For(0,10,i => CB.Add(i));
            //retrive the element
            Parallel.ForEach(CB,(item) =>{Console.WriteLine(item);});
        }

        public static void RemoveAll()
        {
            Console.WriteLine("\nAttempting to remove elements using TryTake:");
            while (CB.TryTake( out int takenElement))
            {
                Console.WriteLine($"Removed: {takenElement}");
            }

            Console.WriteLine($"\nIs the ConcurrentBag empty? {CB.IsEmpty}");
        }

        public static void PeekEle()
        {
            // Adding elements again to TryPeek
            CB.Add(42);
            CB.Add(99);

            if(CB.TryPeek(out int peekElement))
            {
                Console.WriteLine(peekElement);
            }

            foreach(int item in CB)
            {
                Console.WriteLine(item);
            }
        }
    }
}