using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentToFunctionAndMethods
{
    class MathService
    {
        // метод 2 задания
        public bool Segment (int x0, int x1, int x2)
        {

            bool result = x2 >= x0 && x2 <= x1 ? true : false;
            return result;
        }
       
        // метод 3 задания
        public double Distance (Point point1, Point point2)
        {
            double result =Math.Sqrt(((point2.x1 - point1.x0) *(point2.x1 - point1.x0))+((point2.y1 - point1.y0) * (point2.y1 - point1.y0)));
            return result;
        }
        
        // метод 4 задания
        public string Number(int number)
        {
            string result = $"false\n";
            if (number%2==0)
            {
                result = $"True\n";
                return result;
            }
            return result;
        }
        
        // метод 5 задания
        public double TemperatureConversion(double temperature)
        {
            const double x0 = 5;
            const double x1 = 9;
            const double coefficient0 = x0 / x1;
            const double coefficient1 = 32;
            double result = (temperature* coefficient0) + coefficient1;
            return result;
        }
        
        // метод 7 задания
        public int AreaRectangle(int width, int length)
        {
            int result = width* length;
            return result;
        }
        
        // метод 8 задания
        public int VolumeParallelepiped(int widthParallelepiped, int lengthParallelepiped, int heightParallelepiped)
        {
            int result = widthParallelepiped* lengthParallelepiped* heightParallelepiped;
            return result;
        }
        
        // метод 10 задания
        public string SomeNumber( int firstNumber, int secondNumber)
        {
            int intermediate = firstNumber;
            firstNumber = secondNumber;
            secondNumber = intermediate;
            string result=$"{firstNumber} {secondNumber}\n";
            return result;
        }

        // метод 11 задания
        public string MaxNumber0(int numberOne0, int numberTwo0)
        {
            string result = $"Значения равны\n";
            if (numberOne0!= numberTwo0)
            {
                int result0 = numberOne0 > numberTwo0 ? numberOne0 : numberTwo0;
                result=$"{result0}\n";
                return result;
            }
            return result;
        }

        //метод 12 задания
        public string MaxNumber1(int numberOne1, int numberTwo1, int numberThree1)
        {
            int max = numberOne1;
            string result = $"{max}\n";
            if (max< numberTwo1)
            {
                max = numberTwo1;
                result=$"{max}\n";
                return result;
            }
            else if (max < numberThree1)
            {
                max = numberThree1;
                result=$"{max}\n";
                return result;
            }
            return result;
        }

        // метод 13 задания
        public string MinNumber0(int minnumberOne0, int minnumberTwo0)
        {
            string result = $"Значения равны\n";
            if (minnumberOne0 != minnumberTwo0)
            {
                int result0 = minnumberOne0 < minnumberTwo0 ? minnumberOne0 : minnumberTwo0;
                result=$"{result0}\n";
                return result;
            }
            return result;
        }

        // метод 14 задания
        public string MinNumber1(int minNumberOne1, int minNumberTwo1, int minNumberThree1)
        {
            int min = minNumberOne1;
            string result = $"{min}\n";
            if (min> minNumberTwo1)
            {
                min = minNumberTwo1;
                result=$"{min}\n";
                return result;
            }
            else if(min> minNumberThree1)
            {
                min = minNumberThree1;
                result=$"{min}\n";
                return result;
            }
            return result;
        }

        // метод 18 задания
        Operation operation = new Operation();
        public string MathOperation(int numberOne18, int numberTwo18)
        {
            string result = "0";
            Operation operation = Operation.addition;
            if (operation== Operation.addition)
            {
                int result0 = numberOne18+ numberTwo18;
                result=$"{result0}\n";
                return result;
            }
            operation = Operation.multiplication;
            if (operation== Operation.multiplication)
            {
                int result0 = numberOne18 * numberTwo18;
                result=$"{result0}\n";
                return result;
            }
            operation = Operation.division;
            if (operation == Operation.division)
            {
                int result0 = numberOne18 / numberTwo18;
                result=$"{result0}\n";
                return result;
            }
            operation = Operation.difference;
            if (operation == Operation.difference)
            {
                int result0 = numberOne18 - numberTwo18;
                result=$"{result0}\n";
                return result;
            }
            return result;
        }

    }
}
