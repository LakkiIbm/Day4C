using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------------------------------Nullables------------------------------
namespace Day4C
{
    internal class Nullables
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            int? j = null;
            double? k = null;
            bool? v = null;
            int? x = 12;
            int? y = i ?? j;
            int? z = x ?? j;
            Console.WriteLine("The nullable int values are: i = {0}, j = {1}" ,i,j);
            Console.WriteLine("The nullable double value is: " + k);
            Console.WriteLine("The nullable boolean value is: " + v);
            Console.WriteLine("After using Null coalescing operator: y = {0}, z = {1}", y, z);
            Console.ReadLine();
        }
    }
}
