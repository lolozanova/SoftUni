﻿using System;

namespace ClassBoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height =  double.Parse(Console.ReadLine());

            Box box = null;
            try
            {
                 box = new Box(length, width, height);
                Console.WriteLine(box);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
           
        }
    }
}
