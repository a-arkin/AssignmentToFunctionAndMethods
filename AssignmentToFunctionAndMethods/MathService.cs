using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentToFunctionAndMethods
{
    class MathService
    {
        // метод 2 задания
        public void Segment (int x0, int x1, int x2)
        {

            bool result = x2 >= x0 && x2 <= x1 ? true : false;
            Console.WriteLine($"{result}\n");
        }
       
        // метод 3 задания
        public double Distance (Point point1, Point point2)
        {
            double result =Math.Sqrt(((point2.x1 - point1.x0) *(point2.x1 - point1.x0))+((point2.y1 - point1.y0) * (point2.y1 - point1.y0)));
            return result;
        }
        
        // метод 4 задания
        public void Number(int number)
        {
            if (number%2==0)
            {
                Console.WriteLine("True\n");
            }
            else
            {
                Console.WriteLine("False\n");
            }
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
        public void AreaRectangle(int width, int length)
        {
            int result = width* length;
            Console.WriteLine($"{result}\n");
        }
        
        // метод 8 задания
        public void VolumeParallelepiped(int widthParallelepiped, int lengthParallelepiped, int heightParallelepiped)
        {
            int result = widthParallelepiped* lengthParallelepiped* heightParallelepiped;
            Console.WriteLine($"{result}\n");
        }
        
        // метод 10 задания
        public int firstNumber;
        public int secondNumber;
        public void SomeNumber( int firstNumber, int secondNumber)
        {
            int intermediate = firstNumber;
            firstNumber = secondNumber;
            secondNumber = intermediate;

            Console.WriteLine($"{firstNumber} {secondNumber}\n");
            // не понял, как выводить через ref. По итоге приравнивал оба значения
        }

        // метод 11 задания
        public int numberOne0;
        public int numberTwo0;
        public void MaxNumber0(int numberOne0, int numberTwo0)
        {
            if (numberOne0!= numberTwo0)
            {
                int result = numberOne0 > numberTwo0 ? numberOne0 : numberTwo0;
                Console.WriteLine($"{result}\n");
            }
            else
            {
                Console.WriteLine($"Значения равны\n");
            }
        }

        //метод 12 задания
        public int numberOne1;
        public int numberTwo1;
        public int numberThree1;
        public void MaxNumber1(int numberOne1, int numberTwo1, int numberThree1)
        {
            int max = numberOne1;
            if (max< numberTwo1)
            {
                max = numberTwo1;
                Console.WriteLine($"{max}\n");
            }
            else if (max < numberThree1)
            {
                max = numberThree1;
                Console.WriteLine($"{max}\n");
            }
            else
            {
                Console.WriteLine($"{max}\n");
            }
        }

        // метод 13 задания
        public int minnumberOne0;
        public int minnumberTwo0;
        public void MinNumber0(int minnumberOne0, int minnumberTwo0)
        {
            if (minnumberOne0 != minnumberTwo0)
            {
                int result = minnumberOne0 < minnumberTwo0 ? minnumberOne0 : minnumberTwo0;
                Console.WriteLine($"{result}\n");
            }
            else
            {
                Console.WriteLine($"Значения равны\n");
            }
        }

        // метод 14 задания
        public int minNumberOne1;
        public int minNumberTwo1;
        public int minNumberThree1;
        public void MinNumber1(int minNumberOne1, int minNumberTwo1, int minNumberThree1)
        {
            int min = minNumberOne1;
            if (min> minNumberTwo1)
            {
                min = minNumberTwo1;
                Console.WriteLine($"{min}\n");
            }
            else if(min> minNumberThree1)
            {
                min = minNumberThree1;
                Console.WriteLine($"{min}\n");
            }
            else
            {
                Console.WriteLine($"{min}\n");
            }
        }

        // метод 18 задания
        public int numberOne18;
        public int numberTwo18;
        Operation operation = new Operation();
        public void MathOperation(int numberOne18, int numberTwo18)
        {
            Operation operation = Operation.addition;
            if (operation== Operation.addition)
            {
                int result = numberOne18+ numberTwo18;
                Console.WriteLine($"{result}\n");
            }
            operation = Operation.multiplication;
            if (operation== Operation.multiplication)
            {
                int result = numberOne18 * numberTwo18;
                Console.WriteLine($"{result}\n");
            }
            operation = Operation.division;
            if (operation == Operation.division)
            {
                int result = numberOne18 / numberTwo18;
                Console.WriteLine($"{result}\n");
            }
            operation = Operation.difference;
            if (operation == Operation.difference)
            {
                int result = numberOne18 - numberTwo18;
                Console.WriteLine($"{result}\n");
            }
        }

    }
}
