using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentToFunctionAndMethods
{
    class TextService
    {
        //метод 1 задания
        public string Hello(string name)
        {
            string hello = "Привет, ";
            string punctuationMark = "!";
            string getGreetings = hello + name + punctuationMark;
            return getGreetings;
        }

        // метод 6 задания
        public string Address(string addresCity, string addresStreet, int addresHouseNumber, int addresApartmentNumber)
        {
            string result=$"Город {addresCity}, улица {addresStreet}, дом {addresHouseNumber}, квартира {addresApartmentNumber}\n";
            return result;
        }

        // метод 19 задания
        public string TextService19(TextFile textFile0, TextFile textFile1)
        {
            string result0 = $"{textFile0.title}  {textFile1.title}";
            string result1 = $"{textFile0.description} {textFile1.description}";
            int result2 = textFile0.memorySize+ textFile1.memorySize;
            string result=$"Название - {result0}\nОписание - {result1}\nВес - {result2}\n";
            return result;
        }

        //метод 20 задания
        public string TextService20(TextFile textFile0)
        {
            textFile0.description = null;
            textFile0.memorySize = 0;
            string result=$"Название - {textFile0.title}\nОписание - {textFile0.description}\nВес - {textFile0.memorySize}\n";
            return result;
        }

        // метод 21 задания
        public string TextService21(TextFile textFile1, string description2)
        {
            string result0 = $"{textFile1.description} {description2}";
            string result=$"Название - {textFile1.title}\nОписание - {result0}\n Вес - {textFile1.memorySize}\n";
            return result;
        }
    }
}