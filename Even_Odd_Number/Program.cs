﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_Number
{
    public class Program
    {
         static void Main(string[] args) 
         {
         
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }

            Console.ReadLine();
         }

    }
}

