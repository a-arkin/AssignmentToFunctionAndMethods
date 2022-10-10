using System;

namespace AssignmentToFunctionAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            Console.WriteLine("Задание №1");
            TextService hello = new TextService();
            string name = "Александр";
            string greeting = hello.Hello(name);
            Console.WriteLine($"{greeting}\n");

            //2 задание
            Console.WriteLine("Задание №2");
            MathService segment = new MathService();
            int x0 = 1;
            int x1 = 4;
            int x2 = 2;
            bool intersection = segment.Segment(x0, x1, x2);
            Console.WriteLine($"{intersection}\n");
            

            //3 задание
            Console.WriteLine("Задание №3");
            MathService distance = new MathService();
            Point point1 = new Point();
            point1.x0 = 1;
            point1.y0 = 5;
            Point point2 = new Point();
            point2.x1 = 4;
            point2.y1 = 10;
            double resultDistance = distance.Distance(point1, point2);
            Console.WriteLine($"{resultDistance}\n");

            //4 задание
            Console.WriteLine("Задание №4");
            MathService number = new MathService();
            int number0 = 12;
            string parity=number.Number(number0);
            Console.WriteLine($"{parity}\n");

            //5 задание
            Console.WriteLine("Задание №5");
            MathService temperature = new MathService();
            double temperature0 = 6;
            double resultFarengeite= temperature.TemperatureConversion(temperature0);
            Console.WriteLine($"{resultFarengeite}\n");

            //6 задание
            Console.WriteLine("Задание №6");
            TextService address = new TextService();
            string addresCity = "Тольятти";
            string addresStreet = "Свердлова";
            int addresHouseNumber = 24;
            int addresApartmentNumber = 64;
            string addres=address.Address(addresCity, addresStreet, addresHouseNumber, addresApartmentNumber);
            Console.WriteLine($"{addres}\n");

            //7 задание
            Console.WriteLine("Задание №7");
            MathService areaRectangle = new MathService();
            int width =10;
            int length =5;
            int resultAreaRectangle=areaRectangle.AreaRectangle(width, length);
            Console.WriteLine($"{resultAreaRectangle}\n");

            //8 задание
            Console.WriteLine("Задание №8");
            MathService volumeParallelepiped = new MathService();
            int widthParallelepiped =1;
            int lengthParallelepiped =5;
            int heightParallelepiped =4;
            int resultVoumeParallelepiped=volumeParallelepiped.VolumeParallelepiped(widthParallelepiped, lengthParallelepiped, heightParallelepiped);
            Console.WriteLine($"{resultAreaRectangle}\n");

            //9 задание
            Console.WriteLine("Задание №9");
            CalendarService convertHours = new CalendarService();
            int hours = 1;
            int resultConvertToMinets=convertHours.ConvertHours(hours);
            Console.WriteLine($"{resultConvertToMinets}\n");

            //10 задание
            Console.WriteLine("Задание №10");
            MathService someNumber = new MathService();
            int firstNumber =32;
            int secondNumber =64;
            string invertedNumber = someNumber.SomeNumber(firstNumber, secondNumber);
            Console.WriteLine($"{invertedNumber}\n");

            //11 задание
            Console.WriteLine("Задание №11");
            MathService мaxNumber0 = new MathService();
            int numberOne0 = 3;
            int numberTwo0 = 1;
            string resultMaxNumber0=мaxNumber0.MaxNumber0(numberOne0, numberTwo0);
            Console.WriteLine($"{resultMaxNumber0}\n");

            //12 задание
            Console.WriteLine("Задание №12");
            MathService мaxNumber1 = new MathService();
            int numberOne1 = 3;
            int numberTwo1 = 5;
            int numberThree1 = 1;
            string resultmaxNumber1=мaxNumber1.MaxNumber1(numberOne1, numberTwo1, numberThree1);
            Console.WriteLine($"{resultmaxNumber1}\n");

            //13 задание
            Console.WriteLine("Задание №13");
            MathService minNumber0 = new MathService();
            int minnumberOne0 = 5;
            int minnumberTwo0 = 4;
            string resultMinNumber=minNumber0.MinNumber0(minnumberOne0, minnumberTwo0);
            Console.WriteLine($"{resultMinNumber}\n");

            //14 задание
            Console.WriteLine("Задание №14");
            MathService minNumber1 = new MathService();
            int minNumberOne1 = 1;
            int minNumberTwo1 = 3;
            int minNumberThree1 = 5;
            string resultMinNumber1=minNumber1.MinNumber1(minNumberOne1, minNumberTwo1, minNumberThree1);
            Console.WriteLine($"{resultMinNumber1}\n");

            //15 задание
            Console.WriteLine("Задание №15");
            CalendarService month = new CalendarService();
            int monthNumber = 10;
            string resultSeason=month.Month(monthNumber);
            Console.WriteLine($"{resultSeason}\n");

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
            string resultPersonService0=personService.PersonFullInfo(personInfo, personParams);
            Console.WriteLine($"{resultPersonService0}\n");

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
            string resultMaxAge=personService1.MaxAge(personParams, personParams1, personInfo, personInfo1);
            Console.WriteLine($"{resultMaxAge}\n");

            Console.WriteLine($"Классификация по максимальному весу\n");
            string resultMaxWeight=personService1.MaxWeight(personParams, personParams1, personInfo, personInfo1);
            Console.WriteLine($"{resultMaxWeight}\n");

            Console.WriteLine($"Классификация по максимальному росту\n");
            string resultMaxGrowth=personService1.MaxGrowth(personParams, personParams1, personInfo, personInfo1);
            Console.WriteLine($"{resultMaxGrowth}\n");

            Console.WriteLine($"Классификация по минимальному возрасту\n");
            string resultMinAge=personService1.MinAge(personParams, personParams1, personInfo, personInfo1);
            Console.WriteLine($"{resultMinAge}\n");

            Console.WriteLine($"Классификация по минимальному весу\n");
            string resultMinWeigth=personService1.MinWeight(personParams, personParams1, personInfo, personInfo1);
            Console.WriteLine($"{resultMinWeigth}\n");

            Console.WriteLine($"Классификация по минимальному росту\n");
            string resultMinGrowth=personService1.MinGrowth(personParams, personParams1, personInfo, personInfo1);
            Console.WriteLine($"{resultMinGrowth}\n");

            //18 задание
            Console.WriteLine("Задание №18");
            MathService mathOperation = new MathService();
            int numberOne18 =4;
            int numberTwo18 =2;
            string resultMathOperation=mathOperation.MathOperation(numberOne18, numberTwo18);
            Console.WriteLine($"{resultMathOperation}\n");


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
            string resultTextService19=textService19.TextService19(textFile0, textFile1);
            Console.WriteLine($"{resultTextService19}\n");


            //20 задание
            Console.WriteLine("Задание №20");
            TextService textService20 = new TextService();
            string resultTextOperation20=textService20.TextService20(textFile0);
            Console.WriteLine($"{resultTextOperation20}\n");

            //21 задание
            Console.WriteLine("Задание №21");
            TextService textService21 = new TextService();
            string description2 = "Дополнительное описание";
            string resultTextOperation21=textService21.TextService21(textFile1, description2);
            Console.WriteLine($"{resultTextOperation21}\n");
        }
    }
}
