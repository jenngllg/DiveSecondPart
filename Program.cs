using System;

namespace DiveSecondPart
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = System.IO.File.ReadAllLines(@"C:\Users\j.gullung\source\repos\DiveSecondPart\input.txt");
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;
            string command;
            int units;

            for (int i = 0; i < commands.Length; i++)
            {
                string[] commandAndUnit = commands[i].Split(' ');
                command = commandAndUnit[0];
                units = Int32.Parse(commandAndUnit[1]);

                switch (command)
                {
                    case "forward":
                        horizontalPosition += units;
                        depth += aim * units;
                        break;
                    case "up":
                        aim -= units;
                        break;
                    case "down":
                        aim += units;
                        break;
                }
            }
            Console.WriteLine($"horizontal position : {horizontalPosition} and depth : {depth}");
        }
    }
}
