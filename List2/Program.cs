using System;
using System.Collections.Generic;

namespace list2
{
    class Program
    {
        static void Main(string[] args)
    
        {
           /*
            List<int> numlist = new List<int>();
            
            Console.WriteLine("Enter same number 5 times");


            for (int i = 0; i < 5; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i< numlist.Count; i++)
            {
                list.Add(int.Parse(Console.WriteLine()));
            }
            */


            List<int> list = new List<int>();

            Console.WriteLine("Enter numbers 1-5 until dupe detected");
            
            for(int i=0; i<5; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));

            }

            

            if (list.Contains(dupe))
            {
            int dupe = int.Parse(Console.ReadLine());
            
            for (int i=0; i < dupe.Count; i++)
            {
                System.Console.WriteLine(dupe[i]);
            }
            }   
        }   
    }
}
