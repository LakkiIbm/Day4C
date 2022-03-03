using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------------Stack--------------------------------------
//namespace Day4C
//{
//    internal class CollAdv
//    {
//        static void Main(string[] args)
//        {
//            var value = new Stack<int>();
//            value.Push(10);
//            value.Push(20);
//            value.Push(30);
//            value.Push(40);
//            value.Push(50);
//            Console.WriteLine("Popped value from the stack: " + value.Pop());
//            Console.WriteLine("Last inserted value in the stack: "+value.Peek());
//            Console.WriteLine("The values in the stack are:");
//            foreach (var item in value) 
//                Console.WriteLine(item);
//            Console.ReadLine();

//        }
//    }
//}



//-------------------------Queue--------------------------------------
//namespace Day4C
//{
//    internal class CollAdv
//    {
//        static void Main(string[] args)
//        {
//            var value = new Queue<int>();
//            value.Enqueue(10);
//            value.Enqueue(20);
//            value.Enqueue(30);
//            value.Enqueue(40);
//            value.Enqueue(50);
//            Console.WriteLine("First inserted value in the queue: " + value.Dequeue());
//            Console.WriteLine("First value present in the queue: " + value.Peek());
//            Console.WriteLine("The values in the queue are:");
//            foreach (var item in value)
//                Console.WriteLine(item);
//            Console.ReadLine();

//        }
//    }
//}



//-----------------------------Dictionary---------------------------------
//namespace Day4C
//{
//        internal class CollAdv
//    {
//        static void Main(string[] args)
//        {
//            var pair = new Dictionary<string,string>();
//                pair.Add("al", "Aluminium");
//                pair.Add("fe", "Iron");
//                pair.Add("si", "Silicon");
//                pair.Add("h", "Hydrogen");
//                pair.Add("n", "Nitrogen");
//                pair.Add("he", "helium");
//                pair.Add("se", "Selenium");
//            Console.WriteLine("The keys in the dictionary are:");
//            foreach (var item in pair.Keys)
//                Console.WriteLine(item);
//            Console.WriteLine("The values in the dictionary are:");
//            foreach (var item in pair.Values)
//                Console.WriteLine(item);
//            Console.WriteLine("The key/value pairs in the dictionary are:");
//            foreach (var item in pair)
//                Console.WriteLine(item);
//            Console.ReadLine();

//        }
//    }
//}

//---------------------------Hashtable---------------------------------
namespace Day4C
{
    internal class CollAdv
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("al", "Aluminium");
            ht.Add("fe", "Iron");
            ht.Add("si", "Silicon");
            ht.Add("h", "Hydrogen");
            ht.Add("n", "Nitrogen");
            ht.Add("he", "Helium");
            ht.Add("se", "Selenium");
            ICollection k = ht.Keys;
            Console.WriteLine("The hashtable conatins the following key/value pairs:");
            foreach (string key in k)
                Console.WriteLine(key+": "+ht[key]);

            Console.ReadLine();

        }
    }
}
