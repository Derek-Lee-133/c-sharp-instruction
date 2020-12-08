﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ch07_product_manager.business
{
	class MyConsole
    {

        public static String getString(String prompt)
        {
           Console.WriteLine(prompt);
            // read user entry
            String s = Console.ReadLine();  // discard any other data entered on the line
            return s;
        }

        public static int getInt(String prompt)
        {
            int i = 0;
            bool isValid = false;
            while (!isValid)
            {
               Console.WriteLine(prompt);
                try
                {
                    i = Int32.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e){
                
                   Console.WriteLine("Error! Invalid integer. Try again.");
                }
                Console.ReadLine();  // discard any other data entered on the line
            }
            return i;
        }

        public static int getInt(String prompt, int min, int max)
        {
            int i = 0;
            bool isValid = false;
            while (!isValid)
            {
                i = getInt(prompt);
                if (i <= min)
                {
                   Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                }
                else if (i >= max)
                {
                   Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return i;
        }

        public static double getDouble(String prompt)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
               Console.WriteLine(prompt);
                if (sc.hasNextDouble())
                {
                    d = sc.nextDouble();
                    isValid = true;
                }
                else
                {
                   Console.WriteLine("Error! Invalid number. Try again.");
                }
                Console.ReadLine();  // discard any other data entered on the line
            }
            return d;
        }

        public static double getDouble(String prompt, double min, double max)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
                d = getDouble(prompt);
                if (d <= min)
                {
                   Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                }
                else if (d >= max)
                {
                   Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return d;
        }

    }
}
