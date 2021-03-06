﻿using System;
using System.Collections.Generic;
using advent_of_code_2019.day1;
using advent_of_code_2019.day2;
using advent_of_code_2019.day3;
using advent_of_code_2019.day4;
using advent_of_code_2019.day5;
using advent_of_code_2019.day6;
using advent_of_code_2019.day7;
using advent_of_code_2019.day9;
using advent_of_code_2019.day11;
using advent_of_code_2019.day18;

namespace advent_of_code_2019
{
    class Program
    {
        static Dictionary<int, Action> DaySolutions =
            new Dictionary<int, Action>() {
                { 1, Day1.Run },
                { 2, Day2.Run },
                { 3, Day3.Run },
                { 4, Day4.Run },
                { 5, Day5.Run },
                { 6, Day6.Run },
                { 7, Day7.Run },
                { 9, Day9.Run },
                { 11, Day11.Run },
                { 18, Day18.Run },
            };

        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter day number:");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int inputNumber) &&
                DaySolutions.TryGetValue(inputNumber, out Action RunFunction))
            {
                RunFunction();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Number, please. Now start over.");
            }
        }
    }
}