using System;

namespace AssignmentToFunctionAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            Console.WriteLine("Задание №1");
            TextService name = new TextService();
            string name0 = "Александр";
            string resultname0 = name.Hello(name0);
            Console.WriteLine($"{resultname0}\n");

            //2 задание
            Console.WriteLine("Задание №2");
            MathService points = new MathService();
            int x0 = 1;
            int x1 = 4;
            int x2 = 2;
            bool result11=points.Segment(x0, x1, x2);
            Console.WriteLine($"{result11}\n");
            

            //3 задание
            Console.WriteLine("Задание №3");
            MathService distance = new MathService();
            Point point1 = new Point();
            point1.x0 = 1;
            point1.y0 = 5;
            Point point2 = new Point();
            point2.x1 = 4;
            point2.y1 = 10;
            double resultFromMathService = distance.Distance(point1, point2);
            Console.WriteLine($"{resultFromMathService}\n");

            //4 задание
            Console.WriteLine("Задание №4");
            MathService number = new MathService();
            int number0 = 12;
            number.Number(number0);

            //5 задание
            Console.WriteLine("Задание №5");
            MathService temperature = new MathService();
            double temperature0 = 6;
            double resultFromTemperature= temperature.TemperatureConversion(temperature0);
            Console.WriteLine($"{resultFromTemperature}\n");

            //6 задание
            Console.WriteLine("Задание №6");
            TextService address = new TextService();
            string addresCity = "Тольятти";
            string addresStreet = "Свердлова";
            int addresHouseNumber = 24;
            int addresApartmentNumber = 64;
            address.Address(addresCity, addresStreet, addresHouseNumber, addresApartmentNumber);

            //7 задание
            Console.WriteLine("Задание №7");
            MathService areaRectangle = new MathService();
            int width =10;
            int length =5;
            areaRectangle.AreaRectangle(width, length);

            //8 задание
            Console.WriteLine("Задание №8");
            MathService volumeParallelepiped = new MathService();
            int widthParallelepiped =1;
            int lengthParallelepiped =5;
            int heightParallelepiped =4;
            volumeParallelepiped.VolumeParallelepiped(widthParallelepiped, lengthParallelepiped, heightParallelepiped);

            //9 задание
            Console.WriteLine("Задание №9");
            CalendarService convertHours = new CalendarService();
            convertHours.hours = 1;
            convertHours.ConvertHours(convertHours.hours);

            //10 задание
            Console.WriteLine("Задание №10");
            MathService someNumber = new MathService();
            someNumber.firstNumber =32;
            someNumber.secondNumber =64;
            someNumber.SomeNumber(someNumber.firstNumber, someNumber.secondNumber);

            //11 задание
            Console.WriteLine("Задание №11");
            MathService мaxNumber0 = new MathService();
            мaxNumber0.numberOne0 = 3;
            мaxNumber0.numberTwo0 = 1;
            мaxNumber0.MaxNumber0(мaxNumber0.numberOne0, мaxNumber0.numberTwo0);

            //12 задание
            Console.WriteLine("Задание №12");
            MathService мaxNumber1 = new MathService();
            мaxNumber1.numberOne1 = 3;
            мaxNumber1.numberTwo1 = 5;
            мaxNumber1.numberThree1 = 1;
            мaxNumber1.MaxNumber1(мaxNumber1.numberOne1, мaxNumber1.numberTwo1, мaxNumber1.numberThree1);

            //13 задание
            Console.WriteLine("Задание №13");
            MathService minNumber0 = new MathService();
            minNumber0.minnumberOne0 = 5;
            minNumber0.minnumberTwo0 = 4;
            minNumber0.MinNumber0(minNumber0.minnumberOne0, minNumber0.minnumberTwo0);

            //14 задание
            Console.WriteLine("Задание №14");
            MathService minNumber1 = new MathService();
            minNumber1.minNumberOne1 = 1;
            minNumber1.minNumberTwo1 = 3;
            minNumber1.minNumberThree1 = 5;
            minNumber1.MinNumber1(minNumber1.minNumberOne1, minNumber1.minNumberTwo1, minNumber1.minNumberThree1);

            //15 задание
            Console.WriteLine("Задание №15");
            CalendarService month = new CalendarService();
            month.monthNumber = 10;
            month.Month(month.monthNumber);

            //16 задание
            Console.WriteLine("Задание №16");
            PersonInfo personInfo = new PersonInfo();
            personInfo.name = "Александр";
            personInfo.gender = "Мужской";
            PersonParams personParams = new PersonParams();
            personParams.age =26;
            personParams.weight =72;
            personParams.growth =174;
            PersonService personService = new PersonService();
            personService.PersonFullInfo(personInfo, personParams);

            //17 задание
            Console.WriteLine("Задание №17");
            PersonInfo personInfo1 = new PersonInfo();
            personInfo1.name = "Михаил";
            personInfo1.gender = "Мужской";
            PersonParams personParams1 = new PersonParams();
            personParams1.age = 27;
            personParams1.weight = 64;
            personParams1.growth = 172;
            PersonService personService1 = new PersonService();

            Console.WriteLine($"Классификация по максимальному возрасту\n");
            personService1.MaxAge(personParams, personParams1, personInfo, personInfo1);

            Console.WriteLine($"Классификация по максимальному весу\n");
            personService1.MaxWeight(personParams, personParams1, personInfo, personInfo1);

            Console.WriteLine($"Классификация по максимальному росту\n");
            personService1.MaxGrowth(personParams, personParams1, personInfo, personInfo1);

            Console.WriteLine($"Классификация по минимальному возрасту\n");
            personService1.MinAge(personParams, personParams1, personInfo, personInfo1);

            Console.WriteLine($"Классификация по минимальному весу\n");
            personService1.MinWeight(personParams, personParams1, personInfo, personInfo1);

            Console.WriteLine($"Классификация по минимальному росту\n");
            personService1.MinGrowth(personParams, personParams1, personInfo, personInfo1);

            //18 задание
            Console.WriteLine("Задание №18");
            MathService mathOperation = new MathService();
            mathOperation.numberOne18 =4;
            mathOperation.numberTwo18 =2;
            mathOperation.MathOperation(mathOperation.numberOne18, mathOperation.numberTwo18);

            //19 задание
            Console.WriteLine("Задание №19");
            TextFile textFile0 = new TextFile();
            textFile0.title = "Название 1";
            textFile0.description = "Описание 1";
            textFile0.memorySize = 15;
            TextFile textFile1 = new TextFile();
            textFile1.title = "Название 2";
            textFile1.description = "Описание 2";
            textFile1.memorySize = 20;
            TextService textService19 = new TextService();
            textService19.TextService19(textFile0, textFile1);


            //20 задание
            Console.WriteLine("Задание №20");
            TextService textService20 = new TextService();
            textService20.TextService20(textFile0);

            //21 задание
            Console.WriteLine("Задание №21");
            TextService textService21 = new TextService();
            string description2 = "Дополнительное описание";
            textService21.TextService21(textFile1, description2);
        }
    }
}
