﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_week_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hey there! Welcome to your Fortune!");
            Console.WriteLine("type your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("type your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birthmonth?");
            int birthmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV color. If you do not Know what a ROYGBIV color is type \" Help\"");
            string color = Console.ReadLine();

            if (color.Equals("Help", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("ROYGBIV color is either Red, Blue, Orange, Green, Yellow, Indigo, Violet.");
                Console.WriteLine("Now enter your favorite color!");
                color = Console.ReadLine();
                Console.WriteLine(color + " This is the Color you have entered. Great Choice!");
            }
            else
            {
                Console.WriteLine("That is GREAT ROYGBIV color!");
            }

            Console.WriteLine("Hey! How many siblings do you have? as a digit");
            int Siblings_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Hey that is a lot, You should be an only kid!");
            // Part one is done these were the questions I asked//

            //Part 2//

            int yearsRetrd;
            if (age % 2 == 0)
            {
                yearsRetrd = 30;
            }
            else
            {
                yearsRetrd = 35;
            }
            string vacationHome;

            if (Siblings_number < 0)
            {
                vacationHome = "Cleveland in the snow";
            }
            else if (Siblings_number == 0)
            {
                vacationHome = " China eating noodles ";
            }
            else if (Siblings_number == 1)
            {
                vacationHome = " Greece looking for Oil ";
            }
            else if (Siblings_number == 2)
            {
                vacationHome = "Canada eating maple syrup";
            }
            else if (Siblings_number == 3)
            {
                vacationHome = " Washington climbing the mountains";
            }
            else
            {
                vacationHome = "To the Moon";
            }
            // These are the vaction homes//

            string transportation;

            if(color.Equals("Red", StringComparison.CurrentCultureIgnoreCase))               
                {
                    transportation = "Jet";
                }
            else if (color.Equals("Blue", StringComparison.CurrentCultureIgnoreCase))
                 {
                transportation = " Plane";
                 }
            else if (color.Equals("Yellow", StringComparison.CurrentCultureIgnoreCase))

                {
                transportation = " Car";
            }
            else if (color.Equals("Indigo", StringComparison.CurrentCultureIgnoreCase))
                {
                transportation = " A Skate Board";
            }
            else if (color.Equals("Green", StringComparison.CurrentCultureIgnoreCase))
                {
                transportation = " A HoverBoard";
            }
            else if (color.Equals("Orange", StringComparison.CurrentCultureIgnoreCase))
                {
                transportation = " A Fly a Kite";
            }
            else if (color.Equals("Violet", StringComparison.CurrentCultureIgnoreCase))
                {
                transportation = "  A Horse";
            }

            else
            {
                transportation = "Your tennis shoes";
            }

            float  bank;
            if(birthmonth >=1 && birthmonth <= 4)
            {
                 bank = 7500f;
            }

            else if ( birthmonth >= 5 && birthmonth <= 8)
            {
                 bank = 1000f;
            }

            else if (birthmonth >= 9 && birthmonth <=12)
            {
                bank = 2500f;
            }
            
            else 
            {
                bank = 0f;
            }

            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsRetrd + " years with " + bank + " dollars a vacation home in " +  vacationHome +  " with a " + transportation + ".");


        }
    }
}








