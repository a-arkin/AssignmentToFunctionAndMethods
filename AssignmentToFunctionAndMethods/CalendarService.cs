﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentToFunctionAndMethods
{
    class CalendarService
    {
        // метод 9 задания
        public int hours;
        public void ConvertHours(int hours)
        {
            const int minutesOfHours = 60;
            int result = hours* minutesOfHours;
            Console.WriteLine($"{result}\n");
        }

        // метод 15 задания
        public int monthNumber;
        public void Month(int month)
        {
            switch(monthNumber)
            {
                case 1:
                case 2:
                    Console.WriteLine($"Зима\n");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Весна\n");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"Лето\n");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"Осень\n");
                    break;
                case 12:
                    Console.WriteLine($"Зима\n");
                    break;
            }
        }

    }
}
