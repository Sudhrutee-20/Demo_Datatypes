using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // value types
                int a = 10;
                int b = a; // b is a copy of a
                b = 20; // changing b does not affect a
                Console.WriteLine($"Value Types: a = {a}, b = {b}"); // Output: a = 10, b = 20

                Person p1 = new Person();// creating an instance of Person
                p1.Name = "Raj";
                Person p2 = new Person(); // creating another instance of Person
                p2 = p1; // p2 references the same object as p1
                p2.Name = "Ravi"; // changing p2 affects p1
                Console.WriteLine(p1.Name);      
        }
    }

}

   