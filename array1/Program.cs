using System;

namespace Lists_and_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string [] name = new string[5];
            name[0] = "Sam";
            name[1] = "Eric";
            name[2] = "Justin";
            name[3] = "Chris";
            name[4] = "Darius";

            
            Console.WriteLine("Hello " + name[0]);
            Console.WriteLine("Hello " + name[1]);
            Console.WriteLine("Hello " + name[2]);
            Console.WriteLine("Hello " + name[3]);
            Console.WriteLine("Hello " + name[4]);


        }
    }
}
