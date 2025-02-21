using System.Collections;
using System;


namespace Csharp
{
    class NonGenricTest:IComparer
    {


        public static void ArrayListDisplay()
        {
            //creating the arrayList
            ArrayList arrayList = new ArrayList();
            
            //adding the elements in the collection

            arrayList.Add(10);
            arrayList.Add(5.5);
            arrayList.Add("hello");

            

            //accessing by the index
            var i = arrayList[1];

            Console.WriteLine($"First Index:-{i}");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //arrayList.Remove("hello");

            //arrayList.RemoveAt(1);

            //arrayList.Clear();

            //if Checks the elements exits or not

            Console.WriteLine($"Contains:-{arrayList.Contains(10)}");

            Console.WriteLine($"Index num :-{arrayList.IndexOf("hello")}");

            Console.WriteLine($"Capacity of arraylist :- {arrayList.Capacity}");

            Console.WriteLine($"Count of elements:-{arrayList.Count}");


        }

        public static void HashTableDisplay()
        {
            Hashtable hashtable = new Hashtable();

            // Adding key-value pairs
            hashtable.Add(1, "One");
            hashtable.Add("Two", 2);
            hashtable.Add(3.5, "Three");
            //
            hashtable[4] = "Four";

            var str = hashtable[4] ;

            Console.WriteLine(str);

            hashtable[1] = "Updated One";

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
      
            Console.WriteLine($"Contains key:-{hashtable.ContainsKey(5)}");
            Console.WriteLine($"Contains value:-{hashtable.ContainsValue("Four")}");

            // hashtable.Remove(1); // Removes the key-value pair with key = 1

            Console.WriteLine(hashtable.Count);

            hashtable.Clear();

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

       // Compare method to handle multi-type keys
        public int Compare(object x, object y)
        {
            // Handle null values
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            // Compare integers
            if (x is int && y is int)
            {
                return ((int)x).CompareTo((int)y);
            }
            // Compare strings
            else if (x is string && y is string)
            {
                return string.Compare((string)x, (string)y, StringComparison.OrdinalIgnoreCase);
            }
            // Compare int to string by converting int to string
            else if (x is int && y is string)
            {
                return string.Compare(x.ToString(), (string)y, StringComparison.OrdinalIgnoreCase);
            }
            // Compare string to int by converting string to int
            else if (x is string && y is int)
            {
                return string.Compare((string)x, y.ToString(), StringComparison.OrdinalIgnoreCase);
            }

            // Throw exception if types are unsupported
            throw new ArgumentException("Unsupported key types.");
        }


        public static void SortedListDisplay()
        {
            SortedList list = new SortedList();

            list.Add(1, "Apple");
            list.Add(2, "Orange");
            list.Add(3, "Banana");
         
            list[4] = "Grapes";


            foreach (DictionaryEntry entry in list)
            {
                Console.WriteLine($"Key :{entry.Key} Value:{entry.Value}");
            }

            // Console.WriteLine($"Value for key 2:{list[2]}");

            // Console.WriteLine($"Count:-{list.Count}");

            // Console.WriteLine($"Contains key 3:-{list.Contains(3)}");
            // Console.WriteLine($"Contains Value?:-{list.ContainsValue("Orange")}");

            // var keys = list.Keys;

            // foreach(int key in keys)
            // {
            //     Console.WriteLine($"Keys:- {key}");
            // }

            // var values = list.Values;

            // foreach(var value in values)
            // {
            //     Console.WriteLine($"Values:-{value}");
            // }

            // list.Remove(2);

            // list.RemoveAt(0);

            //    foreach(var value in list)
            //     {
            //         Console.WriteLine($" Key:-{keys} Values:-{value}");
            //     }

            //list.Clear();



        }

        public static void StackDisplay()
        {

            // Create a Stack
            Stack stack = new Stack();

            // Adding elements (Push)
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14);

            Console.WriteLine("Stack contents:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Peek the top element
            Console.WriteLine("\nTop element (Peek): " + stack.Peek());

            // Remove the top element (Pop)
            Console.WriteLine("Popped element: " + stack.Pop());

            Console.WriteLine("\nStack after Pop:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Check if an element exists
            Console.WriteLine("\nContains 'Hello': " + stack.Contains("Hello"));

        }

        public static void QueueDisplay()
        {
            Queue queue = new Queue();

            // Adding elements (Enqueue)
            queue.Enqueue(1);
            queue.Enqueue("World");
            queue.Enqueue(2.71);

            Console.WriteLine("Queue contents:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Peek the front element
            Console.WriteLine("\nFront element (Peek): " + queue.Peek());

            // Remove the front element (Dequeue)
            Console.WriteLine("Dequeued element: " + queue.Dequeue());

            Console.WriteLine("\nQueue after Dequeue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Check if an element exists
            Console.WriteLine("\nContains 'World': " + queue.Contains("World"));

        }



    }
}