﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises___Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Please enter a letter and I will tell you whether it's a vowel or not: y is a consonant");
            string letter = Console.ReadLine();
            Console.WriteLine("Please press enter to exit");
            vowel(letter);

            //Question 2:
            Console.WriteLine("Please enter you weight in KGs");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in CMs ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Your BMI is " + (weight/(height*height)));

            //Question 3:
            int total = 0;

            for (int i = 1; i <=20; i++ )
            {
                Console.WriteLine($"Please enter number  {i}: ");
                total = total + int.Parse(Console.ReadLine());
                      
            }
            Console.WriteLine("The sum of all your number are " + total);

            //Question 4:
            int factorial = 1;
            int n = 1;

            while (n <= 10)
            {
                factorial *= n;
                n++;
            }
            Console.WriteLine("10 factorial is " + factorial);

            //Question 5:
           
        
       
        }

        public static void vowel(string letter)
        {
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" )
            {
                Console.WriteLine("The letter you entered is a VOWEL!");
            } else
            {
                Console.WriteLine("The letter you entered is a consonant.");
            }
        }

       
    }
}
