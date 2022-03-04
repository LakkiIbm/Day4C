using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------------------------Constructor Overloading----------------------------------
//namespace Day4C
//{
//    class Constructors
//    {
//        string name;
//        int a, b, c;

//        public Constructors()
//        {
//            Console.WriteLine("Default constructor");
//        }
//        public Constructors(string n) //1 parameter
//        {
//            name = n;
//        }
//        public Constructors(string n, int num) //2 parameters
//        {
//            name = n;
//            a = num;
//        }

//        public static void Main(string[] args)
//        {
//            Constructors c0 = new Constructors();
//            Constructors c1 = new Constructors("Lakshita");
//            Constructors c2 = new Constructors("Nina",21);
//            Console.WriteLine("First object: name: {0},a = {1},b = {2}", c0.name, c0.a, c0.b, c0.c);
//            Console.WriteLine("Second object: name: {0},a = {1},b = {2}", c1.name, c1.a, c1.b, c1.c);
//            Console.WriteLine("Third object: name: {0},a = {1},b = {2}", c2.name, c2.a, c2.b, c2.c);
//            Console.ReadLine();

//        }
//    }
//}


//-------------------Copy Constructor------------------------------------------
//namespace Day4C
//{
//    class Constructors
//    {
//        string name;
//        int id;
//        public Constructors(string n, int n2) 
//        {
//            name = n;
//            id = n2;
//        }
//        public Constructors(Constructors c) //copy constructor
//        {
//            this.name = c.name;
//            this.id = c.id;
//        }

//        public static void Main(string[] args)
//        {
//            Constructors c1 = new Constructors("Nina", 21);
//            Constructors c2 = new Constructors(c1);
//            Console.WriteLine("First object: name: {0},id = {1}", c1.name, c1.id);
//            Console.WriteLine("Copied object: name: {0},id = {1}", c2.name, c2.id);
//            Console.ReadLine();

//        }
//    }
//}


//---------------------------Static Constructor-----------------------------------------
namespace Day4C
{
    class Constructors
    {
        static int n1;
        int n2;
        static Constructors()
        {
            Console.WriteLine("Static constructor");
            n1 = 20;
        }
        public Constructors(int n)
        {
            Console.WriteLine("Default constructor");
            n2 = n;
        }
        void display()
        {
            Console.WriteLine("Static variable: " + n1);
            Console.WriteLine("Non-Static variable: " + n2);
        }
        public static void Main(string[] args)
        {
            Constructors c0 = new Constructors(51);
            Constructors c1 = new Constructors(400);
            c1.display();
            Console.ReadLine();

        }
    }
}