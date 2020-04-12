using System;
using System.Collections.Generic;


namespace list1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("Enter numbers 1-5 until dupe detected");
            
            for(int i=0; i<5; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));

            }

            int dupe = int.Parse(Console.ReadLine());

        if (list.Contains(dupe))
        {
            Console.WriteLine("Number already listed");
        }   
            
        }
    }
}
