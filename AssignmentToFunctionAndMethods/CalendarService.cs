using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentToFunctionAndMethods
{
    class CalendarService
    {
        // метод 9 задания
        public int ConvertHours(int hours)
        {
            const int minutesOfHours = 60;
            int result = hours* minutesOfHours;
            return result;
        }

        // метод 15 задания
        public string Month(int monthNumber)
        {
            string result = Convert.ToString (monthNumber);
            switch(monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    result=$"Зима\n";
                    return result;
                case 3:
                case 4:
                case 5:
                    result=$"Весна\n";
                    return result;
                case 6:
                case 7:
                case 8:
                    result=$"Лето\n";
                    return result;
                case 9:
                case 10:
                case 11:
                    result=$"Осень\n";
                    return result;
                default:
                    result = $"Введено неправильное значение\n";
                    return result;
            }
        }

    }
}
