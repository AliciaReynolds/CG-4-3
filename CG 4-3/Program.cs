﻿using System;

namespace CG_4_3
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int Names = 0; Names < 31; Names++)
            {
                Console.WriteLine("Please enter a name.");
                var name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    { 
                    break;
                }


            }


            Console.ReadLine();
        }
    }
}
