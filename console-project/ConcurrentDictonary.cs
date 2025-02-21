using System.Collections.Concurrent;
using System.Threading.Tasks;
using  System;


namespace Csharp
{
    class ConcurrentDictonary
    {
        static ConcurrentDictionary<string,int> CD = new ConcurrentDictionary<string,int>();
        public static void DictOps()
        {
            //Add element in dictionary
            for(int i = 0;i <= 20;i++)
            {
                CD.TryAdd($"Key {i}",i);
            }

            //Retrive the element from dictionary
            foreach(dynamic item in CD)
            {
              Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
        public static void UpdateDict()
        {

          Parallel.ForEach(CD,item =>
          {
            CD.TryUpdate(item.Key,item.Value+10,item.Value);
          });
          
          Console.WriteLine("After Update:");
          foreach(var item in CD)
          {
            Console.WriteLine($"{item.Key}:{item.Value}");
          }
        }

         public static void AddIfNotExists()
        {
            Console.WriteLine("\nUsing GetOrAdd to ensure keys are added only if they don't exist:");
            
            // Add a key-value pair only if the key does not already exist
            for(int i = 0; i < 5; i++)
            {
                int value = CD.GetOrAdd($"Key{i}", 100); // Adds `Key0`, `Key1`... only if they don't exist
                Console.WriteLine($"Key: Key{i}, Value: {value}");
            }
        }

        public static void RemoveDict()
        {
           string keyToremove = "Key2";

           if(CD.TryRemove(keyToremove,out int value))
           {
            Console.WriteLine($"successfully Removed {keyToremove}:{value}");

           }
           else{
            Console.WriteLine("key not found in dictonary");
           }
        }

        //Parallel.For is used for enable the councurrent operation in the dictonary 
        //Parallel.ForEach for itreate through the dictonary and update or retrive it
    }
}