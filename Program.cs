using System;
using System.IO;

namespace CreateTITpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\opilane\samples\TITpe";
            Directory.CreateDirectory(newPath);
            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                Console.WriteLine("The directory exists.");
            }
            else
            {
                Console.WriteLine("The directory does not exists.");
                Directory.CreateDirectory(newPath);
            }
            Console.ReadLine();



        }
    }
}
