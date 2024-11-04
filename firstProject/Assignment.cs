using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Assignment
    {
        public void Arithmetic()
        {
            // A operators
            int m = 2;
            int n = 5;
            int p = 7;

            int addition = m + n;
            int subtraction = n - m;
            int multiplication = m * n;
            int division = n / m;
            int modulus = p % m;

            // String interpolation
            Console.WriteLine($"m + n = {addition}");
            Console.WriteLine($"n - m = {subtraction}");
            Console.WriteLine($"m * n = {multiplication}");
            Console.WriteLine($"n / m = {division}");
            Console.WriteLine($"p % m = {modulus}");


            // R or C operators
            bool mn = m == n;
            bool np = n != p; 
            bool pp = p != p; 
            bool mp = m <= p; 
            bool nm = n >= m;

            Console.WriteLine(mn);
            Console.WriteLine(np);
            Console.WriteLine(pp);
            Console.WriteLine(mp);
            Console.WriteLine(nm);


            // L operators

            int s = 1;
            int t = 3;
            int v = 4;

            bool st = s > t && s != t; //AND to false
            bool vs = v < s || v > s; // OR to true

            Console.WriteLine(st);
            Console.WriteLine(vs);


            //Assignment operator

            int a = 0;
            int b = 2;
            int c = 4;

            int ba = b -= a; // subtract assignment 
            int bc = b += p; //add assignment 
            int ac = a -= c; // subtract assignment 
            int ca = c += a; //add assignment 

            Console.WriteLine(ba);
            Console.WriteLine(bc);
            Console.WriteLine(ac);
            Console.WriteLine(ca);

            //Increment And Decrement

            int x = 2;
            int y = 6;

            int j = ++x;
            int k = y--; 


            Console.WriteLine(j);
          
            Console.WriteLine(k);
           

        }

        public void Conditions()
        {
            int x = -1;
            int y = 0;
            int z = 1;

            if (x == z)
            {
                Console.WriteLine("X is equal to z");

            }

            else if (x > y) 
            {
                Console.WriteLine("X is less than y");

            }

            else
            {
                Console.WriteLine("No result");
            }


            if (x < y && z != y)
            {
                Console.WriteLine("AND operator");

            }
            else if (z < y || x!= y)
            {
                Console.WriteLine("OR operator");

            }
            else
            {
                Console.WriteLine("No result");
            }
        }
    }
}
