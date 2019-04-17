﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            p.BasicEventLoop();
        }
        public double M(int i)
        {
            return M(val: i);
        }

        public int M(int val, int scale = 1, int offset = 0) => offset + val * scale;

        public void BasicEventLoop()
        {
            string PromptForInput()
            {
                string prompt = "Options: \n\t1 - Attack\n\t2 - Defend\n\tq - Quit\nChoice: ";

                Console.Write(prompt);
                return Console.ReadLine();
            }

            string input = PromptForInput();

            while (input != "q")
            {
                try
                {
                    int i = int.Parse(input);

                    Console.WriteLine($"Your input was {i}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Try again!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
