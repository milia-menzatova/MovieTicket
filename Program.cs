﻿using System;

namespace MovieTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            float price = 0.0f;

            if (age >= 0 && age <= 5)
            {
                price = 0.0f;
            }
            else if (age > 5 && age <= 14)
            {
                price = 7.99f;
            }
            else if (age > 14 && age <= 65)
            {
                price = 11.99f;
            }
            else if (age > 65)
            {
                price = 9.99f;
            }
            Console.WriteLine("Price is " + price);

        }
    }
}
